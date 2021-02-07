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
    public partial class ucHuongDan : UserControl
    {
        private static ucHuongDan _ins;
        public static ucHuongDan Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new ucHuongDan();
                return _ins;
            }
        }
        public ucHuongDan()
        {
            InitializeComponent();
        }
    }
}
