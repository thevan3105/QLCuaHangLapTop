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

namespace QLCHLT
{
    public partial class NhanVien : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public NhanVien()
        {
            InitializeComponent();
            loadNV();
        }

        void loadNV()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NhanVien", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;
            conn.Close();
        }

        void loadNhapLai()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDTNV.Text = "";
            txtDiaChiNV.Text = "";
            txtEmail.Text = "";
            cbGioiTinh.Text = "";
            txtMaNV.Focus();
        }

        private void BtnThemNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length == 0 || txtTenNV.Text.Length == 0 || txtDiaChiNV.Text.Length == 0 || txtSDTNV.Text.Length == 0 || txtEmail.Text.Length == 0 || cbGioiTinh.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Query = $"INSERT INTO NhanVien VALUES('{txtMaNV.Text}',N'{txtTenNV.Text}', N'{txtDiaChiNV.Text}', '{txtSDTNV.Text}', '{txtEmail.Text}', N'{cbGioiTinh.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                cmd.Dispose();
                loadNV();
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

        private void BtnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Insert_Query = ($"update NhanVien set TenNV = N'{txtTenNV.Text}',DiaChi=N'{txtDiaChiNV.Text}',SDT='{txtSDTNV.Text}', Email='{txtEmail.Text}', GioiTinh=N'{cbGioiTinh.Text}' where MaNV= '{txtMaNV.Text}'");
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công!");
                cmd.Dispose();
                loadNV();
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

        private void BtnXoaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Query = $"DELETE NhanVien WHERE MaNV ='{txtMaNV.Text}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                cmd.Dispose();
                loadNV();
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

        private void BtnNhapLaiNV_Click(object sender, EventArgs e)
        {
            loadNhapLai();
        }

        private void BtnXuatNV_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            ///đổ dữ liệu vào sheet
            worksheet.Cells[3, 3] = "BẢNG DANH SÁCH NHÂN VIÊN";
            worksheet.Cells[5, 2] = "Cửa hàng kinh doanh LapTop THEVAN";
            worksheet.Cells[6, 2] = "Địa chỉ: 123 Cách Bi- Quế Võ- Bắc Ninh";
            worksheet.Cells[7, 2] = "Ngày:" + System.DateTime.Now.ToString();
            worksheet.Cells[8, 1] = "STT";
            worksheet.Cells[8, 2] = "Mã NV";
            worksheet.Cells[8, 3] = "Tên nhân viên";
            worksheet.Cells[8, 4] = "Địa chỉ";
            worksheet.Cells[8, 5] = "Số điện thoại";
            worksheet.Cells[8, 6] = "Email";
            worksheet.Cells[8, 7] = "Giới tính";
            for (int i = 0; i < dgvNhanVien.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 9, 1] = i + 1;
                    worksheet.Cells[i + 9, j + 2] = dgvNhanVien.Rows[i].Cells[j].Value;
                }
            }

        }

        private void BtnThoatNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnThemTK_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = $"INSERT INTO ID VALUES(N'{txtTaiKhoan.Text}','{txtMatKhau.Text}', '{txtMaNV.Text}', '{cbQuyen.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                cmd.Dispose();
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

        private void BtnSuaTK_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Insert_Query = ($"update ID set TaiKhoan = '{txtTaiKhoan.Text}',MatKhau='{txtMatKhau.Text}',Quyen='{cbQuyen.Text}' where MaNV= '{txtMaNV.Text}'");
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công!");
                cmd.Dispose();
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

        private void BtnXoaTK_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = $"DELETE ID WHERE MaNV ='{txtMaNV.Text}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                cmd.Dispose();
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

        private void DgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtDiaChiNV.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtSDTNV.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            cbGioiTinh.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
        }

        private void TxtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void TxtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar) >= 65 && e.KeyChar <= 122 || (e.KeyChar == 8));
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
