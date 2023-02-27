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
using EPS.Page;

namespace EPS.PL
{
    public partial class CustomersPage : DevExpress.XtraEditors.XtraUserControl
    {
        DBEPSEntities db;
        TB_Customers add;
        public int id;
        string valuePayment;
        int ID_Supplier;
        public CustomersPage()
        {
            InitializeComponent();
            LoadData();
            SetCurrncyValue();


        }
    
        // Set Currnecy
        private void SetCurrncyValue()
        {
            var primarycurrname = Properties.Settings.Default.PrimaryCurrName;
            var Secondcurrname = Properties.Settings.Default.SecondryCurrName;
            gridView1.Columns["SupplierBalance"].Caption = "الرصيد - " + primarycurrname;
            gridView1.Columns["SupplierBalanceprim"].Caption = "الرصيد - " + Secondcurrname;


        }
        // Load Data Method
        public void LoadData()
        {
            UpdateCustomerValue();

            EPS.DBEPSEntities dbContext = new EPS.DBEPSEntities();
            dbContext.TB_Customers.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Customers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Customers page = new Add_Customers();
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
                add = new TB_Customers();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();
                    Add_Customers page = new Add_Customers();
                    page.btn_add.Text = "تعديل";
                    page.btn_addclose.Text = "تعديل + غلق";
                    page.edt_name.Text = add.SupplierName;
                    page.edt_phonenumber.Text = add.SupplierPhone.ToString();
                    page.SupplierBalance = (double)add.SupplierBalance;
                    page.id = id;
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
                add = new TB_Customers();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المرتبطة", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(add).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();

                        // Add new notification
                        BL.Note note = new BL.Note();
                        Page.Notifications notifications = new Page.Notifications();
                        var username = Properties.Settings.Default.UserFullName;
                        var Note = " تم حذف مورد من قبل " + username;
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
            var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , سيتم تصفير الديون من جميع عمليات الشراء المرتبطة بهذا العميل", "اجراء تصفير حساب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dilogeresult == DialogResult.Yes)
            {
                var ID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));

                try
                {
                    db = new DBEPSEntities();
                    var listid = db.TB_Pyments.Where(x => x.IDCustomer == ID).Select(x => x.ID).ToList();
                    for (int i = 0; i < listid.Count; i++)
                    {
                        TB_Pyments buy = new TB_Pyments();
                        var id = listid[i];
                        buy = db.TB_Pyments.Where(x => x.IDCustomer == ID && x.ID == id).FirstOrDefault();
                        db.Entry(buy).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    MessageBox.Show("تم تصفير الحساب بنجاح");
                    // Add new notification
                    BL.Note note = new BL.Note();
                    Page.Notifications notifications = new Page.Notifications();
                    var username = Properties.Settings.Default.UserFullName;
                    var Note = " تم تصفير حساب عميل من قبل " + username;
                    note.AddNote(Note, notifications, "تصفير");
                }
                catch { }
            }

            LoadData();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));

            Page.SetDateForPrintReport report = new SetDateForPrintReport();
            report.ID = ID;
            report.ReportName = "العملاء";

            report.Show();
        }



       
        private void UpdateCustomerValue()
        {
            try
            {
                var convertvalue = Properties.Settings.Default.CurrConvertValue;
                db = new DBEPSEntities();
                // Add Supplier Value
                TB_Customers customers = new TB_Customers();
                var idcustomerlist = db.TB_Customers.Select(x => x.ID).ToList();

                for(int i = 0; i < idcustomerlist.Count; i++)
                {
                    var id = idcustomerlist[i];

                    customers = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();


                    if (customers != null)
                    {
                        var TotalValue = db.TB_Sell.Where(x => x.IDCustomer == id).Select(x => x.CustomerBalance).ToArray();
                        if (TotalValue != null)
                        {
                            customers.SupplierBalance = TotalValue.Sum();
                            customers.SupplierBalanceprim =Convert.ToDouble(((double)(TotalValue.Sum()/convertvalue)).ToString("#0.00"));

                            db.Set<TB_Customers>().AddOrUpdate(customers);
                            db.SaveChanges();

                        }
                    }
                       
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_showdateofpayments_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                db = new DBEPSEntities();
                add = db.TB_Customers.Where(x => x.ID == id).FirstOrDefault();
                FRM_PamymnetsLogs logs = new FRM_PamymnetsLogs();
                logs.Text = logs.Text + " - اسم العميل " + add.SupplierName;
                logs.gridControl1.DataSource = db.TB_CustomerPaymentLogs.Where(x => x.CustomerID == id).ToList();
                logs.Show();
            }
            catch { }
        }
    }
}
