using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;

namespace EPS.Report
{
    public partial class SellReportAction : DevExpress.XtraReports.UI.XtraReport
    {
        DBEPSEntities db;
        TB_Sell Sell;
        TB_SellData data;
        int idsell;
        public SellReportAction()
        {
            InitializeComponent();
            LoadData();
            LoadDataForReport();
           SetCompanyDetails();
        }


        private void LoadDataForReport()
        {
            idsell = Properties.Settings.Default.IDSell;
            try
            {
                db = new DBEPSEntities();
                data = new TB_SellData();
                Sell = db.TB_Sell.Where(x => x.ID == idsell).FirstOrDefault();
                if (Sell != null)
                {
                    txt_sellid.Text = Sell.ID.ToString();
                    txt_customarname.Text = Sell.CustomerName.ToString();


                }
            }
            catch { }
        }
            private void LoadData()
            {
            idsell = Properties.Settings.Default.IDSell;
            try
            {
                data = new TB_SellData();
                db = new DBEPSEntities();

                var data1 = db.TB_SellData.Where(x => x.IDSell == idsell).Select(x => new { x.MatrialsName, x.Quantity, x.SellState, x.SellValue, x.SellAllValue }).ToList();              
                    gridControl1.DataSource = data1;
                var TotalPrice = db.TB_SellData.Where(x => x.IDSell == idsell).Select(X => X.SellAllValue).ToArray().Sum();
                var TotalPrice2 = db.TB_Sell.Where(x => x.ID == idsell).Select(X => X.CustomerBalance).ToArray().Sum();
                txt_totlaprice.Text = TotalPrice.ToString();
                txt_cridet.Text = TotalPrice2.ToString();

            }
            catch
            { 
                
            }
            }


            private void SetCompanyDetails()
        {

            txt_companyname.Text = Properties.Settings.Default.CompanyName;
            txt_companydescription.Text = Properties.Settings.Default.CompanyDes;
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
            catch { }
           
            

        }

    }

    
}
