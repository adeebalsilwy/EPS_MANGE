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
using System.IO;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp;
using System.Data.Entity.Migrations;
using System.Threading;
using System.Diagnostics;
using System.Data.Entity;

namespace EPS
{
    public partial class FRM_PamymnetsLogSuppliers : DevExpress.XtraEditors.XtraForm
    {
        DBEPSEntities db;
        TB_ABC add;
        public int id;
        public FRM_PamymnetsLogSuppliers()
        {
            InitializeComponent();
         
           
        }



        public void LoadData(int id)
        {
            
        }

        private void FRM_PamymnetsLogs_Load(object sender, EventArgs e)
        {
        }
    }
}