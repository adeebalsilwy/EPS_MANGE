using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPS.BL
{
    public partial class Help : DevExpress.XtraEditors.XtraUserControl
    {
        public Help()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.youtube.com/playlist?list=PLhiFu-f80eo_5_CXiXdjBeI0M7-p7Ga7h");
        }
    }
}
