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
    public partial class ThongKe : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLCHLapTop;Integrated Security=True");
        public ThongKe()
        {
            InitializeComponent();
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadHB()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from HoaDon where NgayBan between '{dtpStart.Value.ToString("yyyy/MM/dd")}' and '{dtpEnd.Value.ToString("yyyy/MM/dd")}'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvHB.DataSource = dt;
            conn.Close();
        }
        void loadHN()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand($"select * from PhieuNhap where NgayNhap between '{dtpStart.Value.ToString("yyyy/MM/dd")}' and '{dtpEnd.Value.ToString("yyyy/MM/dd")}'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvHN.DataSource = dt;
            conn.Close();
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            loadHB();
            loadHN();
            tinhtongban();
            tinhtongnhap();
            loadDoanhThu();
            loadBieuDo();
        }
        public void tinhtongban()
        {
            int sp = dgvHB.Rows.Count;
            //sp = sp - 1;
            lbTongBan.Text = sp.ToString();
        }
        public void tinhtongnhap()
        {
            int sp = dgvHN.Rows.Count;
            //sp = sp - 1;
            lbTongNhap.Text = sp.ToString();
        }
        void loadDoanhThu()
        {
            int tien = 0;
            for (int i = 0; i < dgvHB.Rows.Count; ++i)
            {
                tien += Convert.ToInt32(dgvHB.Rows[i].Cells[4].Value);
            }
            lbDoanhThu.Text = tien.ToString();
        }
        void loadBieuDo()
        {
            chThongKe.Series["Tổng nhập"].Points.AddXY("", lbTongNhap.Text);
            chThongKe.Series["Tổng bán"].Points.AddXY("", lbTongBan.Text);
            chThongKe.DataBind();
        }

        private void BtnXuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            worksheet.Cells[1, 3] = "BẢNG THỐNG KÊ";
            worksheet.Cells[5, 2] = "Ngày bán đầu:   " + dtpStart.Text;
            worksheet.Cells[6, 2] = "Ngày kết thúc:   " + dtpEnd.Text;
            worksheet.Cells[7, 1] = "STT";
            worksheet.Cells[7, 2] = "Mã PN";
            worksheet.Cells[7, 3] = "Ngày nhâp";
            worksheet.Cells[7, 4] = "Mã NCC";
            //
            worksheet.Cells[7, 6] = "STT";
            worksheet.Cells[7, 7] = "Mã HD";
            worksheet.Cells[7, 8] = "Ngày bán";
            worksheet.Cells[7, 9] = "Mã KH";
            worksheet.Cells[7, 10] = "Mã NV";
            worksheet.Cells[7, 11] = "Tổng tiền";

            for (int i = 0; i < dgvHN.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    worksheet.Cells[i + 8, 1] = i + 1;
                    worksheet.Cells[i + 8, j + 2] = dgvHN.Rows[i].Cells[j].Value;
                }
            }

            for (int k = 0; k < dgvHB.Rows.Count - 1; k++)
            {
                for (int l = 0; l < 6; l++)
                {
                    worksheet.Cells[k + 8, 1] = k + 1;
                    worksheet.Cells[k + 8, l + 2] = dgvHB.Rows[k].Cells[l].Value;
                }
            }
        }
    }
}
