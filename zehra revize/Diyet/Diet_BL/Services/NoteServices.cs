using Diet_DAL.Repositories;
using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_BL.Services
{
    public class NoteServices
    {
        NoteRepository noterepository;
        public NoteServices()
        {
            noterepository= new NoteRepository();

        }
        void CheckNoteId(int noteId)
        {
            if (noteId < 0) throw new Exception("Parametre degeri uygun degildir");
        }

        public Note GetNoteById(int noteId)
        {
            Note note = new Note();
            CheckNoteId(noteId);
            note = noterepository.GetNoteById(noteId);
            return note;
        }
        public List<Note> GetById(int userId)
        {
            List<Note> notes = new List<Note>();
            if (userId > 0)
            {
                notes = noterepository.GetByUserId(userId);
            }
            else throw new Exception("Parametre degeri uygun degildir");
            return notes;
        }
        void CheckContentTitle(Note note)
        {
            if (string.IsNullOrEmpty(note.Head) || string.IsNullOrEmpty(note.Text)) throw new Exception("Başlık veya İçerik boş geçilemez");
        }
        public bool Insert(Note note)
        {
            CheckContentTitle(note);
            return noterepository.Insert(note);
        }
        public bool Update(Note note)
        {
            CheckContentTitle(note);
            CheckNoteId(note.ID);
            return noterepository.Update(note);
        }
        public bool Delete(int noteId)
        {
            CheckNoteId(noteId);
            Note note = noterepository.GetNoteById(noteId);
            return noterepository.Delete(note);
        }
        public bool Delete(Note note)
        {
            CheckNoteId(note.ID);
            return noterepository.Delete(note);
        }
    }
}
