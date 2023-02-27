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
    public partial class Add_Users : DevExpress.XtraEditors.XtraForm
    {
        public  int id;
        bool state;
        TB_Users add;
        DBEPSEntities db;
        Note note;
        public UsersPage page;
       


        public Add_Users()
        {
            InitializeComponent();
        }

        private bool Save()
        {
            // check fields

            if (edt_name.Text == "" ||com_priv.Text==""|| edt_password.Text == "" || edt_username.Text == "" )
            {
                Message("اكمل الحقول  لطفا");
            }
            else
            {
                // Add or edit
                var checkDuplicate = CheckDuplicateData();
                if (id == 0)
                {
                    // Add
                    // Check Duplicate Data
                    
                    if(checkDuplicate == true)
                    {
                        Message("البيانات مكررة");

                    }
                    else
                    {
                        // Add
                        AddData();
                        state = true;
                        page.LoadData();


                        // Add new notification
                        note = new Note();
                        Page.Notifications notifications = new Page.Notifications();
                        var username = Properties.Settings.Default.UserFullName;
                        var Note = " تمت اضافة مستخدم جديد من قبل "+ username;
                        note.AddNote(Note, notifications, "اضافة");



                    }
                    
                }
                else
                {
                    // Edit
                   
                        // Edit
                        EditData();
                        state = true;
                        page.LoadData();


                        // Add new notification
                        note = new Note();
                        Page.Notifications notifications = new Page.Notifications();
                        var username = Properties.Settings.Default.UserFullName;
                        var Note = " تم تعديل مستخدم حالي من قبل " + username;
                        note.AddNote(Note, notifications, "تعديل");

                    

                }
            }
            return state;
        }

        private void AddData()
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Users
                {
                    
                    FullName=edt_name.Text,
                    UserName=edt_username.Text,
                    Password=edt_password.Text,
                    ProfileCover= ConvertToByte(),
                    UserState = 0,
                    privlage=com_priv.Text.Trim()

                };
                db.Entry(add).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("b63bb4e2-c3ce-411f-975a-c860580f1dc7");
               
            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر");

            }
        }


             
       


        private void EditData()
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Users
                {
                    ID=id,
                    FullName = edt_name.Text,
                    UserName = edt_username.Text,
                    Password = edt_password.Text,
                    ProfileCover = ConvertToByte(),
                    UserState=0,
                    privlage=com_priv.Text

                };
                db.Entry(add).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("5eb82af2-6df7-42a2-89da-1a50da44d73b");

            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر");

            }
        }

        private bool CheckDuplicateData()
        {
            try
            {
                db = new DBEPSEntities();
                add = db.TB_Users.Where(x => x.UserName == edt_username.Text).FirstOrDefault();
                if (add == null)
                {
                    state = false;
                }
                else
                {
                    state = true;
                }
            }
            catch
            {
                state = false;
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر");
            }


            return state;

        }
        private void Message( string message)
        {
            txt_message.Visible = true;
            timer1.Enabled = true;
            txt_message.Text = message;
            txt_message.BackColor = Color.Red;
            state = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_message.Visible = false;
            timer1.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(btn_add.Text== "تسجيل واعادة تشغيل")
            {
                Save();
                Application.Restart();
            }
            else
            {
                Save();

            }
        }

        private void btn_addclose_Click(object sender, EventArgs e)
        {
                Save();
           
                Close();

            
           
        }

        private void Add_Categories_Activated(object sender, EventArgs e)
        {
            
        }

        private void edt_phonenumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private byte[] ConvertToByte()
        {
            MemoryStream ma = new MemoryStream();
            pic_profile.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
            return ma.ToArray();

        }

        private void Add_Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(btn_add.Text== "تسجيل واعادة تشغيل")
            {
                Application.Exit();
            }
        }
    }
}