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
using System.IO;
namespace EPS
{
    public partial class FRM_Settings : DevExpress.XtraEditors.XtraForm
    {
        MemoryStream ma;
        DBEPSEntities db;
        public FRM_Settings()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage1;
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage2;

        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage3;

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navigationPage4;

        }

        private void navigationPage4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_currencysave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrimaryCurrName = comb_primarycur.Text.ToString();
            Properties.Settings.Default.SecondryCurrName = comb_secondrycurr.Text.ToString();
            Properties.Settings.Default.CurrConvertValue =Convert.ToDouble( edt_convertcurr.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الاعدادات");
        }

        private void FRM_Settings_Activated(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            try
            {
                byte[] Imagebyte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
                if (Imagebyte != null)
                {
                    ma = new MemoryStream(Imagebyte);
                    pic_logo.Image = Image.FromStream(ma);
                }
            }
            catch { }
            edt_compnayname.Text = Properties.Settings.Default.CompanyName.ToString();
            edt_companydesc.Text = Properties.Settings.Default.CompanyDes.ToString();
            comb_primarycur.Text = Properties.Settings.Default.PrimaryCurrName.ToString();
            comb_secondrycurr.Text = Properties.Settings.Default.SecondryCurrName.ToString();
            edt_convertcurr.Text = Properties.Settings.Default.CurrConvertValue.ToString();

            
           

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.CompanyName = edt_compnayname.Text;
                Properties.Settings.Default.CompanyDes = edt_companydesc.Text;
                ma = new MemoryStream();
                pic_logo.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ma.ToArray());
                Properties.Settings.Default.Save();
                MessageBox.Show("تم حفظ الاعدادات");
            }
            catch { }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("النسخة الحالية لا تدعم الاتصال الشبكي");
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    db = new DBEPSEntities();

                    string dbname = db.Database.Connection.Database;
                    string dbBackUp = "EPSback" + DateTime.Now.ToString("yyyyMMddHHmm");
                    var fullpath = folder.SelectedPath.ToString() + dbBackUp + ".bak";
                    string sqlCommand = @"BACKUP DATABASE [{0}] TO  DISK = '" + fullpath + "' WITH NOFORMAT, NOINIT,  NAME = N'DBEPS', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, dbBackUp));
                    MessageBox.Show("تم النسخ الاحتياطي بنجاح");
                }
            }
            catch
            {
                MessageBox.Show("خطأ , لا يمكن النسخ الاحتياطي الى المسار المحدد, الرجاء تحديد مسار مختلف, تذكر لا تحدد القرص C");
            }
           

           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog folder = new OpenFileDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    db = new DBEPSEntities();

                    string dbname = db.Database.Connection.Database;
                    string dbBackUp = "EPSback" + DateTime.Now.ToString("yyyyMMddHHmm");
                    string sqlCommand = @"Use master;Restore DATABASE [{0}] From  DISK = '" + folder.FileName + "'";
                    int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname));
                    MessageBox.Show("تم استعادة النسخة الاحتياطية بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن استعادة النسخة الاحتياطية, يرجى التأكد من الملف المختار"+ex.Message.ToString());
            }
        }
    }
}