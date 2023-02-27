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
using DeviceId;
using System.Net.Mail;

namespace EPS
{
    public partial class FRM_A : DevExpress.XtraEditors.XtraForm
    {
        DBEPSEntities db;
        TB_ABC add;
        DeviceIdBuilder DEVIECE = new DeviceIdBuilder();
        string mac_address = "";
        string tempkey = "";
        private string key;
        private string full_key = "";
        string address_test;

        public FRM_A()
        {
            InitializeComponent();
           // CheckState();
            anacalis();
            cheak_active();
        }

        void anacalis()
        {
            mac_address = DEVIECE.AddMacAddress(excludeWireless: true).ToString();
            txt_name.Text = mac_address;
            string a= mac_address.Substring(0, 5);
           tempkey = mac_address.Substring(0, 5) + mac_address.Substring(10, 5);
            label4.Text = tempkey;
            label4.Text = new string(mac_address.Where(char.IsDigit).ToArray());
            decimal test_key = decimal.Parse(label4.Text);
            address_test = label4.Text;

            string tt = label4.Text.Substring(0, 5);


            label4.Text = address_test.ToString();

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
                db = new DBEPSEntities();
                var rs1 = db.TBL_ACTIVE.Find(address_test);
                if (rs1 == null)
                {
                    txt_state.Text = "هل تمتلك مفتاح تفعيل مرخص , يمكنك التفعيل الان ";
                    pic_key.BringToFront();
                    panel2.Enabled = true;
                }
                else if(rs1.IS_ACTIVE==true)
                {

                    txt_state.Text = "البرنامج مفعل ";
                    pic_done.BringToFront();
                    txt_seryal.Text = rs1.ACTIVE_KEY.ToString();
                  //  txt_name.Text = Encoding.ASCII.GetString(byte.Parse(.Select(w => w.ACTIVE_KEY).ToArray());
                    panel2.Enabled = false;


                }
                else
                {
                    txt_state.Text = "هل تمتلك مفتاح تفعيل مرخص , يمكنك التفعيل الان ";
                    pic_key.BringToFront();
                    panel2.Enabled = true;
                }
            }
            catch
            {

            }
        }
        //private void CheckState()
        //{
        //    try
        //    {
        //        db = new DBEPSEntities();
        //        var rs1 = db.TB_ABC.Select(X => X.A).First();
        //        var rs2 = db.TB_ABC.Select(X => X.B).First();
        //        if (rs1==null)
        //        {
        //            txt_state.Text = "هل تمتلك مفتاح تفعيل مرخص , يمكنك التفعيل الان ";
        //            pic_key.BringToFront();
        //            panel2.Enabled = true;
        //        }
        //        else
        //        {
                   
        //            txt_state.Text = "البرنامج مفعل ";
        //            pic_done.BringToFront();
        //            txt_name.Text = Encoding.ASCII.GetString(rs1);
        //            txt_seryal.Text = Encoding.ASCII.GetString(rs2);
        //            panel2.Enabled = false;


        //        }
        //    }
        //    catch
        //    {

        //    }
        //}

        private void txt_state_Click(object sender, EventArgs e)
        {
           

        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_name.Text=="" || txt_seryal.Text == "")
            {
                MessageBox.Show("قم بمليء الحقول رجاءا");
            }
            else
            {
                try
                {
                    

                     
                        //FirebaseResponse response = await client.GetAsync($"liclist/{txt_name.Text}");
                       // var key = "deebo_774577134_735880401";
                        if (key==txt_seryal.Text)
                        {
                        txt_state.Text = " ...يتم تفعيل المنتج الان ";
                        await Task.Run(() => Thread.Sleep(2000));
                       // await Task.Run(() => Done());


                        DBEPSEntities db = new DBEPSEntities();
                        TBL_ACTIVE tbl =db.TBL_ACTIVE.Find(address_test);
                       tbl.ADD_DATE = tbl.ADD_DATE;
                        tbl.MAC_ADDRESS = address_test.ToString();
                        tbl.ACTIVE_KEY = key.ToString();
                        tbl.ACTIVE_DATE = DateTime.Now;
                        tbl.IS_ACTIVE = true;

                        db.TBL_ACTIVE.AddOrUpdate(tbl);
                        db.SaveChanges();

                        //db = new DBEPSEntities();
                        //add = db.TB_ABC.First();
                        //add.ID = add.ID;
                        //add.A = Encoding.ASCII.GetBytes(txt_name.Text);
                        //add.B = Encoding.ASCII.GetBytes(txt_seryal.Text);
                        //db.Set<TB_ABC>().AddOrUpdate(add);
                        //db.SaveChanges();
                        //  CheckState();
                        cheak_active();
                            MessageBox.Show("تهانينا :) تم تفعيل البرنامج بنجاح , سيتم اعادة تشغيل البرنامج لضبط كافة الاعدادات");
                            Application.Restart();
                        }
                        else
                        {
                            cheak_active();
                            // CheckState();
                            txt_state.Text = "خطأ مفتاح المنتج غير صالح ";


                        }

                    }
                   


                
                catch(Exception ex)
                {

                    MessageBox.Show(ex.Message);
                  //  MessageBox.Show("يبدو انك غير متصل في الشبكة , عملية التفعيل تحتاج الى توفر الاتصال في الشبكة");

                }
            }
         
        }


        
     private async void Done()
        {

          
            //  IFirebaseConfig config = new FirebaseConfig
            //  {
            //      AuthSecret = "enter auth secret",
            //      BasePath = "enter path"
            //  };
            ////  IFirebaseClient client = new FirebaseClient(config);

            //  var Date = new DataDone
            //  {
            //      UserName = txt_name.Text,
            //      Code=txt_seryal.Text

            //  };
            // FirebaseResponse response = await client.PushAsync("liclistActive", Date);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("enter url here");
        }

        private void FRM_A_Load(object sender, EventArgs e)
        {

        }
    }

    class DataDone
    {
        public string UserName { get; set; }
        public string Code { get; set; }
    }
    
}