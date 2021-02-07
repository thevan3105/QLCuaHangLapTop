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
using System.Drawing.Imaging;

namespace QLCHLT
{
    public partial class LapTop : Form
    {
        public LapTop()
        {
            InitializeComponent();
            load();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");

        void load()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Laptop", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvLapTop.DataSource = dt;
            conn.Close();
        }
        void loadNhapLai()
        {
            txtMaMay.Text = "";
            txtTenMay.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            cbHang.Text = "";
            txtNamSX.Text = "";
            txtMauSac.Text = "";
            txtBaoHanh.Text = "";
            txtMoTa.Text = "";
            txtSoLuong.Text = "";
            ptbAnhSP.Image = null;
            txtMaMay.Focus();
        }

        private void LapTop_Load(object sender, EventArgs e)
        {
            load();
        }

        private void DgvLapTop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtImagePath.Enabled = true;
            int i;
            i = dgvLapTop.CurrentRow.Index;
            txtMaMay.Text = dgvLapTop.Rows[i].Cells[0].Value.ToString();
            txtTenMay.Text = dgvLapTop.Rows[i].Cells[1].Value.ToString();
            txtGiaNhap.Text = dgvLapTop.Rows[i].Cells[2].Value.ToString();
            txtGiaBan.Text = dgvLapTop.Rows[i].Cells[3].Value.ToString();
            cbHang.Text = dgvLapTop.Rows[i].Cells[4].Value.ToString();
            txtNamSX.Text = dgvLapTop.Rows[i].Cells[5].Value.ToString();
            txtMauSac.Text = dgvLapTop.Rows[i].Cells[6].Value.ToString();
            txtBaoHanh.Text = dgvLapTop.Rows[i].Cells[7].Value.ToString();
            txtMoTa.Text = dgvLapTop.Rows[i].Cells[8].Value.ToString();
            txtSoLuong.Text = dgvLapTop.Rows[i].Cells[9].Value.ToString();
            //ngu
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dgvLapTop.Rows[e.RowIndex];
            //    try
            //    {
            //        txtMaMay.Text = row.Cells[0].Value.ToString();
            //        txtTenMay.Text = row.Cells[1].Value.ToString();
            //        txtGiaNhap.Text = row.Cells[2].Value.ToString();
            //        txtGiaBan.Text = row.Cells[3].Value.ToString();
            //        cbHang.Text = row.Cells[4].Value.ToString();
            //        txtNamSX.Text = row.Cells[5].Value.ToString();
            //        txtMauSac.Text = row.Cells[6].Value.ToString();
            //        txtBaoHanh.Text = row.Cells[7].Value.ToString();
            //        txtMoTa.Text = row.Cells[8].Value.ToString();
            //        txtSoLuong.Text = row.Cells[9].Value.ToString();
            //        txtImagePath.Text = row.Cells[10].Value.ToString();
            //        //if (row.Cells[10] != null)
            //        //{
            //        //    Byte[] data = new Byte[1];
            //        //    data = (Byte[])(row.Cells[10].Value);
            //        //    MemoryStream mem = new MemoryStream(data);
            //        //    ptbAnhSP.Image = Image.FromStream(mem);
            //        //}
            //        //else
            //        //    ptbAnhSP.Image = null;
            //    }
            //    catch (Exception)
            //    {
            //        ptbAnhSP.Image = null;
            //        MessageBox.Show("Không có hình ảnh trong cơ sở dữ liệu hoặc hàng bạn chọn trống!");
            //        return;
            //    }
            //}
        }

        //public bool ThumbnailCallback()
        //{
        //    return false;
        //}

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [Obsolete]
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMay.Text.Length == 0 || txtTenMay.Text.Length == 0 || txtGiaNhap.Text.Length == 0 || txtGiaBan.Text.Length == 0 || cbHang.Text.Length == 0 || txtNamSX.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Query = $"INSERT INTO LapTop (MaMay, TenMay, GiaNhap, GiaBan, Hang, NamSX, MauSac, BaoHanh, MoTa, SoLuong) " +
                               $"VALUES('{txtMaMay.Text}', '{txtTenMay.Text}', '{txtGiaNhap.Text}', '{txtGiaBan.Text}', '{cbHang.Text}', '{txtNamSX.Text}', '{txtMauSac.Text}', '{txtBaoHanh.Text}', '{txtMoTa.Text}', '{txtSoLuong.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                cmd.Dispose();
                load();
                try
                {
                    byte[] b1 = ImageToByteArray(ptbAnhSP.Image);
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand("update LapTop set imgSP=(@anhSP) where MaMay=(@MaMay)", conn);
                    cmd1.Parameters.Add("@anhSP", b1);
                    cmd1.Parameters.Add("@MaMay", txtMaMay.Text);
                    cmd1.ExecuteNonQuery();
                    cmd1.Dispose();
                    load();
                }
                catch
                {
                    MessageBox.Show("Bạn chưa thêm ảnh!");
                }
                finally
                {
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
            finally
            {
                conn.Close();
            }
            //try
            //{
            //    byte[] b = ImageToByteArray(ptbAnhSP.Image);
            //    //byte[] b = PathToByteArray(this.Text);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("insert into LapTop values(@MaMay, @TenMay, @GiaNhap, @GiaBan, @Hang, @NamSX, @MauSac, @BaoHanh, @MoTa, @SoLuong, @anh)", conn);
            //    cmd.Parameters.Add("@MaMay", txtMaMay.Text);
            //    cmd.Parameters.Add("@TenMay", txtTenMay.Text);
            //    cmd.Parameters.Add("@GiaNhap", txtGiaNhap.Text);
            //    cmd.Parameters.Add("@GiaBan", txtGiaBan.Text);
            //    cmd.Parameters.Add("@Hang", cbHang.Text);
            //    cmd.Parameters.Add("@NamSX", txtNamSX.Text);
            //    cmd.Parameters.Add("@MauSac", txtMauSac.Text);
            //    cmd.Parameters.Add("@BaoHanh", txtBaoHanh.Text);
            //    cmd.Parameters.Add("@MoTa", txtMoTa.Text);
            //    cmd.Parameters.Add("@SoLuong", txtSoLuong.Text);
            //    cmd.Parameters.Add("@anh", b);
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("Lưu thành công!");
            //    load();
            //}
            //catch
            //{
            //    MessageBox.Show("Lưu thất bại!");
            //}
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        //byte[] PathToByteArray(string path)
        //{
        //    return File.ReadAllBytes(path);
        //}

        //byte[] PathToByteArray(string path)
        //{
        //    MemoryStream m = new MemoryStream();
        //    Image img = Image.FromFile(path);
        //    img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
        //    return m.ToArray();
        //}

        private void BtnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = openFileDialog1.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ptbAnhSP.ImageLocation = openFileDialog1.FileName;
                txtImagePath.Text = openFileDialog1.FileName;
            }
        }


        //byte[] PathToByteArray(string path)
        //{
        //    return File.ReadAllBytes(path);
        //}

        //private byte[] covertImageToBytes()
        //{
        //    FileStream fs;
        //    fs = new FileStream(txtImagePath.Text, FileMode.Open, FileAccess.Read);
        //    byte[] picbyte = new byte[fs.Length];
        //    fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
        //    fs.Close();
        //    return picbyte;
        //}

        [Obsolete]
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtMaMay.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Insert_Query = ($"update LapTop set TenMay = '{txtTenMay.Text}',GiaNhap='{txtGiaNhap.Text}',GiaBan='{txtGiaBan.Text}',Hang='{cbHang.Text}', NamSX='{txtNamSX.Text}', MauSac='{txtMauSac.Text}', BaoHanh='{txtBaoHanh.Text}', MoTa='{txtMoTa.Text}', SoLuong='{txtSoLuong.Text}' where MaMay= '{txtMaMay.Text}'");
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công!");
                cmd.Dispose();
                load();
            }
            catch
            {
                MessageBox.Show("sửa thất bại!");
            }
            conn.Close();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMay.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Xóa", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = ($"DELETE LapTop WHERE MaMay ='{txtMaMay.Text}'");
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    cmd.Dispose();
                    load();
                    loadNhapLai();
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại!");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void BtnNhapLai_Click(object sender, EventArgs e)
        {
            loadNhapLai();
        }

        private void DgvLapTop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = dgvLapTop.CurrentCell.RowIndex;
                txtMaMay.Text = dgvLapTop.Rows[r].Cells[0].Value.ToString();
                txtTenMay.Text = dgvLapTop.Rows[r].Cells[1].Value.ToString();
                txtGiaNhap.Text = dgvLapTop.Rows[r].Cells[2].Value.ToString();
                txtGiaBan.Text = dgvLapTop.Rows[r].Cells[3].Value.ToString();
                cbHang.Text = dgvLapTop.Rows[r].Cells[4].Value.ToString();
                txtNamSX.Text = dgvLapTop.Rows[r].Cells[5].Value.ToString();
                txtMauSac.Text = dgvLapTop.Rows[r].Cells[6].Value.ToString();
                txtBaoHanh.Text = dgvLapTop.Rows[r].Cells[7].Value.ToString();
                txtMoTa.Text = dgvLapTop.Rows[r].Cells[8].Value.ToString();
                txtSoLuong.Text = dgvLapTop.Rows[r].Cells[9].Value.ToString();
                byte[] b = (byte[])dgvLapTop.Rows[r].Cells[10].Value;
                ptbAnhSP.Image = ByteArrayToImage(b);
                DataGridViewRow row = this.dgvLapTop.Rows[e.RowIndex];
                if (row.Cells[10] != null)
                {
                    Byte[] data = new Byte[1];
                    data = (Byte[])(row.Cells[10].Value);
                    MemoryStream mem = new MemoryStream(data);
                    ptbAnhSP.Image = Image.FromStream(mem);
                }
                else
                    ptbAnhSP.Image = null;
            }
            catch
            {
                ptbAnhSP.Image = null;
                MessageBox.Show("Không có hình ảnh trong cơ sở dữ liệu hoặc hàng bạn chọn trống!");
                return;
            }
        }

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }

        private void PtbAnhSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbAnhSP.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            worksheet.Cells[3, 3] = "BẢNG DANH SÁCH MẶT HÀNG SẢN PHẨM";
            worksheet.Cells[5, 2] = "Cửa hàng kinh doanh LapTop THEVAN";
            worksheet.Cells[6, 2] = "Địa chỉ: 123 Cách Bi- Quế Võ- Bắc Ninh";
            worksheet.Cells[7, 1] = "STT";
            worksheet.Cells[7, 2] = "Mã Máy";
            worksheet.Cells[7, 3] = "Tên Máy";
            worksheet.Cells[7, 4] = "Giá nhập";
            worksheet.Cells[7, 5] = "Giá bán";
            worksheet.Cells[7, 6] = "Hãng";
            worksheet.Cells[7, 7] = "Năm SX";
            worksheet.Cells[7, 8] = "Màu sắc";
            worksheet.Cells[7, 9] = "Bảo Hành";
            worksheet.Cells[7, 10] = "Mô tả";
            worksheet.Cells[7, 11] = "Số lượng";
            for (int i = 0; i < dgvLapTop.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    worksheet.Cells[i + 8, 1] = i + 1;
                    worksheet.Cells[i + 8, j + 2] = dgvLapTop.Rows[i].Cells[j].Value;
                }
            }
        }

        [Obsolete]
        private void BtnLuuAnh_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b1 = ImageToByteArray(ptbAnhSP.Image);
                conn.Open();
                SqlCommand cmd = new SqlCommand("update LapTop set imgSP=(@anhSP) where MaMay=(@MaMay)", conn);
                cmd.Parameters.Add("@anhSP", b1);
                cmd.Parameters.Add("@MaMay", txtMaMay.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Lưu thành công!");
                load();
            }
            catch
            {
                MessageBox.Show("Lưu thất bại!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from LapTop where TenMay like '%' + N'{txtTimKiem.Text}' + '%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvLapTop.DataSource = dt;
            conn.Close();
        }

        private void TxtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void TxtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void TxtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void TxtNamSX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
