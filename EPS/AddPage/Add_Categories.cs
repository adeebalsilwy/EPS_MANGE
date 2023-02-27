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

namespace EPS.AddPage
{
    public partial class Add_Categories : DevExpress.XtraEditors.XtraForm
    {
        public  int id;
        bool state;
        TB_Categories add;
        DBEPSEntities db;
        Note note;
        public double CatQuantity;
        public CategoriesPage page;
        public int IDGroup;
       


        public Add_Categories()
        {
            InitializeComponent();
        }

        private bool Save()
        {
            // check fields

            if (edt_name.Text == "")
            {
                Message("اكمل الحقل لطفا");
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
                        var Note = " تمت اضافة صنف جديدة من قبل "+ username;
                        note.AddNote(Note, notifications, "اضافة");



                    }
                    
                }
                else
                {
                    // Edit
                    // Check Duplicate Data
                   
                        // Edit
                        EditData();
                        state = true;
                        page.LoadData();


                        // Add new notification
                        note = new Note();
                        Page.Notifications notifications = new Page.Notifications();
                        var username = Properties.Settings.Default.UserFullName;
                        var Note = " تم تعديل صنف حالي من قبل " + username;
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
                add = new TB_Categories
                {
                   CatName=edt_name.Text,
                    CatGroup=combo_groups.SelectedItem.ToString(),
                    CatDes=edt_description.Text,
                    CatDate=DateTime.Now,
                    CatQuantity= CatQuantity,
                    IDGroups=IDGroup

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
                add = new TB_Categories
                {
                    ID=id,
                    CatName = edt_name.Text,
                    CatGroup = combo_groups.SelectedItem.ToString(),
                    CatDes = edt_description.Text,
                    CatDate = DateTime.Now,
                    CatQuantity =CatQuantity ,
                    IDGroups = IDGroup


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
                add = db.TB_Categories.Where(x => x.CatName == edt_name.Text).FirstOrDefault();
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
            Save();
        }

        private void btn_addclose_Click(object sender, EventArgs e)
        {
            var state=Save();
            if (state == true)
            {
                Close();

            }
           
        }

        private void Add_Categories_Activated(object sender, EventArgs e)
        {
            LoadGroups();
            SetIDGroup();
        }


        private void LoadGroups()
        {
            try
            {
                db = new DBEPSEntities();
                combo_groups.DataSource = db.TB_Groups.Select(x => x.GroupName).ToList();
            }
            catch { }
        }

        private void combo_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIDGroup();
        }
        private void SetIDGroup()
        {
            try
            {
                db = new DBEPSEntities();
                var id = db.TB_Groups.Where(x => x.GroupName == combo_groups.SelectedItem.ToString()).Select(x => x.ID).FirstOrDefault();
                IDGroup = id;

            }
            catch { }
        }

        private void link_addnewgroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Add_Groups page = new Add_Groups();
                GroupsPage page1 = new GroupsPage();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = page1;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }
    }
}