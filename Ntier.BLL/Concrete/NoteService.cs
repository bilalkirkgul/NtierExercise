using Ntier.BLL.Abstract;
using Ntier.DAL.Abstract;
using Ntier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.BLL.Concrete
{
    class NoteService : INoteBLL
    {
        INoteDAL noteDAL;
        public NoteService(INoteDAL dal)
        {
            noteDAL = dal;
        }
        public void Insert(Note entity)
        {
            noteDAL.Insert(entity);
        }

        public void Update(Note entity)
        {
            noteDAL.Update(entity);
        }
        public void Delete(Note entity)
        {
            entity.IsActive = false;
            noteDAL.Update(entity);
        }
        public Note Get(int entityId)
        {
            return noteDAL.GetEntity(a => a.ID == entityId);
        }

        public void DeleteById(int entityId)
        {
            Note note = Get(entityId);
            note.IsActive = false;
            noteDAL.Update(note);
        }

       

        public ICollection<Note> GetAll()
        {
            return noteDAL.GetAll();
        }

     
    }
}
