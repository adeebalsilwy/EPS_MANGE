using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPS.BL
{
   public class Note
    {
        DBEPSEntities db;
      
        public void AddNote(string Description, Page.Notifications control,string Type)
        {
            try
            {
                var FullName = Properties.Settings.Default.UserFullName;
                db = new DBEPSEntities();                
                TB_Note note = new TB_Note
                
                {
                    NoteDes = Description,
                    NoteUser = FullName,
                    NoteDate = DateTime.Now,
                    NoteType=Type
                };
                TB_SystemLogs Log = new TB_SystemLogs
                {
                    LogDes = Description,
                    LogDate = DateTime.Now
                };
                db.Entry(note).State = System.Data.Entity.EntityState.Added;
                db.Entry(Log).State = System.Data.Entity.EntityState.Added;

                db.SaveChanges();
                // update notifications
                control.LoadData();

            }
            catch
            {

            }
        }
    }
}
