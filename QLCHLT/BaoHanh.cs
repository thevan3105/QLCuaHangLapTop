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
    public partial class BaoHanh : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public BaoHanh()
        {
            InitializeComponent();
            loadcbMaKH();
            loadcbMaMay();
            loadcbMaBH();
        }
        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadcbMaKH()
        {
            conn.Open();
            string all = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0);
                    cbMaKH.Items.Add(sname);
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
        private void BaoHanh_Load(object sender, EventArgs e)
        {
            
        }

        private void CbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string all = "select * from KhachHang where MaKH = '" + cbMaKH.Text + "';";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string ten = myReader.GetString(1);
                    txtTenKH.Text = ten;
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
                    string tgBH = myReader.GetString(7);
                    txtTenMay.Text = tenmay;
                    txtTGBH.Text = tgBH;
                }
            }
            catch
            {
                MessageBox.Show("⚠Không thể hiển thị thông tin!");
            }
            conn.Close();
        }

        private void BtnTaoBH_Click(object sender, EventArgs e)
        {
            if (txtMaBH.Text.Length == 0 || cbMaKH.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            //conn.Open();
            //string da = $"Select Count(*) from PhieuBH where MaBH = '{txtMaBH.Text}'";
            //SqlCommand ds = new SqlCommand(da, conn);
            //string Soluong = ds.ExecuteScalar().ToString();

            //conn.Close();
            //if (dt.Rows.Count > 1)
            //{
            //    MessageBox.Show("Mã bảo hành đã tồn tại!");
            //}
            //else
            //{
                try
                {
                    conn.Open();
                    string Query = $"INSERT INTO PhieuBH VALUES(N'{txtMaBH.Text}','{cbMaKH.Text}', '{dtpNgayLap.Text}')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Tạo thành công!");
                }
                catch
                {
                    MessageBox.Show("Tạo thất bại!");
                }
                finally
                {
                    conn.Close();
                }
            //}
        }

        private void BtnThemSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thêm!", "Xác nhận🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = $"INSERT INTO CTPhieuBH VALUES('{txtMaBH.Text}','{cbMaMay.Text}', '{txtTenMay.Text}', '{txtTGBH.Text}')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                    //cmd.Dispose();
                    conn.Close();
                    loadDaTa();
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

        private void BtnHuyBH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy, Thao tác sẽ không thể khôi phục!", "Cảnh báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = $"DELETE CTPhieuBH WHERE MaBH ='{txtMaBH.Text}'";
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
        void loadDaTa()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from CTPhieuBH where MaBH like '{txtMaBH.Text}'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvBaoHanh.DataSource = dt;
            conn.Close();
        }
        void deletePN()
        {
            conn.Open();
            string Query = $"DELETE PhieuBH WHERE MaBH ='{txtMaBH.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnThoatBH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnThoatPTG_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaTGBH.Text = "";
            cbMaBH.Text = "";
            txtDichVu.Text = "";
            txtMaTGBH.Focus();
        }

        private void BtnTao_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = $"INSERT INTO PhieuTGBH VALUES(N'{txtMaTGBH.Text}','{cbMaBH.Text}', '{txtSoLuong.Text}', '{txtDichVu.Text}', '{dtpNgayTG.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo thành công!");
                cmd.Dispose();
                loadPhieuTG();
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

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy, Thao tác sẽ không thể khôi phục!", "Cảnh báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = $"DELETE PhieuTGBH WHERE MaTGBH ='{txtMaTGBH.Text}'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hủy thành công!");
                    cmd.Dispose();
                    loadPhieuTG();
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
        void loadPhieuTG()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from PhieuTGBH where MaTGBH = '{txtMaTGBH.Text}'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvPhieuTG.DataSource = dt;
            conn.Close();
        }
        void loadcbMaBH()
        {
            conn.Open();
            string all = "select * from PhieuBH";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0);
                    cbMaBH.Items.Add(sname);
                }
            }
            catch
            {
                MessageBox.Show("⚠kết nốt thất bại!");
            }
            conn.Close();
        }

        private void BtnInBH_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "PHIẾU BẢO HÀNH";
            printer.SubTitle = "Tên khách hàng" + txtTenKH.Text + "\r\n" + "Ngày Lập:" + dtpNgayLap.Text + "\r\n";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Cửa hàng laptop ABC";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvBaoHanh);
        }

        private void BtnINPTG_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "PHIẾU THAM GIA BẢO HÀNH";
            //printer.SubTitle = "Tên khách hàng" + txtTenKH.Text + "\r\n" + "Ngày Lập:" + dtpNgayLap.Text + "\r\n";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Cửa hàng laptop ABC";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvBaoHanh);
        }
    }
}
