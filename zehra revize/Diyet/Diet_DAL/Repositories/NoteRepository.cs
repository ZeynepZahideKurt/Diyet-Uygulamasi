using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_DAL.Repositories
{
    public class NoteRepository
    {
        AppDbContext dbContext;
        public NoteRepository()
        {
            dbContext = new AppDbContext();
        }
        public bool Insert(Note note)
        {
            dbContext.Notes.Add(note);
            return dbContext.SaveChanges() > 0;
        }
        public bool Update(Note note)
        {
            Note updateNote = dbContext.Notes.Where(a => a.ID == note.ID).FirstOrDefault();
            updateNote.Text = note.Text;
            updateNote.Head = note.Head;
            return dbContext.SaveChanges() > 0;
        }

        public bool Delete(Note note)
        {
            Note deleteNote = dbContext.Notes.Where(a => a.ID == note.ID).FirstOrDefault();
            dbContext.Notes.Remove(deleteNote);
            return dbContext.SaveChanges() > 0;
        }

        public List<Note> GetByUserId(int userId)
        {
            return dbContext.Notes.Where(a => a.UserID == userId).ToList();
        }

        public Note GetNoteById(int noteId)
        {
            return dbContext.Notes.Where(a => a.ID == noteId).FirstOrDefault();
        }


    }
}
