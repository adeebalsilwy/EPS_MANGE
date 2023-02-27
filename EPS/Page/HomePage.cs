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
using System.Data.Entity;
using EPS.AddPage;
using DevExpress.XtraBars.Docking2010;
using System.IO;

namespace EPS.PL
{
    public partial class HomePage : DevExpress.XtraEditors.XtraUserControl
    {
        
        public HomePage()
        {
            InitializeComponent();
            
           
            }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_time.Text = DateTime.Now.ToString();
        }

        private void btn_add_Click(object sender, ButtonEventArgs e)
        {



           
                if (e.Button==btn_add.Buttons[0])
                {
                try
                {
                    GroupsPage groupsPage = new GroupsPage();
                    Add_Groups page = new Add_Groups();
                    page.btn_add.Text = "اضافة";
                    page.btn_addclose.Text = "اضافة + غلق";
                    page.edt_name.Text = "";
                    page.id = 0;
                    page.page = groupsPage;
                    page.Show();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }

            }
            else if(e.Button == btn_add.Buttons[2])
            {
                try
                {
                    CategoriesPage categories = new CategoriesPage();

                    Add_Categories page = new Add_Categories();
                    page.btn_add.Text = "اضافة";
                    page.btn_addclose.Text = "اضافة + غلق";
                    page.edt_name.Text = "";
                    page.id = 0;
                    page.page = categories;
                    page.Show();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }
            }
            else if (e.Button == btn_add.Buttons[4])
            {
                try
                {
                    BuyPage buyPage = new BuyPage();
                    Add_Buy page = new Add_Buy();
                    page.btn_add.Text = "اضافة";
                    page.btn_addclose.Text = "اضافة + غلق";
                    page.edt_name.Text = "";
                    page.id = 0;
                    page.page = buyPage;
                    page.Show();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }
            }
            else if (e.Button == btn_add.Buttons[6])
            {
                try
                {
                    SellPage sellPage = new SellPage();
                    Add_Sell page = new Add_Sell();
                    page.btn_add.Text = "اضافة";
                    page.edt_name.Text = "";
                    page.page = sellPage;
                    page.Show();
                    page.id = 0;
                    page.ISNew = true;
                    page.NewSellAction = true;

                }
                catch { MessageBox.Show("خطأ غير متوقع"); }
            }
            else if (e.Button == btn_add.Buttons[8])
            {
                try
                {
                    CustomersPage customers = new CustomersPage();
                    Add_Customers page = new Add_Customers();
                    page.btn_add.Text = "اضافة";
                    page.btn_addclose.Text = "اضافة + غلق";
                    page.edt_name.Text = "";
                    page.id = 0;
                    page.page = customers;
                    page.Show();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }
            }
            else if (e.Button == btn_add.Buttons[10])
            {
                try
                {
                    SuppliersPage suppliersPage = new SuppliersPage();
                    Add_Suppliers page = new Add_Suppliers();
                    page.btn_add.Text = "اضافة";
                    page.btn_addclose.Text = "اضافة + غلق";
                    page.edt_name.Text = "";
                    page.id = 0;
                    page.page = suppliersPage;
                    page.Show();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void SetCompanyinfo()
        {
            try
            {
                byte[] imgebyte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);

                if (imgebyte != null)
                {
                    MemoryStream ma = new MemoryStream(imgebyte);

                    pictureBox1.Image = Image.FromStream(ma);
                }
                label1.Text = Properties.Settings.Default.CompanyName;
            }
            catch { }
           



        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            SetCompanyinfo();
        }

        private void txt_time_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
