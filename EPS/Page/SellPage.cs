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
using DevExpress.XtraReports.UI;
using System.Data.Entity.Migrations;

namespace EPS.PL
{
    public partial class SellPage : DevExpress.XtraEditors.XtraUserControl
    {
        DBEPSEntities db;
        TB_Sell add;
        public int id;
        string valuePayment;
        public SellPage()
        {
            InitializeComponent();
            LoadData();


            SetCurrncyValue();


        }
        // Set Currnecy
        private void SetCurrncyValue()
        {
            var primarycurrname = Properties.Settings.Default.PrimaryCurrName;
            gridView1.Columns["CustomerBalance"].Caption = "الديون - " + primarycurrname;
            gridView1.Columns["SellValue"].Caption = "المبلغ الكلي - " + primarycurrname;


        }

        // Load Data Method
        public void LoadData()
        {
            EPS.DBEPSEntities dbContext = new EPS.DBEPSEntities();
            dbContext.TB_Sell.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Sell.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Sell page = new Add_Sell();
                page.btn_add.Text = "اضافة";
                page.edt_name.Text = "";
                page.page = this;
                page.Show();
                page.id = 0;
                page.ISNew = true;
                page.NewSellAction = true;

            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Sell();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TB_Sell.Where(x => x.ID == id).FirstOrDefault();
                    Add_Sell page = new Add_Sell();
                    page.page = this;
                    page.SellID = id;
                    page.page = this;
                    page.ISNew = false;
                    page.NewSellAction = false;
                  
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
                add = new TB_Sell();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المرتبطة", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.TB_Sell.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(add).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();

                        // Add new notification
                        BL.Note note = new BL.Note();
                        Page.Notifications notifications = new Page.Notifications();
                        var username = Properties.Settings.Default.UserFullName;
                        var Note = " تم حذف عملية بيع من قبل " + username;
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
            SentDataForReport();
        }
        private void SentDataForReport()
        {
            var SellID =Convert.ToInt16( gridView1.GetFocusedRowCellValue("ID"));
            Properties.Settings.Default.IDSell = SellID;
            Properties.Settings.Default.IDSellData = SellID;
            Properties.Settings.Default.Save();
            ReportPrintTool printTool = new ReportPrintTool(new Report.SellReportAction());
            printTool.ShowPreview();

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Sell();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TB_Sell.Where(x => x.ID == id).FirstOrDefault();
                    Add_Sell page = new Add_Sell();
                    page.page = this;
                    page.btn_add.Visible = false;
                    page.btn_addclose.Visible = false;
                    page.btn_delete.Visible = false;
                    page.btn_edit.Visible = false;
                    page.btn_addclose.Visible = false;
                    page.SellID = id;
                    page.page = this;
                    page.btn_new.Visible = false;
                    page.Show();
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات , اختر صف لعرضه", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات", "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {

            BL.Pymnets pymnets = new BL.Pymnets();
            id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
            pymnets.id = id;
            pymnets.lb_id.Text = id.ToString();
            pymnets.Show();


        }

        private void btn_allpaymnets_Click(object sender, EventArgs e)
        {
            BL.Pymnetsrequired pymnetsrequired = new BL.Pymnetsrequired();
            pymnetsrequired.Show();
        }
    }
}
