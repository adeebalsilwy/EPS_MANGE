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
using System.Data.Entity;
using System.Data.Entity.Migrations;
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;

namespace EPS.AddPage
{
    public partial class Add_Sell : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        bool state;
        TB_Sell add;
        DBEPSEntities db;
        Note note;
        public double CatQuantity;
        public SellPage page;
        public int IDGroup;
        public byte[] image;
        double CurrConvertValue;
        public int IDlOAD;
        public int SellID;
        public bool ISNew = true;
        public string SellState = "نقدا";
        public double SellValue;
        public bool NewSellAction = true;
        double TotalSell;
        int Buyid;

        public int IDCustomer = 0;
        private TB_Pyments pyments;
        private DateTime PaymentDate;

        public Add_Sell()
        {
            InitializeComponent();


        }
        private void LoadData()
        {
            try
            {
                EPS.DBEPSEntities dbContext = new EPS.DBEPSEntities();
                gridControl1.DataSource = db.TB_SellData.Where(x => x.IDSell == SellID).ToList();
            }
            catch { }

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
                var checkDuplicate = false;

                // Add
                // Check Duplicate Data

                if (checkDuplicate == true)
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
                    var Note = " تمت اجراء عملية بيع جديدة من قبل " + username;
                    note.AddNote(Note, notifications, "اضافة");



                }

            }


            return state;
        }

        private void AddData()
        {
            try
            {
                if (IDCustomer > 0)
                {
                    db = new DBEPSEntities();
                    if (NewSellAction == true)
                    {
                        add = new TB_Sell
                        {
                            CustomerName = edt_customer.Text,
                            CustomerBalance = 0,
                            CustomerBalanceprim=0,
                            IDCustomer = IDCustomer,
                            SellValue = 0,
                            Date = DateTime.Now

                        };
                        db.Entry(add).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        NewSellAction = false;
                    }
                }
                else
                {
                    db = new DBEPSEntities();
                    if (NewSellAction == true)
                    {
                        add = new TB_Sell
                        {
                            CustomerName = edt_customer.Text,
                            CustomerBalance = 0,
                            SellValue = 0,
                            Date = DateTime.Now

                        };
                        db.Entry(add).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        NewSellAction = false;
                    }
                }



                // Set Sell ID
                if (ISNew == true)
                {
                    SellID = db.TB_Sell.Select(x => x.ID).ToArray().Max();
                    ISNew = false;
                }

                // Add Sell Data
                TB_SellData sellData = new TB_SellData
                {
                    MatrialsName = edt_name.Text,
                    Quantity = Convert.ToDouble(edt_quantity.Text),
                    CustomerName = edt_customer.Text,
                    SellState = SellState,
                    SellValue = SellValue,
                    SellAllValue = Convert.ToDouble(edt_sellall.Text),
                    IDSell = SellID,
                    CustomerBalance = Convert.ToDouble(edt_customerbalance.Text),
                    CustomerBalanceprim = 0

                };
                db.Entry(sellData).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();


                // Add Customer Value
                if (IDCustomer > 0)
                {
                    TB_Customers suppliers = new TB_Customers();
                    suppliers = db.TB_Customers.Where(x => x.ID == IDCustomer).FirstOrDefault();
                    suppliers.SupplierBalance = Convert.ToDouble(edt_customerbalance.Text) + Convert.ToDouble(customerbalance.Text);
                    db.Entry(suppliers).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }

                // SET FINAL VALUE
                db = new DBEPSEntities();
                var tbselldata = db.TB_Sell.Where(x => x.ID == SellID).FirstOrDefault();
                var dataSell = db.TB_SellData.Where(x => x.IDSell == SellID).Select(x => x.SellAllValue).ToArray();
                TotalSell = (double)dataSell.Sum();
                var TotalBalnce1 = db.TB_SellData.Where(x => x.IDSell == SellID).Select(x => x.CustomerBalance).ToArray().Sum();
                var TotalBalnce2 = db.TB_SellData.Where(x => x.IDSell == SellID).Select(x => x.CustomerBalanceprim).ToArray().Sum();
                tbselldata.SellValue = TotalSell;
                tbselldata.CustomerBalance = TotalBalnce1;
                tbselldata.CustomerBalanceprim = TotalBalnce2;




                db.Set<TB_Sell>().AddOrUpdate(tbselldata);

                // Save DataBase
                db.SaveChanges();
                SetQuantityValue();
                Message("تمت الاضافة");

            }
            catch (Exception EX)
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر" + EX.Message.ToString());

            }
        }






        private void EditData()
        {
            try
            {
                ReturnQuantityForEdit();
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                // Add Sell Data
                TB_SellData sellData = new TB_SellData
                {
                    ID = id,
                    MatrialsName = edt_name.Text,
                    Quantity = Convert.ToDouble(edt_quantity.Text),
                    CustomerName = edt_customer.Text,
                    SellState = SellState,
                    SellValue = SellValue,
                    SellAllValue = Convert.ToDouble(edt_sellall.Text),
                    CustomerBalance = Convert.ToDouble(edt_customerbalance.Text),
                    CustomerBalanceprim = 0,
                    IDSell = SellID

                };
                db.Set<TB_SellData>().AddOrUpdate(sellData);
                db.SaveChanges();
                // Add Customer Value
                if (IDCustomer > 1)
                {
                    TB_Customers suppliers = new TB_Customers();
                    suppliers = db.TB_Customers.Where(x => x.ID == IDCustomer).FirstOrDefault();

                    suppliers.SupplierBalance = Convert.ToDouble(edt_customerbalance.Text) + Convert.ToDouble(customerbalance.Text);
                    db.Set<TB_Customers>().AddOrUpdate(suppliers);
                    db.SaveChanges();

                }

                // SET FINAL VALUE
                db = new DBEPSEntities();
                var tbselldata = db.TB_Sell.Where(x => x.ID == SellID).FirstOrDefault();
                var dataSell = db.TB_SellData.Where(x => x.IDSell == SellID).Select(x => x.SellAllValue).ToArray();
                TotalSell = (double)dataSell.Sum();
                var TotalBalnce1 = db.TB_SellData.Where(x => x.IDSell == SellID).Select(x => x.CustomerBalance).ToArray().Sum();
                var TotalBalnce2 = db.TB_SellData.Where(x => x.IDSell == SellID).Select(x => x.CustomerBalanceprim).ToArray().Sum();
                tbselldata.SellValue = TotalSell;
                tbselldata.CustomerBalance = TotalBalnce1;
                tbselldata.CustomerBalanceprim = TotalBalnce2; 
                db.Set<TB_Sell>().AddOrUpdate(tbselldata);
                SetQuantityValue();
                // Save DataBase
                db.SaveChanges();
                Message("تم التعديل");
            }
            catch
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر");

            }
        }


        private void Message(string message)
        {
            txt_message.Visible = true;
            timer1.Enabled = true;
            txt_message.Text = message;
            state = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_message.Visible = false;
            timer1.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var Quanity = Convert.ToDouble(txt_currentquantity.Text);
            if (Quanity <= 0)
            {
                var rs = MessageBox.Show("انتبة لا توجد كمية في المشتربات , هل تود الاستمرار في الاضافة كقيمة سالبة ", "انتبة الكمية نافذة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    Save();
                    LoadData();
                    SetCustomerID();
                }
            }
            else
            {
                Save();
                LoadData();
                SetCustomerID();
            }

        }

        private void btn_addclose_Click(object sender, EventArgs e)
        {
            AddDataPayments();
            Close();
            page.LoadData();
            SentDataForReport();



        }

        private void AddDataPayments()
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Sell();
                add = db.TB_Sell.ToList().Last();
                // Calcualte the amount of paymnet time
                var TotalPayment = add.CustomerBalance;
                var monthPayment = Convert.ToDouble(edt_payment1.Text);
                int numberofpayment = Convert.ToInt32(TotalPayment / monthPayment);
                var newpayments =(double) (TotalPayment / numberofpayment);
                PaymentDate = DateTime.Now;
                for (int i = 1; i <= numberofpayment; i++)
                {

                    pyments = new TB_Pyments
                    {
                        IDSELL = add.ID,
                        IDCustomer = add.IDCustomer,
                        SellName = add.SellMenuName,
                        CustomerName = add.CustomerName,
                        AddDate = DateTime.Now,
                        Paymentone = Convert.ToDouble(newpayments.ToString("#0.00")),
                        PaymentDate = PaymentDate,
                        PaymentState = "لا",
                        CurrentPaymentone = 0,
                    };

                    PaymentDate = PaymentDate.AddDays(30);
                    db.TB_Pyments.Add(pyments);
                    db.SaveChanges();
                }



            }
            catch (Exception ex)
            {
                Message("خطأ , لطفا تحقق من متطلبات الادخال والاتصال بالسيرفر");

            }
        }

        private void SentDataForReport()
        {
            Properties.Settings.Default.IDSell = SellID;
            Properties.Settings.Default.IDSellData = SellID;
            Properties.Settings.Default.Save();
            ReportPrintTool printTool = new ReportPrintTool(new Report.SellReportAction());
            printTool.ShowPreview();

        }

        private void Add_Categories_Activated(object sender, EventArgs e)
        {
            GetMaterialsData();
            GetMaterialListName();
            GetSupplierListName();
            SetCurrencyValue();
            GetMaterialsData();


            SetSellData();


            SetCustomerID();


            BL.UpdateData updateData = new UpdateData();
            updateData.UpdateCustomerData();

        }

       

        private void SetCurrencyValue()
        {
            // Set Text 
            edt_primaryunit.Text = Properties.Settings.Default.PrimaryCurrName;
            label11.Text = label9.Text = label6.Text = label4.Text = edt_primaryunit.Text;
            CurrConvertValue = Properties.Settings.Default.CurrConvertValue;
            edt_convertvalue.Text = CurrConvertValue.ToString();

        }





        private void link_addnewgroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CustomersPage page1 = new CustomersPage();
                Add_Customers page = new Add_Customers();
                page.btn_add.Text = "اضافة";
                page.btn_addclose.Text = "اضافة + غلق";
                page.edt_name.Text = "";
                page.id = 0;
                page.page = page1;
                page.Show();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }



        private void btn_barcodegenerator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ma = new MemoryStream();
            var barcodeWriter = new BarcodeWriter();
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



        private void edt_buysecondry_TextChanged(object sender, EventArgs e)
        {
            // edt_buyprimary.Text = ((Convert.ToDouble(edt_buysecondry.Text)) *CurrConvertValue).ToString("#0.00");

        }





        private void edt_buyall_TextChanged(object sender, EventArgs e)
        {

        }

        private void edt_sellall_Click(object sender, EventArgs e)
        {

        }

        private void edt_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void GetMaterialsData()
        {
            try
            {
                TB_Buy buy = new TB_Buy();
                db = new DBEPSEntities();
                var itme = edt_name.Text.ToString();
                buy = db.TB_Buy.Where(x => x.Name == itme).FirstOrDefault();

                if (buy != null)
                {
                    edt_cashbuyprimary.Text = buy.CashSellPrimary.ToString();
                    edt_creditbuyprimary.Text = buy.CreditSellPrimary.ToString();
                    Buyid = buy.ID;
                    txt_currentquantity.Text = buy.Quantity.ToString();

                }


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

        }

        private void edt_quantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_quantity.Text, "[^0-9]") || edt_quantity.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_quantity.Text = "0";
            }
            else
            {
                SetSellValue();
                SetSellData();
            }

        }

        private void SetSellValue()
        {
            try
            {
                if (chk_cash.Checked == true)
                {

                    edt_sellall.Text = ((Convert.ToDouble(edt_cashbuyprimary.Text)) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");

                }
                else if(ch_credit.Checked==true)
                {
                    edt_sellall.Text = ((Convert.ToDouble(edt_creditbuyprimary.Text)) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");
                    edt_customerbalance.Text = ((Convert.ToDouble(edt_creditbuyprimary.Text)) * Convert.ToDouble(edt_quantity.Text)).ToString("#0.00");

                }
            }
            catch { MessageBox.Show("الرجاء ادخال قيمةرقمية"); }

        }
        private void edt_name_TextChanged(object sender, EventArgs e)
        {
            GetMaterialsData();

            SetSellData();

        }
        private void SetSellData()
        {
            try
            {
                if (ch_credit.Checked == true)
                {
                    SellState = "اجل";
                    SellValue = Convert.ToDouble(edt_creditbuyprimary.Text);
                }
                if (chk_cash.Checked == true)
                {

                    SellState = "نقدا";
                    SellValue = Convert.ToDouble(edt_cashbuyprimary.Text);
                }
            }
            catch
            {
            }


        }
        private void GetMaterialListName()
        {
            try
            {

                db = new DBEPSEntities();
                var listData = db.TB_Buy.Select(X => X.Name).ToList();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                collection.AddRange(listData.ToArray());
                edt_name.AutoCompleteCustomSource = collection;

            }
            catch { }
        }
        private void GetSupplierListName()
        {
            try
            {

                db = new DBEPSEntities();

                var listData = db.TB_Customers.Select(x => x.SupplierName).ToList();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                collection.AddRange(listData.ToArray());
                edt_customer.AutoCompleteCustomSource = collection;

            }
            catch { }
        }

        private void chk_cash_CheckedChanged(object sender, EventArgs e)
        {
            group_cash.BringToFront();
            SetSellValue();
            ch_yes.Checked = true;
            SellState = "نقدا";
            SellValue = Convert.ToDouble(edt_cashbuyprimary.Text);
            edt_customerbalance.Text = "0";
            edt_customerbalance.Enabled = false;
            edt_payment1.Enabled = false;



        }

        private void ch_credit_CheckedChanged(object sender, EventArgs e)
        {
            group_credit.BringToFront();
            SetSellValue();
            SellState = "اجل";
            ch_no.Checked = true;
            SellValue = Convert.ToDouble(edt_creditbuyprimary.Text);
            edt_customerbalance.Text = edt_sellall.Text;
            edt_payment1.Enabled = true;

            edt_customerbalance.Enabled = false;




        }

        private void ch_yes_CheckedChanged(object sender, EventArgs e)
        {
            edt_customerbalance.Text = "0";
            edt_customerbalance.Enabled = false;

        }

        private void ch_no_CheckedChanged(object sender, EventArgs e)
        {
            edt_customerbalance.Text = edt_sellall.Text;
            edt_customerbalance.Enabled = false;

        }

        private void ch_part_CheckedChanged(object sender, EventArgs e)
        {
            edt_customerbalance.Enabled = true;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void edt_customer_TextChanged(object sender, EventArgs e)
        {

            SetCustomerID();


        }
        private void SetCustomerID()
        {
            if (edt_customer.Text == "")
            {
                IDCustomer = 0;

            }
            else
            {
                try
                {
                    db = new DBEPSEntities();
                    TB_Customers customers = new TB_Customers();
                    var value = edt_customer.Text;
                    customers = db.TB_Customers.Where(x => x.SupplierName == value).FirstOrDefault();
                    if (customers != null)
                    {
                        customerbalance.Text = customers.SupplierBalance.ToString();
                        IDCustomer = customers.ID;

                    }
                    else
                    {
                        IDCustomer = 0;
                        customerbalance.Text = "0";


                    }
                }
                catch { }
                SetSellData();
            }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                db = new DBEPSEntities();
                TB_SellData data = new TB_SellData();
                var idsell = Convert.ToInt16(gridView1.GetFocusedRowCellValue("ID"));
                data = db.TB_SellData.Where(x => x.ID == idsell).FirstOrDefault();
                edt_name.Text = data.MatrialsName;
                edt_customer.Text = data.CustomerName;
                edt_quantity.Text = data.Quantity.ToString();
            }
            catch { }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var Quanity = Convert.ToDouble(txt_currentquantity.Text);
            if (Quanity <= 0)
            {
                var rs = MessageBox.Show("انتبة لا توجد كمية في المشتربات , هل تود الاستمرار في الاضافة كقيمة سالبة ", "انتبة الكمية نافذة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rs == DialogResult.Yes)
                {
                    try
                    {
                        // Edit

                        EditData();
                        state = true;
                        page.LoadData();


                        // Add new notification
                        note = new Note();
                        Page.Notifications notifications = new Page.Notifications();
                        var username = Properties.Settings.Default.UserFullName;
                        var Note = " تم تعديل مادة في المبعيات حالية من قبل " + username;
                        note.AddNote(Note, notifications, "تعديل");
                        LoadData();



                    }
                    catch { }
                    SetCustomerID();
                }
            }
            else
            {
                try
                {
                    // Edit

                    EditData();
                    state = true;
                    page.LoadData();


                    // Add new notification
                    note = new Note();
                    Page.Notifications notifications = new Page.Notifications();
                    var username = Properties.Settings.Default.UserFullName;
                    var Note = " تم تعديل مادة في المبعيات حالية من قبل " + username;
                    note.AddNote(Note, notifications, "تعديل");
                    LoadData();



                }
                catch { }
                SetCustomerID();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

                db = new DBEPSEntities();
                TB_SellData data = new TB_SellData();
                if (id != 0)
                {
                    var dilogeresult = MessageBox.Show("هل انت متأكد من هذا الاجراء , لا يمكن استرجاع البيانات ", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dilogeresult == DialogResult.Yes)
                    {
                        data = db.TB_SellData.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(data).State = EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();

                        // Add new notification
                        BL.Note note = new BL.Note();
                        Page.Notifications notifications = new Page.Notifications();
                        var username = Properties.Settings.Default.UserFullName;
                        var Note = " تم حذف مادة من المبيعات من قبل " + username;
                        note.AddNote(Note, notifications, "حذف");
                        Message("تم الحذف");

                        // SET FINAL VALUE
                        db = new DBEPSEntities();
                        var tbselldata = db.TB_Sell.Where(x => x.ID == SellID).FirstOrDefault();
                        var dataSell = db.TB_SellData.Where(x => x.IDSell == SellID).Select(x => x.SellAllValue).ToArray();
                        TotalSell = (double)dataSell.Sum();
                        var TotalBalnce1 = db.TB_SellData.Where(x => x.IDSell == SellID).Select(x => x.CustomerBalance).ToArray().Sum();
                        var TotalBalnce2 = db.TB_SellData.Where(x => x.IDSell == SellID).Select(x => x.CustomerBalanceprim).ToArray().Sum();
                        tbselldata.SellValue = TotalSell;
                        tbselldata.CustomerBalance = TotalBalnce1;
                        tbselldata.CustomerBalanceprim = TotalBalnce2;
                        db.Set<TB_Sell>().AddOrUpdate(tbselldata);
                        SetQuantityValue();
                        ReturnQuantity();
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
            SetCustomerID();

        }


        private void ReturnQuantity()
        {
            try
            {
                var Name = Convert.ToString(gridView1.GetFocusedRowCellValue("MatrialsName"));
                var quanity = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Quantity"));
                db = new DBEPSEntities();
                TB_Buy tB_Buy = new TB_Buy();
                tB_Buy = db.TB_Buy.Where(x => x.Name == Name).FirstOrDefault();
                tB_Buy.Quantity = tB_Buy.Quantity + quanity;
                db.Set<TB_Buy>().AddOrUpdate(tB_Buy);
                db.SaveChanges();



            }
            catch { }

        }

        private void ReturnQuantityForEdit()
        {
            try
            {
                var Name = Convert.ToString(gridView1.GetFocusedRowCellValue("MatrialsName"));
                var quanity = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Quantity"));
                db = new DBEPSEntities();
                TB_Buy tB_Buy = new TB_Buy();
                tB_Buy = db.TB_Buy.Where(x => x.Name == Name).FirstOrDefault();
                var editquanity = Convert.ToDouble(edt_quantity) - quanity;
                tB_Buy.Quantity = tB_Buy.Quantity + editquanity;
                db.Set<TB_Buy>().AddOrUpdate(tB_Buy);
                db.SaveChanges();



            }
            catch { }

        }
        private void edt_customerbalance_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_customerbalance.Text, "[^0-9]") || edt_customerbalance.Text == "")
            {
            }
        }

        private void Add_Sell_Load(object sender, EventArgs e)
        {
            LoadData();
            SetCustomerID();
            SetSellValue();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            SellPage page = new SellPage();

            page.btn_add_Click(sender, e);
            this.Close();



        }

        private void btn_changeconvertvalue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_Settings fRM_Settings = new FRM_Settings();
            fRM_Settings.Show();
        }

        private void SetQuantityValue()
        {
            try
            {
                db = new DBEPSEntities();
                TB_Buy buy = new TB_Buy();
                buy = db.TB_Buy.Where(x => x.ID == Buyid).FirstOrDefault();
                var quantity = buy.Quantity - Convert.ToDouble(edt_quantity.Text);
                buy.Quantity = quantity;
                db.Set<TB_Buy>().AddOrUpdate(buy);
                db.SaveChanges();
                txt_currentquantity.Text = quantity.ToString();
                if (quantity < 0)
                {
                    Message("انتبة الكمية في القيمة السالبة");
                }

            }
            catch { }
        }

        private void edt_cashbuyprimary_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void edt_cahbuysecondry_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void edt_creditbuyprimary_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void edt_creditbuysecondry_DoubleClick(object sender, EventArgs e)
        {

           
        }

        private void edt_creditbuysecondry_DpiChangedAfterParent(object sender, EventArgs e)
        {

        }

        private void edt_customerbalance_DoubleClick(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(edt_customerbalance.Text, "[^0-9]") || edt_customerbalance.Text == "")
            {
                MessageBox.Show("الرجاء ادخال قيمة رقمية");
                edt_customerbalance.Text = "0";
            }
            else
            {
              
            }
        }

        private void edt_customerbalanceprim_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void edt_payment1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void edt_payment2_DoubleClick(object sender, EventArgs e)
        {
          
        }
    }
}