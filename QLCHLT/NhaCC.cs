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
    public partial class NhaCC : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public NhaCC()
        {
            InitializeComponent();
            loadNCC();
        }

        void loadNCC()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NhaCC", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvNCC.DataSource = dt;
            conn.Close();
        }

        void loadNhapLaiNCC()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDTNCC.Text = "";
            txtDiaChiNCC.Text = "";
            txtMaNCC.Focus();
        }

        private void BtnThemNCC_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Length == 0 || txtTenNCC.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Query = $"INSERT INTO NhaCC VALUES('{txtMaNCC.Text}',N'{txtTenNCC.Text}', '{txtSDTNCC.Text}', N'{txtDiaChiNCC.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công!");
                cmd.Dispose();
                loadNCC();
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

        private void BtnSuaNCC_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Insert_Query = ($"update NhaCC set TenNCC = N'{txtTenNCC.Text}',SDTNCC='{txtSDTNCC.Text}',DiaChiNCC=N'{txtDiaChiNCC.Text}' where MaNCC= '{txtMaNCC.Text}'");
                SqlCommand cmd = new SqlCommand(Insert_Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công!");
                cmd.Dispose();
                loadNCC();
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

        private void BtnXoaNCC_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = $"DELETE NhaCC WHERE MaNCC ='{txtMaNCC.Text}'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    cmd.Dispose();
                    loadNCC();
                    loadNhapLaiNCC();
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

        private void BtnNhapLaiNCC_Click(object sender, EventArgs e)
        {
            loadNhapLaiNCC();
        }

        private void BtnXuatNCC_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            ///đổ dữ liệu vào sheet
            worksheet.Cells[3, 3] = "BẢNG DANH SÁCH NHÀ CUNG CẤP";
            worksheet.Cells[5, 2] = "Cửa hàng kinh doanh LapTop THEVAN";
            worksheet.Cells[6, 2] = "Địa chỉ: 123 Cách Bi- Quế Võ- Bắc Ninh";
            worksheet.Cells[7, 2] = "Ngày:" + System.DateTime.Now.ToString();
            worksheet.Cells[8, 1] = "STT";
            worksheet.Cells[8, 2] = "Mã NCC";
            worksheet.Cells[8, 3] = "Tên nhà cung cấp";
            worksheet.Cells[8, 4] = "Số điện thoại";
            worksheet.Cells[8, 5] = "Địa chỉ";
            for (int i = 0; i < dgvNCC.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    worksheet.Cells[i + 9, 1] = i + 1;
                    worksheet.Cells[i + 9, j + 2] = dgvNCC.Rows[i].Cells[j].Value;
                }
            }
        }

        private void BtnThoatNCC_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNCC.CurrentRow.Index;
            txtMaNCC.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
            txtSDTNCC.Text = dgvNCC.Rows[i].Cells[2].Value.ToString();
            txtDiaChiNCC.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();
        }

        private void TxtSDTNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
