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
    public partial class Close : DevExpress.XtraEditors.XtraForm
    {
        public Close()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            transitionManager1.StartTransition(panel1);
            transitionManager1.EndTransition();
        }
    }
}