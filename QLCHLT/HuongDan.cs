using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHLT
{
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnCaiDat_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucCaiDat.Ins))
            {
                panel2.Controls.Add(ucCaiDat.Ins);
                ucCaiDat.Ins.Dock = DockStyle.Fill;
                ucCaiDat.Ins.BringToFront();
            }
            else
            {
                ucCaiDat.Ins.BringToFront();
            }
        }

        private void BtnHuongDan_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucHuongDan.Ins))
            {
                panel2.Controls.Add(ucHuongDan.Ins);
                ucHuongDan.Ins.Dock = DockStyle.Fill;
                ucHuongDan.Ins.BringToFront();
            }
            else
            {
                ucHuongDan.Ins.BringToFront();
            }
        }

        private void BtnLuuY_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucLuuY.Ins))
            {
                panel2.Controls.Add(ucLuuY.Ins);
                ucLuuY.Ins.Dock = DockStyle.Fill;
                ucLuuY.Ins.BringToFront();
            }
            else
            {
                ucLuuY.Ins.BringToFront();
            }
        }
    }
}
