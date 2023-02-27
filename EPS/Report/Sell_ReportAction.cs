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
    public partial class Sell_ReportAction : DevExpress.XtraReports.UI.XtraReport
    {
        DBEPSEntities db;
        TB_Sell Sell;
        int ID;
        DateTime StartDate1;
        DateTime EndDate;

        public Sell_ReportAction(int ID, DateTime StartDate, DateTime EndDate)
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
            gridView1.Columns["CustomerBalance"].Caption = "الديون- " + primarycurrname;
            gridView1.Columns["CustomerBalanceprim"].Caption = "الديون- " + secondrycurrname;
            gridView1.Columns["SellValue"].Caption = "الاجمالي - "+primarycurrname;


        }
        private void LoadDataForReport()
        {
            try
            {
                db = new DBEPSEntities();
                Sell = db.TB_Sell.Where(x => x.IDCustomer == ID&&
                  DbFunctions.CreateDateTime(x.Date.Value.Year, x.Date.Value.Month, x.Date.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year, StartDate1.Month, StartDate1.Day, 1, 1, 1)
               && DbFunctions.CreateDateTime(x.Date.Value.Year, x.Date.Value.Month, x.Date.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1)
                ).FirstOrDefault();
                if (Sell != null)
                {
                    txt_customarname.Text = Sell.CustomerName.ToString();
                    txt_cridet.Text = db.TB_Sell.Where(x => x.IDCustomer == ID &&
                  DbFunctions.CreateDateTime(x.Date.Value.Year, x.Date.Value.Month, x.Date.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year, StartDate1.Month, StartDate1.Day, 1, 1, 1)
                && DbFunctions.CreateDateTime(x.Date.Value.Year, x.Date.Value.Month, x.Date.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1)).Select(x => x.CustomerBalance).ToArray().Sum().ToString();
                    txt_secodcurr.Text = db.TB_Sell.Where(x => x.IDCustomer == ID &&
              DbFunctions.CreateDateTime(x.Date.Value.Year, x.Date.Value.Month, x.Date.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year, StartDate1.Month, StartDate1.Day, 1, 1, 1)
               && DbFunctions.CreateDateTime(x.Date.Value.Year, x.Date.Value.Month, x.Date.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1)).Select(x => x.CustomerBalanceprim).ToArray().Sum().ToString();


                }
            }
            catch { }
        }
            private void LoadData()
            {
            
           
            try
            {
                db = new DBEPSEntities();
                var data1 = db.TB_Sell.Where(x => x.IDCustomer == ID &&
                DbFunctions.CreateDateTime(x.Date.Value.Year, x.Date.Value.Month, x.Date.Value.Day, 5, 5, 5) >= DbFunctions.CreateDateTime(StartDate1.Year,StartDate1.Month,StartDate1.Day,1,1,1)
               && DbFunctions.CreateDateTime(x.Date.Value.Year, x.Date.Value.Month, x.Date.Value.Day, 5, 5, 5) <= DbFunctions.CreateDateTime(EndDate.Year, EndDate.Month, EndDate.Day, 1, 1, 1))
 
                    .Select(x => new { x.ID, x.CustomerBalance, x.CustomerBalanceprim, x.SellValue,x.Date}).ToList();              
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
