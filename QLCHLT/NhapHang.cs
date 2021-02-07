using DGVPrinterHelper;
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
    public partial class NhapHang : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public NhapHang()
        {
            InitializeComponent();
            loadcbMaNCC();
            loadcbMaMay();
        }
        void loadcbMaNCC()
        {
            conn.Open();
            string all = "select * from NhaCC";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0);
                    cbMaNCC.Items.Add(sname);
                }
            }
            catch
            {
                MessageBox.Show("⚠kết nốt thất bại!");
            }
            conn.Close();
        }
        void loadcbMaMay()
        {
            conn.Open();
            string all = "select * from LapTop";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0);
                    cbMaMay.Items.Add(sname);
                }
            }
            catch
            {
                MessageBox.Show("⚠kết nốt thất bại!");
            }
            conn.Close();
        }

        private void CbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string all = "select * from NhaCC where MaNCC = '" + cbMaNCC.Text + "';";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string ten = myReader.GetString(1);
                    txtTenNCC.Text = ten;
                }
            }
            catch
            {
                MessageBox.Show("⚠Không thể hiển thị thông tin!");
            }
            conn.Close();
        }

        private void CbMaMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string all = "select * from LapTop where MaMay = '" + cbMaMay.Text + "';";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string tenmay = myReader.GetString(1);
                    string gia = myReader.GetInt32(2).ToString();
                    txtTenMay.Text = tenmay;
                    txtGiaNhap.Text = gia;
                }
            }
            catch
            {
                MessageBox.Show("⚠Không thể hiển thị thông tin!");
            }
            conn.Close();
        }

        private void TxtTenMay_TextChanged(object sender, EventArgs e)
        {
            txtSLMay.Enabled = true;
            txtSLMay.Text = "1";
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnTaoPN_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Length == 0 || cbMaNCC.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Query = $"INSERT INTO PhieuNhap VALUES(N'{txtMaPN.Text}','{dtpNgayNhap.Text}', '{cbMaNCC.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo thành công!");
                cmd.Dispose();
            }
            catch
            {
                MessageBox.Show("Tạo thất bại!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnLuuPN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thêm!", "Xác nhận🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = $"INSERT INTO CTPhieuNhap VALUES('{txtMaPN.Text}','{cbMaMay.Text}', '{txtTenMay.Text}', '{txtSLMay.Text}')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    //cmd.Dispose();
                    conn.Close();
                    loadDaTa();
                    updateData();
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại!");
                    conn.Close();
                }
                //finally
                //{
                //    conn.Close();
                //}
            }
        }
        void loadDaTa()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from CTPhieuNhap where MaPN like '{txtMaPN.Text}'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvNhapHang.DataSource = dt;
            conn.Close();
        }

        private void BtnHuyPN_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy, Thao tác sẽ không thể khôi phục!", "Cảnh báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = $"DELETE CTPhieuNhap WHERE MaPN ='{txtMaPN.Text}'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hủy thành công!");
                    cmd.Dispose();
                    loadDaTa();
                    deletePN();
                }
                catch
                {
                    MessageBox.Show("Hủy thất bại!");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void BtnInPN_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nút này tạm vô dụng");
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "PHIẾU NHẬP HÀNG";
            printer.SubTitle = "Mã phiếu nhập" + txtMaPN.Text + "\r\n" + "Nhà cung cấp:" + txtTenNCC.Text + "\r\n" + "Ngày nhập:" + dtpNgayNhap.Text + "\r\n";
            //printer.PrintRowHeaders = label1.Text;
            //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Cửa hàng laptop ABC";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvNhapHang);
        }
        void updateData()
        {
            try
            {
                conn.Open();
                int x = int.Parse(txtSLMay.Text);
                string update_Query = ($"update Laptop set SoLuong = (SoLuong + '{x}') where MaMay= '{cbMaMay.Text}'");
                SqlCommand cmd = new SqlCommand(update_Query, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch
            {
                MessageBox.Show("update số lượng thất bại!");
            }
            finally
            {
                conn.Close();
            }
        }
        void deletePN()
        {
            conn.Open();
            string Query = $"DELETE PhieuNhap WHERE MaPN ='{txtMaPN.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            dtpNgayNhap.CustomFormat = "yyyy-MM-dd";
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
