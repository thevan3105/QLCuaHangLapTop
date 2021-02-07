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
    public partial class ucLuuY : UserControl
    {
        private static ucLuuY _ins;
        public static ucLuuY Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new ucLuuY();
                return _ins;
            }
        }
        public ucLuuY()
        {
            InitializeComponent();
        }
    }
}
