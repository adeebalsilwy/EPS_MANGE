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

namespace EPS.PL
{
    public partial class BuyPage : DevExpress.XtraEditors.XtraUserControl
    {
        DBEPSEntities db;
        TB_Buy add;
        public int id;
        string valuePayment;
        public BuyPage()
        {
            InitializeComponent();
            LoadData();
            SetCurrncyValue();


        }
        private void SetCurrncyValue()
        {
            var primarycurrname = Properties.Settings.Default.PrimaryCurrName;
            var secodrycurrname = Properties.Settings.Default.SecondryCurrName;
            gridView1.Columns["SupplierPyment"].Caption = "الديون - " + primarycurrname;
            gridView1.Columns["BuyAllValue"].Caption = " الشراء الكلي - " + primarycurrname;


        }

        // Load Data Method
        public void LoadData()
        {
            EPS.DBEPSEntities dbContext = new EPS.DBEPSEntities();
            dbContext.TB_Buy.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Buy.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Buy page = new Add_Buy();
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
                add = new TB_Buy();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TB_Buy.Where(x => x.ID == id).FirstOrDefault();
                    Add_Buy page = new Add_Buy();
                    page.page = this;
                    page.btn_add.Text = "تعديل";
                    page.btn_addclose.Text = "تعديل + غلق";
                    page.id = id;
                    page.page = this;
                    page.ID_Category = (int)add.ID_Catgeory;
                    page.ID_Supplier = (int)add.ID_Supplier;
                    page.edt_name.Text = add.Name;
                    page.edt_category.SelectedItem = add.Category;
                    page.edt_supplier.SelectedItem = add.Supplier;
                    page.edt_quantity.Text = add.Quantity.ToString();
                    page.edt_barcode.Text = add.BarcodeValue;
                    page.image = add.BarcodeImage;
                    page.edt_cashbuyprimary.Text = add.CashSellPrimary.ToString();
                    page.edt_cahbuysecondry.Text = add.CashSellSecondry.ToString();
                    page.edt_creditbuyprimary.Text = add.CreditSellPrimary.ToString();
                    page.edt_creditbuysecondry.Text = add.CreditSellSecondry.ToString();
                    page.edt_buyprimary.Text = add.BuyPrimary.ToString();
                    page.edt_buysecondry.Text = add.BuySecondry.ToString();
                    page.edt_supplierpayment.Text = add.SupplierPyment.ToString();
                    page.edt_buyall.Text = add.BuyAllValue.ToString();
                    page.edt_sellall.Text = add.SellAllValue.ToString();
                    page.edt_benfit.Text = add.Benfit.ToString();
                    page.edt_description.Text = add.Description;
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
                add = new TB_Buy();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات , سيتم حذف جميع البيانات المرتبطة", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        add = db.TB_Buy.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(add).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();

                        // Add new notification
                        BL.Note note = new BL.Note();
                        Page.Notifications notifications = new Page.Notifications();
                        var username = Properties.Settings.Default.UserFullName;
                        var Note = " تم حذف مادة من المخزن من قبل " + username;
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

        private void btn_details_Click(object sender, EventArgs e)
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Buy();
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add = db.TB_Buy.Where(x => x.ID == id).FirstOrDefault();
                    Add_Buy page = new Add_Buy();
                    page.page = this;
                    page.btn_add.Visible = false;
                    page.Enabled = false;
                    page.btn_addclose.Visible = false;
                    page.id = id;
                    page.page = this;
                    page.ID_Category = (int)add.ID_Catgeory;
                    page.ID_Supplier = (int)add.ID_Supplier;
                    page.edt_name.Text = add.Name;
                    page.edt_category.SelectedItem = add.Category;
                    page.edt_supplier.SelectedItem = add.Supplier;
                    page.edt_quantity.Text = add.Quantity.ToString();
                    page.edt_barcode.Text = add.BarcodeValue;
                    page.image = add.BarcodeImage;
                    page.edt_cashbuyprimary.Text = add.CashSellPrimary.ToString();
                    page.edt_cahbuysecondry.Text = add.CashSellSecondry.ToString();
                    page.edt_creditbuyprimary.Text = add.CreditSellPrimary.ToString();
                    page.edt_creditbuysecondry.Text = add.CreditSellSecondry.ToString();
                    page.edt_buyprimary.Text = add.BuyPrimary.ToString();
                    page.edt_buysecondry.Text = add.BuySecondry.ToString();
                    page.edt_supplierpayment.Text = add.SupplierPyment.ToString();
                    page.edt_buyall.Text = add.BuyAllValue.ToString();
                    page.edt_sellall.Text = add.SellAllValue.ToString();
                    page.edt_benfit.Text = add.Benfit.ToString();
                    page.edt_description.Text = add.Description;
                    page.edt_supplierpaymentsec.Text = add.SupplierPyment1.ToString();
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
            var primerycurrname = Properties.Settings.Default.PrimaryCurrName;
           valuePayment= XtraInputBox.Show("اكتب المبلغ المراد دفعة في عملة "+ "["+primerycurrname+ "],تذكر سيتم التسديد هنا وفي بيانات المورد ويتم اعتماد  سعر التحويل الحالي بين العملتين", "عمل دفعة","0.00");
            if (valuePayment != null)
            {
                MakePayment();
                LoadData();
            }
            

        }

        private void MakePayment()
        {
            var convertvalue = Properties.Settings.Default.CurrConvertValue;

            try { 
            db = new DBEPSEntities();
            add = new TB_Buy();
            id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
             add = db.TB_Buy.Where(x => x.ID == id).FirstOrDefault();

                if (id != 0)
            {

                db = new DBEPSEntities();

                add = new TB_Buy
                {
                    ID = add.ID,
                    ID_Catgeory = add.ID_Catgeory,
                    ID_Supplier = add.ID_Supplier,
                    Name = add.Name,
                    Category = add.Category,
                    Supplier = add.Supplier,
                    Quantity = add.Quantity,
                    BarcodeValue = add.BarcodeValue,
                    BarcodeImage = add.BarcodeImage,
                    CashSellPrimary = add.CashSellPrimary,
                    CashSellSecondry = add.CashSellSecondry,
                    CreditSellPrimary = add.CreditSellPrimary,
                    CreditSellSecondry = add.CreditSellSecondry,
                    BuyPrimary = add.BuyPrimary,
                    BuySecondry = add.BuySecondry,
                    SupplierPyment = add.SupplierPyment - Convert.ToDouble(valuePayment),
                    SupplierPyment1 = add.SupplierPyment1 -Convert.ToDouble( ((Convert.ToDouble(valuePayment)/convertvalue)).ToString("#0.00")),
                    BuyAllValue = add.BuyAllValue,
                    SellAllValue = add.SellAllValue,
                    Benfit = add.Benfit,
                    DateAdd = add.DateAdd,
                    Description = add.Description,
                   
                };

                    TB_SuppliersPayments logs = new TB_SuppliersPayments
                    {
                        SellID = add.ID,
                        CustomerID = add.ID_Supplier,
                        Pamnent = Convert.ToDouble(valuePayment),
                        Date = DateTime.Now
                    };
                    db.TB_SuppliersPayments.Add(logs);

                    db.Set<TB_Buy>().AddOrUpdate(add);

                // Save DataBase
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("f1449fe1-3838-416b-b71a-c50500f603ee");
                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات , اختر صف لعمل الدفعة", "لا يمكن اجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch
            {

            }
        }

        private void btn_showdateofpayments_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                db = new DBEPSEntities();
                FRM_PamymnetsLogSuppliers logs = new FRM_PamymnetsLogSuppliers();
                logs.Text = logs.Text + " - قائمة رقم " + id.ToString();
                logs.gridControl1.DataSource = db.TB_SuppliersPayments.Where(x => x.SellID == id).ToList();
                logs.Show();
            }
            catch { }
        }
    }
}
