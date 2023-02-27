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
using System.Data.Entity.Migrations;
using System.IO;

namespace EPS.PL
{
    public partial class UsersPage : DevExpress.XtraEditors.XtraUserControl
    {
        DBEPSEntities db;
        TB_Users add;
        public int id;
      
        public UsersPage()
        {
            InitializeComponent();
            LoadData();


          
            
        }
        // Load Data Method
        public void LoadData()
        {
            EPS.DBEPSEntities dbContext = new EPS.DBEPSEntities();
            dbContext.TB_Users.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Users page = new Add_Users();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = this;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Users();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                    Add_Users page = new Add_Users();
                    page.btn_add.Text = "تعديل";
                    page.btn_addclose.Text = "تعديل + غلق";
                    MemoryStream ma = new MemoryStream(add.ProfileCover);
                    page.id = id;
                    page.edt_name.Text = add.FullName;
                    page.edt_username.Text = add.UserName;
                    page.edt_password.Text = add.Password;
                    page.pic_profile.Image = Image.FromStream(ma);
                    page.com_priv.Text = add.privlage;
                    page.page = this;
                    page.Show();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها, اختر صف لتعديله", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات","خطأ في الاتصال",MessageBoxButtons.OK,MessageBoxIcon.Information); 

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Users();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات ", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.TB_Users.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(add).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();

                        // Add new notification
                        BL.Note note = new BL.Note();
                        Page.Notifications notifications = new Page.Notifications();
                        var username = Properties.Settings.Default.UserFullName;
                        var Note = " تم حذف مستخدم من قبل " + username;
                        note.AddNote(Note, notifications, "حذف");

                    }

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لحذفها", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
