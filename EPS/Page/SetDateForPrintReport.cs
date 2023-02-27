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
    public partial class SetDateForPrintReport : DevExpress.XtraEditors.XtraForm
    {
        public int ID;


        public string ReportName;
        DateTime date1, date2;
        public SetDateForPrintReport()
        {
            InitializeComponent();
        }


      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            
            if (ReportName == "الموردين")
            {

                if (radioButton1.Checked == true)
                {
                    date1 = dateTimePicker1.Value.Subtract(TimeSpan.FromDays(30));
                    date2 = dateTimePicker2.Value.AddDays(1);
                    Report.buyReportAction report = new Report.buyReportAction(ID,date1, date2);

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                    Close();

                }
                else
                {
                    date1 = dateTimePicker1.Value;
                    date2 = dateTimePicker2.Value.AddDays(1);
                    Report.buyReportAction report = new Report.buyReportAction(ID, date1, date2);
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                    Close();
                }
                

            }

            if (ReportName == "العملاء")
            {

                if (radioButton1.Checked == true)
                {
                    date1 = dateTimePicker1.Value.Subtract(TimeSpan.FromDays(30));
                    date2 = dateTimePicker2.Value.AddDays(1);
                    Report.Sell_ReportAction report = new Report.Sell_ReportAction(ID, date1, date2);

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                    Close();

                }
                else
                {
                    date1 = dateTimePicker1.Value;
                    date2 = dateTimePicker2.Value.AddDays(1);
                    Report.Sell_ReportAction report = new Report.Sell_ReportAction(ID, date1, date2);
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreview();
                    Close();
                }


            }
        }
    }
}