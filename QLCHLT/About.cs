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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LinkFB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.facebook.com/thevan.vn");
        }
    }
}
