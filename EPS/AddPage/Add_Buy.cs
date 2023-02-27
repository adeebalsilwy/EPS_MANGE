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
using ZXing;
using System.IO;

namespace EPS.AddPage
{
    public partial class Add_Buy : DevExpress.XtraEditors.XtraForm
    {
        public  int id;
        bool state;
        TB_Buy add;
        DBEPSEntities db;
        Note note;
        public double CatQuantity;
        public BuyPage page;
        public int IDGroup;
        public byte[] image;
        double CurrConvertValue;

       public  int ID_Category;
       public int ID_Supplier;
       


        public Add_Buy()
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
                        var Note = " تمت اجراء عملية شراء جديدة من قبل "+ username;
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
                        var Note = " تم تعديل مادة في المشتريات حالية من قبل " + username;
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
                add = new TB_Buy
                {
                    ID_Catgeory = ID_Category,
                    ID_Supplier = ID_Supplier,
                    Name = edt_name.Text,
                    Category = edt_category.SelectedItem.ToString(),
                    Supplier = edt_supplier.SelectedItem.ToString(),
                    Quantity = Convert.ToDouble(edt_quantity.Text),
                    BarcodeValue = edt_barcode.Text,
                    BarcodeImage = image,
                    CashSellPrimary = Convert.ToDouble(edt_cashbuyprimary.Text),
                    CashSellSecondry = Convert.ToDouble(edt_cahbuysecondry.Text),
                    CreditSellPrimary = Convert.ToDouble(edt_creditbuyprimary.Text),
                    CreditSellSecondry = Convert.ToDouble(edt_creditbuysecondry.Text),
                    BuyPrimary = Convert.ToDouble(edt_buyprimary.Text),
                    BuySecondry = Convert.ToDouble(edt_buysecondry.Text),
                    SupplierPyment = Convert.ToDouble(edt_supplierpayment.Text),
                    SupplierPyment1 = Convert.ToDouble(edt_supplierpaymentsec.Text),
                    BuyAllValue = Convert.ToDouble(edt_buyall.Text),
                    SellAllValue = Convert.ToDouble(edt_sellall.Text),
                    Benfit = Convert.ToDouble(edt_benfit.Text),
                    DateAdd = DateTime.Now,
                    Description=edt_description.Text
                };
                db.Entry(add).State = System.Data.Entity.EntityState.Added;


                // Add Catedory Quantity
                TB_Categories categories = new TB_Categories();
                categories = db.TB_Categories.Where(x => x.ID == ID_Category).FirstOrDefault();
                categories.CatName = categories.CatName;
                categories.CatDate = categories.CatDate;
                categories.CatDes = categories.CatDes;
                categories.CatGroup = categories.CatGroup;
                categories.CatQuantity = Convert.ToDouble(edt_quantity.Text);
                categories.IDGroups = categories.IDGroups;
                categories.ID = categories.ID;
                db.Entry(categories).State = System.Data.Entity.EntityState.Modified;

                


                // Save DataBase
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
                add = new TB_Buy
                {
                    ID = id,
                    ID_Catgeory = ID_Category,
                    ID_Supplier = ID_Supplier,
                    Name = edt_name.Text,
                    Category = edt_category.SelectedItem.ToString(),
                    Supplier = edt_supplier.SelectedItem.ToString(),
                    Quantity = Convert.ToDouble(edt_quantity.Text),
                    BarcodeValue = edt_barcode.Text,
                    BarcodeImage = image,
                    CashSellPrimary = Convert.ToDouble(edt_cashbuyprimary.Text),
                    CashSellSecondry = Convert.ToDouble(edt_cahbuysecondry.Text),
                    CreditSellPrimary = Convert.ToDouble(edt_creditbuyprimary.Text),
                    CreditSellSecondry = Convert.ToDouble(edt_creditbuysecondry.Text),
                    BuyPrimary = Convert.ToDouble(edt_buyprimary.Text),
                    BuySecondry = Convert.ToDouble(edt_buysecondry.Text),
                    SupplierPyment = Convert.ToDouble(edt_supplierpayment.Text),
                    SupplierPyment1 = Convert.ToDouble(edt_supplierpaymentsec.Text),
                    BuyAllValue = Convert.ToDouble(edt_buyall.Text),
                    SellAllValue = Convert.ToDouble(edt_sellall.Text),
                    Benfit = Convert.ToDouble(edt_benfit.Text),
                    DateAdd = DateTime.Now,
                    Description = edt_description.Text
                };
                db.Entry(add).State = System.Data.Entity.EntityState.Modified;


                // Add Catedory Quantity
                TB_Categories categories = new TB_Categories();
                categories = db.TB_Categories.Where(x => x.ID == ID_Category).FirstOrDefault();
                categories.CatName = categories.CatName;
                categories.CatDate = categories.CatDate;
                categories.CatDes = categories.CatDes;
                categories.CatGroup = categories.CatGroup;
                categories.CatQuantity = Convert.ToDouble(edt_quantity.Text)+categories.CatQuantity;
                categories.IDGroups = categories.IDGroups;
                categories.ID = categories.ID;
                db.Entry(categories).State = System.Data.Entity.EntityState.Modified;

              
                // Save DataBase
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
                add = db.TB_Buy.Where(x => x.Name == edt_name.Text).FirstOrDefault();
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
            LoadSupplier();
            LoadCategory();
            SetCurrencyValue();
            //SetCategoryID();

            BL.UpdateData updateData = new UpdateData();
            updateData.UpdateSuppliersData();

        }

        private void SetCurrencyValue()
        {
            // Set Text 
            edt_primaryunit.Text = Properties.Settings.Default.PrimaryCurrName;
            edt_secondryunit.Text = Properties.Settings.Default.SecondryCurrName;
            label11.Text = label8.Text = label9.Text = edt_primaryunit.Text;
            label10.Text = label6.Text=label14.Text = edt_secondryunit.Text;
            CurrConvertValue = Properties.Settings.Default.CurrConvertValue;
            edt_convertvalue.Text = CurrConvertValue.ToString();

        }

        private void combo_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCategoryID();
        }
        private void SetCategoryID()
        {
            try
            {
                db = new DBEPSEntities();
                var itme = edt_category.SelectedItem.ToString();
                ID_Category = db.TB_Categories.Where(x => x.CatName == itme).Select(x => x.ID).FirstOrDefault();

            }
            catch { }
        }
       

        private void link_addnewgroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CategoriesPage page1 = new CategoriesPage();
                Add_Categories page = new Add_Categories();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = page1;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SuppliersPage page1 = new SuppliersPage();
                Add_Suppliers page = new Add_Suppliers();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = page1;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }

        private void LoadCategory()
        {
            try
            {
                db = new DBEPSEntities();
                var data = db.TB_Categories.Select(x => x.CatName).ToList();
                edt_category.DataSource = data;
            }
            catch { }
        }
        private void LoadSupplier()
        {
            try
            {
                db = new DBEPSEntities();
                var data = db.TB_Suppliers.Select(x => x.SupplierName).ToList();
                edt_supplier.DataSource = data;
            }
            catch { }
        }

        private void btn_barcodegenerator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ma = new MemoryStream();
            var barcodeWriter = new BarcodeWriter();
            barcodeWriter.Write(edt_barcode.Text).Save(ma,System.Drawing.Imaging.ImageFormat.Png);
            image = ma.ToArray();
          

        }

        private void edt_cashbuyprimary_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();




        }

        private void edt_cahbuysecondry_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();

        }

        private void edt_creditbuyprimary_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();


        }

        private void edt_creditbuysecondry_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();

        }

        private void edt_buyprimary_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();





        }

        private void edt_buysecondry_TextChanged(object sender, EventArgs e)
        {
            SetSellValue();

        }

        private void radio_yes_CheckedChanged(object sender, EventArgs e)
        {
            edt_supplierpayment.Enabled = false;
            edt_supplierpaymentsec.Enabled = false;
            edt_supplierpayment.Text = "0";
            edt_supplierpaymentsec.Text = "0";

        }

        private void radio_no_CheckedChanged(object sender, EventArgs e)
        {
            edt_supplierpayment.Enabled = false;
            edt_supplierpaymentsec.Enabled = false;
            edt_supplierpayment.Text =edt_buyall.Text;
            edt_supplierpaymentsec.Text = (Convert.ToDouble( edt_buysecondry.Text) *Convert.ToDouble( edt_quantity.Text)).ToString("#0.00");


        }

        private void radio_part_CheckedChanged(object sender, EventArgs e)
        {
            edt_supplierpayment.Enabled = true;
            edt_supplierpaymentsec.Enabled = true;

        }

        private void edt_buyall_TextChanged(object sender, EventArgs e)
        {
            try
            {
                edt_benfit.Text = ((Convert.ToDouble(edt_sellall.Text)) - Convert.ToDouble(edt_buyall.Text)).ToString("#0.00");

            }
            catch { }

        }

        private void edt_sellall_Click(object sender, EventArgs e)
        {

        }

        private void edt_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetIDSupplier();
        }
        private void SetIDSupplier()
        {
            try
            {
                db = new DBEPSEntities();
                var itme = edt_supplier.SelectedItem.ToString();
                ID_Supplier = db.TB_Suppliers.Where(x => x.SupplierName == itme).Select(x => x.ID).FirstOrDefault();

            }
            catch { }
        }

        private void edt_supplierpayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void edt_buyall_Click(object sender, EventArgs e)
        {

        }

        private void edt_benfit_Click(object sender, EventArgs e)
        {

        }

        private void edt_sellall_TextChanged(object sender, EventArgs e)
        {
            try
            {
                edt_benfit.Text = ((Convert.ToDouble(edt_sellall.Text)) - Convert.ToDouble(edt_buyall.Text)).ToString("#0.00");

            }
            catch { }
        }

        private void edt_quantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_quantity.Text, "[^0-9]") || edt_quantity.Text == "")
            {
                edt_quantity.Text = "1";
            }
            else
            {
                SetSellValue();
            }
        }

        private void edt_barcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_changeconvertvalue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_Settings fRM_Settings = new FRM_Settings();
            fRM_Settings.Show();
        }

        private void edt_secondryunit_Click(object sender, EventArgs e)
        {

        }

        private void Add_Buy_Load(object sender, EventArgs e)
        {

        }

        private void edt_cashbuyprimary_DoubleClick(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_cashbuyprimary.Text, "[^0-9]") || edt_cashbuyprimary.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_cashbuyprimary.Text = "0";
            }
            else
            {
                edt_cahbuysecondry.Text = ((Convert.ToDouble(edt_cashbuyprimary.Text)) / CurrConvertValue).ToString("#0.00");
                edt_sellall.Text = ((Convert.ToDouble(edt_cashbuyprimary.Text)) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");
            }
        }

        private void edt_cahbuysecondry_DoubleClick(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_cahbuysecondry.Text, "[^0-9]") || edt_cahbuysecondry.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_cahbuysecondry.Text = "0";
            }
            else
            {
                edt_cashbuyprimary.Text = ((Convert.ToDouble(edt_cahbuysecondry.Text)) * CurrConvertValue).ToString("#0.00");
                edt_sellall.Text = ((Convert.ToDouble(edt_cashbuyprimary.Text)) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");
            }
        }

        private void edt_creditbuyprimary_DoubleClick(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_creditbuyprimary.Text, "[^0-9]") || edt_creditbuyprimary.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_creditbuyprimary.Text = "0";
            }
            else
            {
                edt_creditbuysecondry.Text = ((Convert.ToDouble(edt_creditbuyprimary.Text)) / CurrConvertValue).ToString("#0.00");

            }
        }

        private void edt_creditbuysecondry_DoubleClick(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_creditbuysecondry.Text, "[^0-9]") || edt_creditbuysecondry.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_creditbuysecondry.Text = "0";
            }
            else
            {
                edt_creditbuyprimary.Text = ((Convert.ToDouble(edt_creditbuysecondry.Text)) * CurrConvertValue).ToString("#0.00");

            }
        }

        private void edt_buyprimary_DoubleClick(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_buyprimary.Text, "[^0-9]") || edt_buyprimary.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_buyprimary.Text = "0";
            }
            else
            {
                edt_buysecondry.Text = ((Convert.ToDouble(edt_buyprimary.Text)) / CurrConvertValue).ToString("#0.00");
                edt_buyall.Text = ((Convert.ToDouble(edt_buyprimary.Text)) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");
            }
        }

        private void edt_buysecondry_DoubleClick(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_buysecondry.Text, "[^0-9]") || edt_buysecondry.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_buysecondry.Text = "0";
            }
            else
            {
                edt_buyprimary.Text = ((Convert.ToDouble(edt_buysecondry.Text)) * CurrConvertValue).ToString("#0.00");
                edt_buyall.Text = ((Convert.ToDouble(edt_buyprimary.Text)) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");
            }
        }

        private void edt_supplierpayment_DoubleClick(object sender, EventArgs e)
        {
            edt_supplierpaymentsec.Text = ((Convert.ToDouble(edt_supplierpayment.Text)) / CurrConvertValue).ToString("#0.00");

        }

        private void edt_supplierpaymentsec_DoubleClick(object sender, EventArgs e)
        {
            edt_supplierpayment.Text = ((Convert.ToDouble(edt_supplierpaymentsec.Text)) *CurrConvertValue).ToString("#0.00");

        }

        private void SetSellValue()
        {
            try
            {
                edt_buyall.Text= (Convert.ToDouble(edt_buyprimary.Text) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");
                if (radio_yes.Checked == true)
                {
                    edt_supplierpayment.Enabled = false;
                    edt_supplierpaymentsec.Enabled = false;
                    edt_supplierpayment.Text = "0";
                    edt_supplierpaymentsec.Text = "0";
                }
                else if (radio_no.Checked == true)
                {
                    edt_supplierpayment.Enabled = false;
                    edt_supplierpaymentsec.Enabled = false;
                    edt_supplierpayment.Text = edt_buyall.Text;
                    edt_supplierpaymentsec.Text = (Convert.ToDouble(edt_buysecondry.Text) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");
                }

            }
            catch { }
        }
    }
}