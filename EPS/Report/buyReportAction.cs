using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EPS.Report
{
    public partial class buyReportAction : DevExpress.XtraReports.UI.XtraReport
    {
        DBEPSEntities db;
        TB_Buy Sell;
        int ID;
        DateTime StartDate1;
        DateTime EndDate;

        public buyReportAction( int ID, DateTime StartDate, DateTime EndDate)
        {
            
            InitializeComponent();
            this.ID = ID;
            this.StartDate1 = StartDate;
            this.EndDate = EndDate;
            
            LoadData();
            LoadDataForReport();
           SetCompanyDetails();
            SetCurrncyValue();
        }

        private void SetCurrncyValue()
        {
            var primarycurrname = Properties.Settings.Default.PrimaryCurrName;
            var secondrycurrname = Properties.Settings.Default.SecondryCurrName;
            gridView1.Columns["SupplierPyment"].Caption = "الديون- " + primarycurrname;
            gridView1.Columns["SupplierPyment1"].Caption = "الديون- " +secondrycurrname;


        }
        private void LoadDataForReport()
        {
            try
            {
                db = new DBEPSEntities();
                Sell = db.TB_Buy.Where(x => x.ID_Supplier == ID&&
                  DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year, StartDate1.Month, StartDate1.Day, 1, 1, 1)
               && DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1)
                ).FirstOrDefault();
                if (Sell != null)
                {
                    txt_customarname.Text = Sell.Supplier.ToString();
                    txt_cridet.Text = db.TB_Buy.Where(x => x.ID_Supplier == ID &&
                  DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year, StartDate1.Month, StartDate1.Day, 1, 1, 1)
                && DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1)).Select(x => x.SupplierPyment).ToArray().Sum().ToString();
                    txt_secodcurr.Text = db.TB_Buy.Where(x => x.ID_Supplier == ID &&
  DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year, StartDate1.Month, StartDate1.Day, 1, 1, 1)
               && DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1)).Select(x => x.SupplierPyment1).ToArray().Sum().ToString();


                }
            }
            catch { }
        }
            private void LoadData()
            {
            
           
            try
            {
                db = new DBEPSEntities();
                var data1 = db.TB_Buy.Where(x => x.ID_Supplier == ID &&
                DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year,StartDate1.Month,StartDate1.Day,1,1,1)
               && DbFunctions.CreateDateTime(x.DateAdd.Value.Year, x.DateAdd.Value.Month, x.DateAdd.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1))
 
                    .Select(x => new { x.Name, x.Category, x.Supplier, x.SupplierPyment,x.SupplierPyment1,x.DateAdd}).ToList();              
                    gridControl1.DataSource = data1;
                }
                catch
            { 
                
            }
            }


            private void SetCompanyDetails()
        {
            txt_companyname.Text = Properties.Settings.Default.CompanyName;
            txt_companydescription.Text = Properties.Settings.Default.CompanyDes;
            txt_currancy.Text = Properties.Settings.Default.PrimaryCurrName;
            d.Text = Properties.Settings.Default.SecondryCurrName;
            // Set picture after set it from settings
            try
            {
                byte[] imgebyte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);

                if (imgebyte != null)
                {
                    MemoryStream ma = new MemoryStream(imgebyte);


                    pic_company.Image = Image.FromStream(ma);
                }
               
            }
            catch
            {

            }
           

        }

        private void buyReportAction_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {
           
        }
    }

    
}
