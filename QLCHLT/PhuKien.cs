using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLCHLT
{
    public partial class PhuKien : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public PhuKien()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from PhuKien", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvPhuKien.DataSource = dt;
            conn.Close();
        }

        void loadNhapLai()
        {
            txtMaPK.Text = "";
            txtTenPK.Text = "";
            txtHangSX.Text = "";
            txtNamSX.Text = "";
            txtMauSac.Text = "";
            txtGia.Text = "";
            txtBaoHanh.Text = "";
            txtSoLuong.Text = "";
            ptbAnhPK.Image = null;
            txtMaPK.Focus();
        }

        private void TxtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = openFileDialog1.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ptbAnhPK.ImageLocation = openFileDialog1.FileName;
                txtImagePath.Text = openFileDialog1.FileName;
            }
        }

        private void PtbAnhPK_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbAnhPK.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [Obsolete]
        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = $"INSERT INTO PhuKien (MaPK, TenPK, HangSX, NamSX, MauSac, Gia, BaoHanh, SoLuong) " +
                               $"VALUES('{txtMaPK.Text}', '{txtTenPK.Text}', '{txtHangSX.Text}', '{txtNamSX.Text}', '{txtMauSac.Text}', '{txtGia.Text}', '{txtBaoHanh.Text}', '{txtSoLuong.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                conn.Close();
                load();
                try
                {
                    byte[] b1 = ImageToByteArray(ptbAnhPK.Image);
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("update PhuKien set imgPK=(@anhPK) where MaPK=(@MaPK)", conn);
                    cmd1.Parameters.Add("@anhPK", b1);
                    cmd1.Parameters.Add("@MaPK", txtMaPK.Text);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    load();
                }
                catch
                {
                    MessageBox.Show("Bạn chưa thêm ảnh!");
                }
            }
            catch
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Insert_Query = ($"update PhuKien set TenPK = '{txtTenPK.Text}',HangSX='{txtHangSX.Text}',NamSX='{txtNamSX.Text}',MauSac='{txtMauSac.Text}', Gia='{txtGia.Text}', BaoHanh='{txtBaoHanh.Text}', SoLuong='{txtSoLuong.Text}' where MaPK= '{txtMaPK.Text}'");
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công!");
                conn.Close();
                load();
            }
            catch
            {
                MessageBox.Show("sửa thất bại!");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Xóa", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = ($"DELETE PhuKien WHERE MaPK ='{txtMaPK.Text}'");
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    conn.Close();
                    load();
                    loadNhapLai();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void BtnNhapLai_Click(object sender, EventArgs e)
        {
            loadNhapLai();
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            worksheet.Cells[3, 3] = "BẢNG DANH SÁCH MẶT HÀNG PHỤ KIỆN";
            worksheet.Cells[5, 2] = "Cửa hàng kinh doanh LapTop THEVAN";
            worksheet.Cells[6, 2] = "Địa chỉ: 123 Cách Bi- Quế Võ- Bắc Ninh";
            worksheet.Cells[7, 1] = "STT";
            worksheet.Cells[7, 2] = "Mã phụ kiện";
            worksheet.Cells[7, 3] = "Tên phụ kiện";
            worksheet.Cells[7, 4] = "Hãng";
            worksheet.Cells[7, 5] = "Năm SX";
            worksheet.Cells[7, 6] = "Màu sắc";
            worksheet.Cells[7, 7] = "Giá";
            worksheet.Cells[7, 8] = "Bảo Hành";
            worksheet.Cells[7, 9] = "Số lượng";
            for (int i = 0; i < dgvPhuKien.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    worksheet.Cells[i + 8, 1] = i + 1;
                    worksheet.Cells[i + 8, j + 2] = dgvPhuKien.Rows[i].Cells[j].Value;
                }
            }
        }

        private void DgvPhuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvPhuKien.CurrentCell.RowIndex;
                txtMaPK.Text = dgvPhuKien.Rows[r].Cells[0].Value.ToString();
                txtTenPK.Text = dgvPhuKien.Rows[r].Cells[1].Value.ToString();
                txtHangSX.Text = dgvPhuKien.Rows[r].Cells[2].Value.ToString();
                txtNamSX.Text = dgvPhuKien.Rows[r].Cells[3].Value.ToString();
                txtMauSac.Text = dgvPhuKien.Rows[r].Cells[4].Value.ToString();
                txtGia.Text = dgvPhuKien.Rows[r].Cells[5].Value.ToString();
                txtBaoHanh.Text = dgvPhuKien.Rows[r].Cells[6].Value.ToString();
                txtSoLuong.Text = dgvPhuKien.Rows[r].Cells[7].Value.ToString();
                byte[] b = (byte[])dgvPhuKien.Rows[r].Cells[8].Value;
                ptbAnhPK.Image = ByteArrayToImage(b);
                DataGridViewRow row = this.dgvPhuKien.Rows[e.RowIndex];
                if (row.Cells[8] != null)
                {
                    Byte[] data = new Byte[1];
                    data = (Byte[])(row.Cells[8].Value);
                    MemoryStream mem = new MemoryStream(data);
                    ptbAnhPK.Image = Image.FromStream(mem);
                }
                else
                    ptbAnhPK.Image = null;
            }
            catch
            {
                ptbAnhPK.Image = null;
                MessageBox.Show("Không có hình ảnh trong cơ sở dữ liệu hoặc hàng bạn chọn trống!");
                return;
            }
        }
        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        [Obsolete]
        private void BtnLuuAnh_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b1 = ImageToByteArray(ptbAnhPK.Image);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update PhuKien set imgPK=(@anhPK) where MaPK=(@MaPK)", conn);
                cmd.Parameters.Add("@anhPK", b1);
                cmd.Parameters.Add("@MaPK", txtMaPK.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Lưu thành công!");
                load();
            }
            catch
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from PhuKien where TenPK like '%' + N'{txtTimKiem.Text}' + '%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvPhuKien.DataSource = dt;
            conn.Close();
        }

        private void TxtNamSX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void TxtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
