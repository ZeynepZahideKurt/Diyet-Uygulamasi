using Diet_DAL.Repositories;
using Diet_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet_BL.Services
{
    public class MotivationNoteServices
    {
        //MotivationNoteRepository motivationNote;
        //public MotivationNoteServices()
        //{
        //    motivationNote= new MotivationNoteRepository();
        //}

        //public bool Insert(Note note)
        //{

        //    MotivationNotes(note);
        //    return noterepository.Insert(note);
        //}
        //public bool Update(Note note)
        //{
        //    CheckContentTitle(note);
        //    CheckNoteId(note.ID);
        //    return noterepository.Update(note);
        //}
        //public bool Delete(int noteId)
        //{
        //    CheckNoteId(noteId);
        //    Note note = noterepository.GetNoteById(noteId);
        //    return noterepository.Delete(note);
        //}

        MotivationNoteRepository motivationNoteRepository;

        public MotivationNoteServices()
        {
            motivationNoteRepository = new MotivationNoteRepository();
        }

        void CheckMotivationNoteId(int motivationNoteId)
        {
            if (motivationNoteId < 0) throw new Exception("Parametre degeri uygun degildir");
        }

        public MotivationNote GetMotivationById(int motivationNoteId)
        {
            MotivationNote motivationNote = new MotivationNote();
            CheckMotivationNoteId(motivationNoteId);
            motivationNote = motivationNoteRepository.GetMotivationById(motivationNoteId);
            return motivationNote;
        }
        public List<MotivationNote> GetList()
        {
            List<MotivationNote> Mnote = new List<MotivationNote>();
            Mnote = motivationNoteRepository.GetAllList();
            return Mnote;
        }

        void CheckContent(MotivationNote motivationNote)
        {
            if (string.IsNullOrEmpty(motivationNote.Text)) throw new Exception("İçerik boş geçilemez");
        }
        public bool Insert(MotivationNote motivationNote)
        {
            CheckContent(motivationNote);
            return motivationNoteRepository.Insert(motivationNote);
        }
        public bool Update(MotivationNote motivationNote)
        {
            CheckContent(motivationNote);
            CheckMotivationNoteId(motivationNote.ID);
            return motivationNoteRepository.Update(motivationNote);
        }
        public bool Delete(int motivationNoteId)
        {
            CheckMotivationNoteId(motivationNoteId);
            MotivationNote motivationNote = motivationNoteRepository.GetMotivationById(motivationNoteId);
            return motivationNoteRepository.Delete(motivationNote);
        }
        
    }

}
