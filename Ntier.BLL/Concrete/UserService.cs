using Ntier.BLL.Abstract;
using Ntier.DAL.Abstract;
using Ntier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.BLL.Concrete
{
    class UserService : IUserBLL
    {
        IUserDAL userDAL;
        public UserService(IUserDAL dal)
        {
            userDAL = dal;
        }


        public void Insert(User entity)
        {
            userDAL.Insert(entity);
        }

        public void Update(User entity)
        {
            userDAL.Update(entity);
        }
        public void Delete(User entity)
        {
            entity.IsActive = false;
            userDAL.Update(entity);
        }
        public User Get(int entityId)
        {
            return userDAL.GetEntity(a => a.ID == entityId);
        }
        public void DeleteById(int entityId)
        {
            User user = Get(entityId);
            user.IsActive = false;
            userDAL.Update(user);
        }

       

        public ICollection<User> GetAll()
        {
            return userDAL.GetAll();
        }

       
    }
}
