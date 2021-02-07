using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHLT
{
    public partial class ucCaiDat : UserControl
    {
        private static ucCaiDat _ins;
        public static ucCaiDat Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new ucCaiDat();
                return _ins;
            }
        }
        public ucCaiDat()
        {
            InitializeComponent();
        }

        private void LinkNetFramework_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://www.microsoft.com/en-us/download/details.aspx?id=25150");
        }

        private void LinkSqlServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://drive.google.com/open?id=0B64LZ7smfQ7qZjkxWVlUUmR6T2c");
        }

        private void LinkRedGateSQL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://drive.google.com/open?id=0B64LZ7smfQ7qOGVxclduSDRqQ3c");
        }
    }
}
