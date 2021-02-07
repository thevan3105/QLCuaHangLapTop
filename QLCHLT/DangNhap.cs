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
    public partial class DangNhap : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public DangNhap()
        {
            InitializeComponent();
        }
        void load()
        {
            txtTaiKhoan.Focus();
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtChangePW.Text = "";
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            txtChangePW.Enabled = false;
            btnDangNhap.Enabled = false;
            btnChangePW.Enabled = false;
            txtTaiKhoan.Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "")
                btnDangNhap.Enabled = true;
            else
                btnDangNhap.Enabled = false;
        }

        private void BtnDoiMK_Click(object sender, EventArgs e)
        {
            txtChangePW.Enabled = true;
        }

        private void TxtChangePW_TextChanged(object sender, EventArgs e)
        {
            if (txtChangePW.Text != "")
                btnChangePW.Enabled = true;
            else
                btnChangePW.Enabled = false;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = $"select * from ID where TaiKhoan = '{txtTaiKhoan.Text}' and MatKhau = '{txtMatKhau.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            cmd.Dispose();
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                HeThong frm = new HeThong(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][3].ToString());
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại! vui lòng đăng nhập lại⚠");
                load();
            }
        }

        private void BtnChangePW_Click(object sender, EventArgs e)
        {
            if (txtChangePW.Text == txtMatKhau.Text)
            {
                try
                {
                    conn.Open();
                    string changepw = ($"update ID set MatKhau = '{txtChangePW.Text}' where TaiKhoan= '{txtTaiKhoan.Text}'");
                    SqlCommand cmd = new SqlCommand(changepw, conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    txtMatKhau.Text = "";
                    txtChangePW.Text = "";
                    txtMatKhau.Focus();
                }
                catch
                {
                    MessageBox.Show("Đổi thất bại!");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu mới không khớp!");
            }
        }

        private void CbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void CbChangePass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChangePass.Checked)
            {
                txtChangePW.UseSystemPasswordChar = true;
            }
            else
            {
                txtChangePW.UseSystemPasswordChar = false;
            }
        }

        private void TxtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar) >= 65 && e.KeyChar <= 122 || (e.KeyChar == 8));
        }
    }
}
