using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    public class MotivationNoteRepository
    {
        AppDbContext dbContext;

        public MotivationNoteRepository()
        {
            dbContext = new AppDbContext();
        }

        public bool Insert(MotivationNote motivationNote)
        {
            MotivationNote motivationNote1 = dbContext.MotivationNotes.Add(motivationNote);
            return dbContext.SaveChanges() > 0;
        }
        public bool Update(MotivationNote motivationNote)
        {
            MotivationNote updateNote = dbContext.MotivationNotes.FirstOrDefault();
            updateNote.Text = motivationNote.Text;
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(MotivationNote motivationNote)
        {
            MotivationNote deleteNote = dbContext.MotivationNotes.FirstOrDefault();
            dbContext.MotivationNotes.Remove(motivationNote);
            return dbContext.SaveChanges() > 0;
        }

        public MotivationNote GetMotivationById(int motivationId)
        {
            return dbContext.MotivationNotes.Where(a=>a.ID==motivationId).FirstOrDefault();
        }

        public List<MotivationNote> GetAllList()
        {
            return dbContext.MotivationNotes.ToList();
        }

    }
}
