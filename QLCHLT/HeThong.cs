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
    public partial class HeThong : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        string TaiKhoan = "", MatKhau = "", Quyen = "";
        public HeThong(string TaiKhoan, string MatKhau, string Quyen)
        {
            InitializeComponent();
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnLapTop_Click_1(object sender, EventArgs e)
        {
            if (Quyen == "admin"|| Quyen =="kho")
            {
                LapTop frm = new LapTop();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.Show();
            this.Close();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void BtnChangeUser_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.Show();
            this.Close();
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin"||Quyen =="user")
            {
                QLDoituong frm = new QLDoituong();
                frm.Show();
            }
            else
            {
                MessageBox.Show("ban ko dc quyen lam thao tac nay!");
            }
        }

        private void BtnHuongDan_Click(object sender, EventArgs e)
        {
            HuongDan frm = new HuongDan();
            frm.Show();
        }

        private void BtnBaoHanh_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin" || Quyen == "user")
            {
                BaoHanh frm = new BaoHanh();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }

        private void BtnPhuKien_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin" || Quyen == "kho")
            {
                PhuKien frm = new PhuKien();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }

        private void BtnNCC_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin" || Quyen == "kho")
            {
                NhaCC frm = new NhaCC();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin")
            {
                NhanVien frm = new NhanVien();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }

        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin" || Quyen == "user")
            {
                HoaDon frm = new HoaDon();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }

        private void BtnNhapHang_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin" || Quyen == "kho")
            {
                NhapHang frm = new NhapHang();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin" || Quyen == "kho")
            {
                ThongKe frm = new ThongKe();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }

        private void BtnTraGop_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin" || Quyen == "user")
            {
                TraGop frm = new TraGop();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            if (Quyen == "admin" || Quyen == "user")
            {
                TimKiem frm = new TimKiem();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện thao tác này!");
            }
        }
    }
}
