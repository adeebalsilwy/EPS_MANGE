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
using DevExpress.XtraReports.UI;

namespace EPS.Page
{
    public partial class Notifications : DevExpress.XtraEditors.XtraUserControl
    {
        DBEPSEntities db;
        TB_Note add;
        int id;
        public Notifications()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            db = new DBEPSEntities();
            try
            {
                EPS.DBEPSEntities dbContext = new EPS.DBEPSEntities();
                dbContext.TB_Note.LoadAsync().ContinueWith(loadTask =>
                {
                    gridControl1.DataSource = dbContext.TB_Note.Local.ToBindingList();
                }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch { }
            var data = db.TB_Note.ToList();
            if (data.Count<=0)
            {
                lb_state.Visible = true;
            }
            else
            {
                lb_state.Visible = false;
            }

        }

        private void tileView1_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            try
            {
                db = new DBEPSEntities();
                add = new TB_Note();
                id = Convert.ToInt16(tileView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {

                    add = db.TB_Note.Where(x => x.ID == id).FirstOrDefault();
                    db.Entry(add).State = EntityState.Deleted;
                    db.SaveChanges();
                    LoadData();


                }

            }
            catch { }
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            try
            {
                db = new DBEPSEntities();
               var rs= MessageBox.Show("سيتم حذف كافة الاشعارات , هل تريد المتابعة", "اجراء حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    db.TB_Note.RemoveRange(db.TB_Note);
                    db.SaveChanges();
                    LoadData();

                }
            }
            catch { }
        }

        public void LoadCategory()
        {
            try
            {
                db = new DBEPSEntities(); 
                var NoteListCategory = db.TB_Note.Select(x => x.NoteType).ToList();
                combo_filter.DataSource = NoteListCategory;

            }
            catch { }
        }

        private void combo_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

            EPS.DBEPSEntities dbContext = new EPS.DBEPSEntities();
            dbContext.TB_Note.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.TB_Note.Local.Where(x=>x.NoteType==combo_filter.SelectedItem.ToString()).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadData();

        }

        private void gridControl1_MouseLeave(object sender, EventArgs e)
        {
            FRM_Main main = new FRM_Main();
            main.CloseNotification();
        }

        private void btn_showlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Report.SystemLogs report = new Report.SystemLogs();

                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreview();
            }
            catch { MessageBox.Show("خطأ غير متوقع"); }
        }
    }
}
