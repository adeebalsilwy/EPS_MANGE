using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using EPS.AddPage;
using EPS.PL;
using System.Net.Mail;
using DeviceId;
using System.Data.Entity.Migrations;

namespace EPS
{
    public partial class FRM_Start : SplashScreen
    {
        int st;

        DeviceIdBuilder DEVIECE = new DeviceIdBuilder();
        string mac_address = "";
        string tempkey = "";
        private string key;
        private string full_key = "";
        string address_test;
      public  int day=0;
        bool is_active=true;
        DateTime curent_date;
        public FRM_Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2021-" + DateTime.Now.Year.ToString();
            anacalis();
            curent_date = DateTime.Now;
           // cheak_active();
        }

        #region Overrides

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


        private async void get_data()
        {



            await Task.Run(() => Thread.Sleep(2000));

            // Check Login 

            lb_state.Text = "... الاتصال بقاعدة البيانات";
            var state = await Task.Run(() => CheckLogin());
            if (state == 1)
            {

                AddPage.User_Login _Login = new AddPage.User_Login();
                _Login.Show();
                Hide();
            }
            else if (state == 0)
            {
                Add_Users page = new Add_Users();
                UsersPage usersPage = new UsersPage();
                page.btn_add.Text = "تسجيل واعادة تشغيل";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = usersPage;
                page.btn_addclose.Visible = false;
                page.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("خطأ في الاتصال في قاعدة البيانات , يبدو ان لديك مشكلة في عملية تثبيت البرنامج ");
                Application.Exit();
            }

        }
        private void cheak_active()
        {
            try
            {
                DBEPSEntities  db = new DBEPSEntities();
                var rs1 = db.TBL_ACTIVE.Find(address_test);
                if (rs1 == null)
                {
                    TBL_ACTIVE tbl = new TBL_ACTIVE();
                    tbl.ADD_DATE = DateTime.Now;
                    tbl.MAC_ADDRESS = address_test.ToString();
                    tbl.IS_ACTIVE = false;

                    db.TBL_ACTIVE.AddOrUpdate(tbl);
                    db.SaveChanges();
                  
                 
                    MessageBox.Show("      انت تستخدم النسخه المجانيه حتى  " +curent_date.AddDays(30).ToString());
                   
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
                        fRM_.ShowDialog();
                        is_active = false;
                        Application.ExitThread();
                        Application.Exit();
                        

                    }
                    
                    
                    
                  


                }
            }
            catch
            {

            }
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }

        private async void FRM_Start_Load(object sender, EventArgs e)
        {



            // Check Login 
            lb_state.Text = "... الاتصال بقاعدة البيانات";
            await Task.Run(() => Thread.Sleep(2000));
           
           
            cheak_active();
            var state = await Task.Run(() => CheckLogin());
            if (state == 1)
            {

                AddPage.User_Login _Login = new AddPage.User_Login();
                _Login.Show();
                Hide();
            }
            else if (state == 0)
            {
                Add_Users page = new Add_Users();
                UsersPage usersPage = new UsersPage();
                page.btn_add.Text = "تسجيل واعادة تشغيل";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = usersPage;
                page.btn_addclose.Visible = false;
                page.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("خطأ في الاتصال في قاعدة البيانات , يبدو ان لديك مشكلة في عملية تثبيت البرنامج ");
                Application.Exit();
            }
        }

        private int CheckLogin()
        {
            try
            {
                DBEPSEntities db = new DBEPSEntities();

                var data = db.TB_Users.Select(x=>x.FullName).ToList();
                if (data.Count >0)
                {
                    st = 1;
                }
                else
                {
                    st = 0;
                }


            }
            catch
            {
                return 2;
            }
            return st;

        }
    }
}