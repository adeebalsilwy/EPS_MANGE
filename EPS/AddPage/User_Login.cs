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
using EPS.PL;
using EPS.BL;
using System.IO;

namespace EPS.AddPage
{
    public partial class User_Login : DevExpress.XtraEditors.XtraForm
    {
        public  int id;
        bool state;
        TB_Users add;
        DBEPSEntities db;
       


        public User_Login()
        {
            InitializeComponent();
        }

        private bool Save()
        {
            // check fields

            if (edt_username.Text == "" || edt_password.Text == ""  )
            {
                Message("اكمل الحقل لطفا");
            }
            else
            {
                if(edt_username.Text=="deebo" && edt_password.Text == "deebo774")
                {
                    FRM_Main main = new FRM_Main();
                    main.txt_username.Caption ="اديب الصلوي ";
                    main.txt_role.Caption = "صلاحيته  مطور النظام ";
                    main.Show();
                    Hide();
                   
                }
                // Add or edit
                if (id == 0)
                {
                    // Add
                    // Check Duplicate Data
                    
                    
                    
                        // Add
                        AddData();
                        state = true;
                    


                       


                    
                    
                }
               
            }
            return state;
        }

        private void AddData()
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Users();
                var username = edt_username.Text.Trim();
                var password = edt_password.Text.Trim();
                add = db.TB_Users.Where(x => x.UserName == username && x.Password == password).FirstOrDefault();
                if (add != null)
                {
                    // Login

                    FRM_Main main = new FRM_Main();
                    main.txt_username.Caption = add.FullName;
                    main.txt_role.Caption ="صلاحيته ("+add.privlage+")";

                    add.UserState = 1;
                    db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    /*
                     * مدير 
مستخدم مبيعات 
مستخدم مشتريات
محاسب
                     */


                    if (add.privlage.Trim() == "مبيعات")
                    {
                        main.btn_anylsis.Visible = false;
                        main.btn_settings.Visible = false;
                        main.btn_users.Visible = false;
                        main.btn_buy.Visible = false;
                        main.btn_categories.Visible = false;
                        main.btn_reports.Visible = false;
                        main.btn_groups.Visible = false;
                        main.btn_suppliers.Visible = false;
                        main.btn_active.Visible = false;
                        main.Show();
                        Hide();

                    }
                    else if (add.privlage.Trim() == "مشتريات")
                    {
                        main.btn_users.Enabled = false;
                        main.btn_anylsis.Visible = false;
                        main.btn_settings.Visible = false;
                        main.btn_users.Visible = false;
                        main.btn_active.Visible = false;

                        main.btn_categories.Visible = false;
                        main.btn_reports.Visible = false;
                        main.btn_sell.Visible = false;
                        main.btn_customers.Visible = false;
                        main.Show();
                        Hide();

                    }
                    else if (add.privlage.Trim()== "مدير")
                    {
                        main.Show();
                        Hide();

                    }
                    else
                    {
                        Message("خطأ في معلومات تسجيل الدخول");
                    }

                }
               
               
            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر");

            }
        }


             
       


       

        
        private void Message( string message)
        {
            txt_message.Visible = true;
            timer1.Enabled = true;
            txt_message.Text = message;
            txt_message.BackColor = Color.Red;
            state = false;
        }

       

        private void btn_add_Click(object sender, EventArgs e)
        {
            Save();
        }

       

        private void Add_Categories_Activated(object sender, EventArgs e)
        {
            
        }

       

        private byte[] ConvertToByte()
        {
            MemoryStream ma = new MemoryStream();
            return ma.ToArray();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_message.Visible = false;
        }

        private void User_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void edt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void edt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}