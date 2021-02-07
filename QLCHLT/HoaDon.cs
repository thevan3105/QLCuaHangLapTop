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
    public partial class HoaDon : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public HoaDon()
        {
            InitializeComponent();
            loadcbMaNV();
            loadcbMaKH();
            loadcbMaMay();
            //loadcbMaPK();
        }
        public void loadcbMaNV()
        {
            conn.Open();
            string all = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString(0);
                    cbMaNV.Items.Add(sname);
                }
            }
            catch
            {
                MessageBox.Show("⚠kết nốt thất bại!");
            }
            conn.Close();
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
        //void loadcbMaPK()
        //{
        //    conn.Open();
        //    string all = "select * from PhuKien";
        //    SqlCommand cmd = new SqlCommand(all, conn);
        //    SqlDataReader myReader;
        //    try
        //    {
        //        myReader = cmd.ExecuteReader();
        //        while (myReader.Read())
        //        {
        //            string sname = myReader.GetString(0);
        //            cbMaPK.Items.Add(sname);
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("⚠kết nốt thất bại!");
        //    }
        //    conn.Close();
        //}

        private void Btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TxtKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if (Convert.ToInt32(txtKM.Text) <= 99)
            {
                e.Handled = true;
            }
            //int num = -2;
            //bool conversionSuccessful = int.TryParse(txtKM.Text, out num);
            //if (conversionSuccessful)
            //{
            //    if (num <= -1 && num >= 101)
            //    {
            //        MessageBox.Show("Vui Lòng nhập trong khoảng 0-100");
            //        return;
            //    }
            //}
        }

        private void CbMaNV_DropDown(object sender, EventArgs e)
        {

        }

        private void CbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string all = "select * from NhanVien where MaNV = '"+cbMaNV.Text+"';";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString(1);
                    txtTenNV.Text = name;
                }
            }
            catch
            {
                MessageBox.Show("⚠Không thể hiển thị thông tin!");
            }
            conn.Close();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dtpNgayBan.CustomFormat = "yyyy-MM-dd";
        }

        private void CbMaKH_DropDown(object sender, EventArgs e)
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
                    string sdt = myReader.GetInt32(2).ToString();
                    string diachi = myReader.GetString(3);
                    txtTenKH.Text = ten;
                    txtSDTKH.Text = sdt;
                    txtDiaCHiKH.Text = diachi;
                }
            }
            catch
            {
                MessageBox.Show("⚠Không thể hiển thị thông tin!");
            }
            conn.Close();
        }

        //private void CbMaPK_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    conn.Open();
        //    string all = "select * from PhuKien where MaPK = '" + cbMaPK.Text + "';";
        //    SqlCommand cmd = new SqlCommand(all, conn);
        //    SqlDataReader myReader;
        //    try
        //    {
        //        myReader = cmd.ExecuteReader();
        //        while (myReader.Read())
        //        {
        //            string tenPK = myReader.GetString(1);
        //            string gia = myReader.GetInt32(5).ToString();
        //            txtTenPK.Text = tenPK;
        //            txtDonGiaPK.Text = gia;
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("⚠Không thể hiển thị thông tin!");
        //    }
        //    conn.Close();
        //}

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
                    string gia = myReader.GetInt32(3).ToString();
                    txtTenMay.Text = tenmay;
                    txtDonGiaMay.Text = gia;
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
            loadThanhTien();
        }

        //private void TxtTenPK_TextChanged(object sender, EventArgs e)
        //{
        //    txtSLPK.Enabled = true;
        //    txtSLPK.Text = "1";
        //    loadThanhTien();
        //}

        void loadThanhTien()
        {
            int x = int.Parse(txtSLMay.Text);
            //int y = int.Parse(txtSLPK.Text);
            int y = int.Parse(txtDonGiaMay.Text);
            //int t = int.Parse(txtDonGiaPK.Text);
            int z = int.Parse(txtKM.Text);
            int tong = (x * y) - (x * y)* z/100;
            txtThanhTien.Text = tong.ToString();
        }

        private void Btnload_Click(object sender, EventArgs e)
        {
            loadThanhTien();
        }

        private void BtnTaoHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Length == 0 || cbMaNV.Text.Length == 0 || cbMaKH.Text.Length == 0)
            {
                MessageBox.Show("Vui nhập nhận đủ thông tin");
            }
            try
            {
                conn.Open();
                string Query = $"INSERT INTO HoaDon VALUES('{txtMaHD.Text}','{dtpNgayBan.Text}', '{cbMaKH.Text}', '{cbMaNV.Text}', '{txtTongTien.Text}')";
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

        private void BtnHuyHD_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy, Thao tác sẽ không thể khôi phục!", "Cảnh báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = $"DELETE CTHoaDon WHERE MaHD ='{txtMaHD.Text}'";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hủy thành công!");
                    cmd.Dispose();
                    loadDaTa();
                    deleteHD();
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

        private void BtnInHD_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("nút này tạm vô dụng");
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "HÓA ĐƠN BÁN HÀNG";
            printer.SubTitle = "Tên khách hàng" + txtTenKH.Text + "\r\n" + "Địa chỉ:" + txtDiaCHiKH.Text + "\r\n" + "Ngày bán:" + dtpNgayBan.Text + "\r\n" + "Tổng tiền:" + txtTongTien.Text + "\r\n";
            //printer.PrintRowHeaders = label1.Text;
            //printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Cửa hàng laptop ABC";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvMatHang);
        }

        private void TxtSLMay_ValueChanged(object sender, EventArgs e)
        {
            loadThanhTien();
        }

        private void TxtSLPK_ValueChanged(object sender, EventArgs e)
        {
            loadThanhTien();
        }

        private void TxtKM_ValueChanged(object sender, EventArgs e)
        {
            loadThanhTien();
        }

        private void BtnThemSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thêm!", "Xác nhận🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string Query = $"INSERT INTO CTHoaDon VALUES('{txtMaHD.Text}','{cbMaMay.Text}', '{txtTenMay.Text}', '{txtSLMay.Text}','{txtDonGiaMay.Text}','{txtKM.Text}', '{txtThanhTien.Text}')";
                    SqlCommand cmd = new SqlCommand(Query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo thành công!");
                    //cmd.Dispose();
                    conn.Close();
                    loadDaTa();
                    updateData();
                    loadTongTien();
                }
                catch
                {
                    MessageBox.Show("Tạo thất bại!");
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
            SqlCommand cmd = new SqlCommand($"select * from CTHoaDon where MaHD like '{txtMaHD.Text}'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvMatHang.DataSource = dt;
            conn.Close();
        }
        void updateData()
        {
            try
            {
                conn.Open();
                int x = int.Parse(txtSLMay.Text);
                string update_Query = ($"update Laptop set SoLuong = (SoLuong - '{x}') where MaMay= '{cbMaMay.Text}'");
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
        void deleteHD()
        {
            conn.Open();
            string Query = $"DELETE HoaDon WHERE MaHD ='{txtMaHD.Text}'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        void loadTongTien()
        {
            int tongtien = 0;
            for (int i = 0; i < dgvMatHang.Rows.Count; ++i)
            {
                tongtien += Convert.ToInt32(dgvMatHang.Rows[i].Cells[6].Value);
            }
            txtTongTien.Text = tongtien.ToString();
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
