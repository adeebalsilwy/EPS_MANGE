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

namespace EPS
{
    public partial class FRM_FeedBack : DevExpress.XtraEditors.XtraForm
    {
        DBEPSEntities db;
        TB_ABC add;
        public FRM_FeedBack()
        {
            InitializeComponent();
        }




        private void txt_state_Click(object sender, EventArgs e)
        {


        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("قم بمليء الحقول رجاءا");
            }
            else
            {
                try
                {

                    txt_state.Text = ":) شكرا لك , تم ارسال ملاحظاتك ";




                }


                
                catch
            {
                MessageBox.Show("يبدو انك غير متصل في الشبكة , نحتاج الى توفر اتصال  في الشبكة");

            }
        
        }

    }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // Process.Start("https://forms.gle/XEAegz8knPoQmR6MA");
        }
    }

    class FeedBackData
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
    
}