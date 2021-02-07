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
    public partial class TimKiem : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public TimKiem()
        {
            InitializeComponent();
            loadcbMaKH();
            loadcbMaKH1();
            loadcbMaKH2();
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
        void loadcbMaKH1()
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
                    cbMaKH1.Items.Add(sname);
                }
            }
            catch
            {
                MessageBox.Show("⚠kết nốt thất bại!");
            }
            conn.Close();
        }
        void loadcbMaKH2()
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
                    cbMaKH2.Items.Add(sname);
                }
            }
            catch
            {
                MessageBox.Show("⚠kết nốt thất bại!");
            }
            conn.Close();
        }

        private void BtnTKNH_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from PhieuNhap where NgayNhap like '%' +'{dtpNgayNhap.Value.ToString("dd")}'+ '%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvHN.DataSource = dt;
            conn.Close();
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

        private void BtnTKHD1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from HoaDon where MaKH like '%' +'{cbMaKH.Text}'+ '%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvHD.DataSource = dt;
            conn.Close();
        }

        private void BtnTKHD2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from HoaDon where NgayBan like '%' +'{dtpNgayBan.Value.ToString("dd")}'+ '%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvHD.DataSource = dt;
            conn.Close();
        }

        private void CbMaKH1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string all = "select * from KhachHang where MaKH = '" + cbMaKH1.Text + "';";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string ten = myReader.GetString(1);
                    txtTenKH1.Text = ten;
                }
            }
            catch
            {
                MessageBox.Show("⚠Không thể hiển thị thông tin!");
            }
            conn.Close();
        }

        private void BtnTKBH1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from PhieuBH where MaKH like '%' +'{cbMaKH1.Text}'+ '%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvBH.DataSource = dt;
            conn.Close();
        }

        private void CbMaKH2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string all = "select * from KhachHang where MaKH = '" + cbMaKH2.Text + "';";
            SqlCommand cmd = new SqlCommand(all, conn);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string ten = myReader.GetString(1);
                    txtTenKH2.Text = ten;
                }
            }
            catch
            {
                MessageBox.Show("⚠Không thể hiển thị thông tin!");
            }
            conn.Close();
        }

        private void BtnTKBH2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from PhieuBH where NgayLap like '%' +'{dtpNgayLap.Value.ToString("dd")}'+ '%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvBH.DataSource = dt;
            conn.Close();
        }

        private void BtnTKTG_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from TraGop where MaKH like '%' +'{cbMaKH2.Text}'+ '%'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvTG.DataSource = dt;
            conn.Close();
        }
    }
}
