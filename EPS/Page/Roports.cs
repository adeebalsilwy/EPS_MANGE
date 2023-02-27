using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPS.Page
{
    public partial class Roports : DevExpress.XtraEditors.XtraUserControl
    {
        public Roports()
        {
            InitializeComponent();
        }

        private void btn_add_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button == btn_add.Buttons[0])
            {
                try
                {
                    Report.SellReport report = new Report.SellReport();

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }

            }
            if (e.Button == btn_add.Buttons[2])
            {
                try
                {
                    Report.buyReport report = new Report.buyReport();

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }

            }
            if (e.Button == btn_add.Buttons[4])
            {
                try
                {
                    Report.SystemLogs report = new Report.SystemLogs();

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }

            }
            if (e.Button == btn_add.Buttons[6])
            {
                try
                {
                    Report.Reportsuppliers report = new Report.Reportsuppliers();

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }             
            }

            if (e.Button == btn_add.Buttons[8])
            {
                try
                {
                    Report.ReportCustomer report = new Report.ReportCustomer();

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                }
                catch { MessageBox.Show("خطأ غير متوقع"); }
            }
        }
    }
}
