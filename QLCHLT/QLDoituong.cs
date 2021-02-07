using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCHLT
{
    public partial class QLDoituong : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public QLDoituong()
        {
            InitializeComponent();
            loadKH();
            //loadQuyen();
        }
        void loadKH()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from KhachHang", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvKhachHang.DataSource = dt;
            conn.Close();
        }



        void loadNhapLaiKH()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDTKH.Text = "";
            txtDiaChiKH.Text = "";
            txtMaKH.Focus();
        }



        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnThoatKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnThemKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0 || txtTenKH.Text.Length == 0 || txtSDTKH.Text.Length == 0 || txtDiaChiKH.Text.Length ==0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Query = $"INSERT INTO KhachHang VALUES('{txtMaKH.Text}',N'{txtTenKH.Text}', '{txtSDTKH.Text}', N'{txtDiaChiKH.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                cmd.Dispose();
                loadKH();
            }
            catch
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnSuaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Insert_Query = ($"update KhachHang set TenKH = N'{txtTenKH.Text}',SDTKH='{txtSDTKH.Text}',DiaChiKH=N'{txtDiaChiKH.Text}' where MaKH= '{txtMaKH.Text}'");
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công!");
                cmd.Dispose();
                loadKH();
            }
            catch
            {
                MessageBox.Show("Chỉnh sửa thất bại!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnXoaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = $"DELETE KhachHang WHERE MaKH ='{txtMaKH.Text}'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    cmd.Dispose();
                    loadKH();
                    loadNhapLaiKH();
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

        private void BtnNhapLaiKH_Click(object sender, EventArgs e)
        {
            loadNhapLaiKH();
        }

        private void BtnXuatKH_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            ///đổ dữ liệu vào sheet
            worksheet.Cells[3, 3] = "BẢNG DANH SÁCH KHÁCH HÀNG";
            worksheet.Cells[5, 2] = "Cửa hàng kinh doanh LapTop THEVAN";
            worksheet.Cells[6, 2] = "Địa chỉ: 123 Cách Bi- Quế Võ- Bắc Ninh";
            worksheet.Cells[7, 2] = "Ngày:" + System.DateTime.Now.ToString();
            worksheet.Cells[8, 1] = "STT";
            worksheet.Cells[8, 2] = "Mã KH";
            worksheet.Cells[8, 3] = "Tên khách hàng";
            worksheet.Cells[8, 4] = "Số điện thoại";
            worksheet.Cells[8, 5] = "Địa chỉ";
            for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    worksheet.Cells[i + 9, 1] = i + 1;
                    worksheet.Cells[i + 9, j + 2] = dgvKhachHang.Rows[i].Cells[j].Value;
                }
            }
        }

        private void DgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKhachHang.CurrentRow.Index;
            txtMaKH.Text = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txtSDTKH.Text = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            txtDiaChiKH.Text = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
        }


        private void TxtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

    }
}
