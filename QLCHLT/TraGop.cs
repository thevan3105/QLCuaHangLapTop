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
    public partial class TraGop : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public TraGop()
        {
            InitializeComponent();
            loadPhieuTG();
            loadBLNgay();
            loadBL();
        }
        void loadPhieuTG()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from TraGop", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvPhieuTG.DataSource = dt;
            conn.Close();
        }
        void loadcbMaKH()
        {
            conn.Open();
            var cmd = new SqlCommand("select MaKH from KhachHang", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.DataSource = dt;
            conn.Close();
        }
        void loadcbMaHD()
        {
            conn.Open();
            var cmd = new SqlCommand("select MaHD from HoaDon", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaHD.DisplayMember = "MaHD";
            cbMaHD.DataSource = dt;
            conn.Close();
        }
        void loadcbMaNV()
        {
            conn.Open();
            var cmd = new SqlCommand("select MaNV from NhanVien", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.DataSource = dt;
            conn.Close();
        }

        private void TraGop_Load(object sender, EventArgs e)
        {
            dtpNgayLap.CustomFormat = "yyyy-MM-dd";
            dtpHanTra.CustomFormat = "yyyy-MM-dd";
            dtpNgayLapBL.CustomFormat = "yyyy-MM-dd";
            dtpNgay.CustomFormat = "dd";
        }

        private void RibbonTabItem2_Click(object sender, EventArgs e)
        {

        }

        private void BtnThoatBH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnTaoPTG_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text.Length == 0 || cbMaHD.Text.Length == 0 || cbMaKH.Text.Length == 0 || cbDichVu.Text.Length == 0 || cbMaNV.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            try
            {
                conn.Open();
                string Query = $"INSERT INTO TraGop VALUES('{txtMaTG.Text}','{cbMaHD.Text}', '{cbMaKH.Text}', '{txtCMT.Text}','{cbMaNV.Text}'," +
                               $"'{cbDichVu.Text}','{dtpNgayLap.Text}', '{txtTraTruoc.Text}', '{dtpHanTra.Text}','{txtLaiXuat.Text}')";
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

        private void BtnHuyPTG_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = $"DELETE TraGop WHERE MaTG ='{txtMaTG.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Đã xóa!");
                loadPhieuTG();
            }
            catch
            {
                MessageBox.Show("Thất bại!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnInPTG_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nút này vô dụng");
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "PHIẾU TRẢ GÓP";
            //printer.SubTitle = "Tên khách hàng" + txtTenKH.Text + "\r\n" + "Địa chỉ:" + txtDiaCHiKH.Text + "\r\n" + "Ngày bán:" + dtpNgayBan.Text + "\r\n" + "Tổng tiền:" + txtTongTien.Text + "\r\n";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Cửa hàng laptop ABC";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvPhieuTG);
        }

        private void CbMaKH_DropDown(object sender, EventArgs e)
        {
            loadcbMaKH();
        }

        private void CbMaHD_DropDown(object sender, EventArgs e)
        {
            loadcbMaHD();
        }

        private void CbMaNV_DropDown(object sender, EventArgs e)
        {
            loadcbMaNV();
        }

        private void TxtTraTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void TxtCMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void BtnThoatBL_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo🤔!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        void loadcbMaNVTG()
        {
            conn.Open();
            var cmd = new SqlCommand("select MaNV from NhanVien", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaNVBL.DisplayMember = "MaNV";
            cbMaNVBL.DataSource = dt;
            conn.Close();
        }
        private void CbMaNVBL_DropDown(object sender, EventArgs e)
        {
            loadcbMaNVTG();
        }
        void loadcbMaTG()
        {
            conn.Open();
            var cmd = new SqlCommand("select MaTG from TraGop", conn);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbMaTG.DisplayMember = "MaTG";
            cbMaTG.DataSource = dt;
            conn.Close();
        }
        private void CbMaTG_DropDown(object sender, EventArgs e)
        {
            loadcbMaTG();
        }

        private void TxtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
        void loadBLNgay()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from TraGop where NgayLap like '%' +'{dtpNgay.Value.ToString("dd")}'+ '%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvBLNgay.DataSource = dt;
            conn.Close();
        }
        void loadBL()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from BienLaiTG", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvBienLai.DataSource = dt;
            conn.Close();
        }

        private void BtnTaoPN_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = $"INSERT INTO BienLaiTG VALUES('{txtMaBL.Text}','{cbMaNVBL.Text}', '{dtpNgayLapBL.Text}', '{cbMaTG.Text}','{txtSoTien.Text}','{txtGhiChu.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo thành công!");
                cmd.Dispose();
                loadBL();
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

        private void BtnHuyPN_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = $"DELETE BienLaiTG WHERE MaBienLai ='{txtMaBL.Text}')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Đã xóa!");
                loadBL();
            }
            catch
            {
                MessageBox.Show("Thất bại!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInPN_Click(object sender, EventArgs e)
        {

        }
    }
}
