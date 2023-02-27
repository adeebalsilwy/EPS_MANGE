using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPS.PL;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;
using EPS.Page;
using System.Data.Entity.Migrations;
using System.IO;
using FireSharp.Interfaces;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using System.Threading.Tasks;
using EPS.BL;
using System.Diagnostics;
using System.Net.Mail;
using DeviceId;
/// <summary>
/// هذه السنخة مرخصة ومفتوحة المصدر من قبل قناة تكنو يو على يوتيوب
/// المطور صفاء جاسم 
/// </summary>
namespace EPS
{
    public partial class FRM_Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        bool PageStageClose;
        XtraTabPage XtraPage;
        DBEPSEntities db;

        DeviceIdBuilder DEVIECE = new DeviceIdBuilder();
        string mac_address = "";
        string tempkey = "";
        private string key;
        private string full_key = "";
        string address_test;
        public int day = 0;
        bool is_active;
        DateTime curent_date;
        public FRM_Main()
        {
            InitializeComponent();
            LoadHomePage();
           // AddAppData();
            anacalis();
            cheak_active();

        }


        void anacalis()
        {
            mac_address = DEVIECE.AddMacAddress(excludeWireless: true).ToString();
            string a = mac_address.Substring(0, 5);
            tempkey = mac_address.Substring(0, 5) + mac_address.Substring(10, 5);

            address_test = new string(mac_address.Where(char.IsDigit).ToArray());
            string tt = address_test.Substring(0, 5);
            int temp = Convert.ToInt32(tt) + 1697402;

            key = temp.ToString();
            // lbl_key.Visible = true;
            full_key = "deebo" + key + "1697402";

            // label4.Text = key.ToString();


        }

        private void cheak_active()
        {
            try
            {
                DBEPSEntities db = new DBEPSEntities();
                var rs1 = db.TBL_ACTIVE.Find(address_test);
                if (rs1 == null)
                {
                    TBL_ACTIVE tbl = new TBL_ACTIVE();
                    tbl.ADD_DATE = DateTime.Now;
                    tbl.MAC_ADDRESS = address_test.ToString();
                    tbl.IS_ACTIVE = false;

                    db.TBL_ACTIVE.AddOrUpdate(tbl);
                    db.SaveChanges();
                    ;

                }
                else
                {
                    TimeSpan timeSpan = DateTime.Now - rs1.ADD_DATE.Value;
                    day = Convert.ToInt32(timeSpan.TotalDays);

                    // MessageBox.Show("عدد  الايام     " + day.ToString());
                    if (rs1.IS_ACTIVE == false && day > 30)
                    {

                        //   TimeSpan timeSpan = DateTime.Now - rs1.ADD_DATE.Value;
                        day = Convert.ToInt32(timeSpan.TotalDays);
                        FRM_A fRM_ = new FRM_A();
                        fRM_.Show();

                    }
                    else if (rs1.IS_ACTIVE ==true)
                    {
                        this.Text = "EPS  تم تفعيل   ";
                    }
                    else 
                    {
                        this.Text = "EPS " + (30 - day + 1) + " يوم متبقي   ";
                      
                    }
                    
                       
                    




                }
                privl();
            }
            catch
            {

            }
        }


        private  void AddAppData()
        {
            try
            {
                db = new DBEPSEntities();
                TB_ABC aBC1 = new TB_ABC();
                aBC1 = db.TB_ABC.First();
                if (aBC1==null)
                {

                  

                }
                else
                {
                    db = new DBEPSEntities();
                    var aBC = db.TB_ABC.First();
                    var bytedate = db.TB_ABC.Select(x => x.C).FirstOrDefault();
                    var strdate = Encoding.ASCII.GetString(bytedate);
                    var date = Convert.ToDateTime(strdate);
                    this.Text ="EPS "+ (date-DateTime.Now).Days.ToString()+ " يوم متبقي   ";
                    if (date < DateTime.Now && aBC.A==null)
                    {
                        this.Enabled = false;
                        FRM_A fRM_A = new FRM_A();
                        fRM_A.Show();
                    }
                    else if(aBC.A!=null)
                    {
                        this.Text = "EPS Pro    ";

                    }


                }
               

            }
            catch(Exception ex) 
            {

              

                db = new DBEPSEntities();
                    TB_ABC aBC = new TB_ABC();

                    aBC.C = Encoding.ASCII.GetBytes(DateTime.Now.AddDays(31).ToString());
                    db.TB_ABC.Add(aBC);
                    db.SaveChanges();
               

                db = new DBEPSEntities();
                    var bytedate = db.TB_ABC.Select(x => x.C).FirstOrDefault();
                    var strdate = Encoding.ASCII.GetString(bytedate);
                    var date = Convert.ToDateTime(strdate);
                    this.Text = "EPS " + (date - DateTime.Now).Days.ToString() + " يوم متبقي   ";
                    if (date < DateTime.Now && aBC.A == null)
                    {
                        this.Enabled = false;
                        FRM_A fRM_A = new FRM_A();
                        fRM_A.Show();
                    }
                    else if (aBC.A != null)
                    {
                        this.Text = "EPS Pro    ";

                    }


                }

            privl();
        }

      


        
        // Event for Load Page
        private void btn_home_Click(object sender, EventArgs e)
        {

            LoadHomePage();
            privl();
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            GroupsPage page = new GroupsPage();
            SelectPage(page, "المجموعات");



        }

        private void SelectPage(DevExpress.XtraEditors.XtraUserControl control, string PageTitle)
        {
            try
            {
                foreach (XtraTabPage pageindex in xtraTabControl1.TabPages)
                {
                    if (pageindex.Text == PageTitle)
                    {
                        PageStageClose = false;
                        XtraPage = pageindex;
                        break;

                    }
                    else
                    {
                        PageStageClose = true;
                    }
                }
                if (PageStageClose == true)
                {
                    control.Dock = DockStyle.Fill;
                    xtraTabControl1.TabPages.Add();
                    var CurrentPage = xtraTabControl1.TabPages.Last();
                    xtraTabControl1.SelectedTabPage = CurrentPage;
                    CurrentPage.Text = PageTitle;
                    CurrentPage.Controls.Add(control);
                }
                else
                {
                    xtraTabControl1.SelectedTabPage = XtraPage;
                }
            }
            catch { }
           
        }

        private void LoadHomePage()
        {
            

            try
            {
                HomePage page = new HomePage();
                page.Dock = DockStyle.Fill;
                xtrahomepage.Controls.Clear();
                xtrahomepage.Controls.Add(page);
                xtraTabControl1.SelectedTabPage = xtraTabControl1.TabPages.First();
            }
            catch { }
            if (txt_role.Caption == "مستخدم مبيعات ")
            {
                btn_anylsis.Enabled = false;
                btn_settings.Enabled = false;
            }

        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            var xtrapage = arg.Page as XtraTabPage;
            xtraTabControl1.TabPages.Remove(xtrapage);
        }
        void privl()
        {
            if (txt_role.Caption == "مستخدم مبيعات ")
            {
                btn_anylsis.Enabled = false;
                btn_settings.Enabled = false;
                btn_reports.Enabled = false;
                btn_suppliers.Enabled = false;
                btn_users.Enabled = false;
                btn_note.Enabled = false;
                btn_customers.Enabled = false;
                btn_buy.Enabled = false;
                
            }

            else if (txt_role.Caption == "مستخدم مشتريات ")
            {
                btn_anylsis.Enabled = false;
                btn_settings.Enabled = false;
                btn_reports.Enabled = false;
                btn_suppliers.Enabled = false;
                btn_users.Enabled = false;
                btn_note.Enabled = false;
                btn_customers.Enabled = false;
                btn_buy.Enabled = false;
                btn_sell.Enabled = false;
                btn_active.Enabled = false;
            }
            else if (txt_role.Caption == "مدير")
            {
                btn_anylsis.Enabled = true;
                btn_settings.Enabled = true;
                btn_reports.Enabled = true;
                btn_suppliers.Enabled = true;
                btn_users.Enabled = true;
                btn_note.Enabled = true;
                btn_customers.Enabled = true;
                btn_buy.Enabled = true;
                btn_sell.Enabled = true;
                btn_active.Enabled = true;
            }
            else if (txt_role.Caption == "محاسب")
            {
                btn_anylsis.Enabled = false;
                btn_settings.Enabled = false;
                btn_reports.Enabled = false;
                btn_suppliers.Enabled = true;
                btn_users.Enabled = false;
                btn_note.Enabled = false;
                btn_customers.Enabled = true;
                btn_buy.Enabled = true;
                btn_sell.Enabled = true;
                btn_active.Enabled = false;
            }



        }
        private  void FRM_Main_Load(object sender, EventArgs e)
        {
            // init
            privl();
            Properties.Settings.Default.UserFullName = txt_username.Caption;
            Properties.Settings.Default.Save();
            GetNoteNumber();




        }

        private void btn_note_ItemClick(object sender, ItemClickEventArgs e)
        {
            Page.Notifications note= new Page.Notifications();
            note.Dock = DockStyle.Fill;
            pn_notification.Controls.Clear();
            pn_notification.Controls.Add(note);
            if (pn_notification.Visible == true)
            {
                transitionManager1.StartTransition(pn_notification);
                pn_notification.Visible = false;
                transitionManager1.EndTransition();

            }
            else
            {
                transitionManager1.StartTransition(pn_notification);
                pn_notification.Visible = true;
                transitionManager1.EndTransition();

            }
            GetNoteNumber();
        }

        public void GetNoteNumber()
        {
            try
            {
                db = new DBEPSEntities();
                var list = db.TB_Note.ToList();
                if (list.Count == 0)
                {
                    txt_notnumber.Caption = "";
                }
                else
                {
                    txt_notnumber.Caption = list.Count.ToString();
                    btn_note.Caption = list.Count.ToString();
                }


            }
            catch { }
        }

        private void FRM_Main_Activated(object sender, EventArgs e)
        {
            GetNoteNumber();
            privl();
            BL.UpdateData updateData = new UpdateData();
            updateData.UpdateSuppliersData();
            updateData.UpdateCustomerData();
            updateData.UpdatePaymentssData();
        }

        public void CloseNotification()
        {
            transitionManager1.StartTransition(pn_notification);
            pn_notification.Visible = false;
            transitionManager1.EndTransition();
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            CategoriesPage page = new CategoriesPage();
            SelectPage(page, "الاصناف");
        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            SuppliersPage page = new SuppliersPage();
            SelectPage(page, "الموردين");
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            BuyPage page = new BuyPage();
            SelectPage(page, "المشتريات");
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            CustomersPage page = new CustomersPage();
            SelectPage(page, "العملاء");
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            SellPage page = new SellPage();
            SelectPage(page, "المبيعات");
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            FRM_Settings settings = new FRM_Settings();
            settings.Show();
        }

        private void btn_anylsis_Click(object sender, EventArgs e)
        {
            AnalyticsPage analyticsPage = new AnalyticsPage();
            SelectPage(analyticsPage, "التحليل");
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            UsersPage page = new UsersPage();
            SelectPage(page, "المستخدمين");
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            Roports page = new Roports();
            SelectPage(page, "التقارير");
        }

        private void FRM_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_ItemClick(object sender, ItemClickEventArgs e)
        { 
            // 
            AddPage.User_Login login = new AddPage.User_Login();
            login.Show();
            Hide();



        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            BL.FRM_About fRM_About = new BL.FRM_About();
            fRM_About.Show();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
           // Process.Start("https://www.youtube.com/playlist?list=PLhiFu-f80eo_5_CXiXdjBeI0M7-p7Ga7h");
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            FRM_A fRM_A = new FRM_A();
            fRM_A.Show();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            FRM_FeedBack fRM_FeedBack = new FRM_FeedBack();
            fRM_FeedBack.Show();
        }

        private void xtrahomepage_Paint(object sender, PaintEventArgs e)
        {

        }
    }


    class DataDoneTril
    {
        public string UserName { get; set; }
        public string Date { get; set; }
    }
}
