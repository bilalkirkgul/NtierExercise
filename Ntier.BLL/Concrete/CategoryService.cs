using Ntier.BLL.Abstract;
using Ntier.DAL.Abstract;
using Ntier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.BLL.Concrete
{
    class CategoryService : ICategoryBLL
    {

        ICategoryDAL categoryDAL;
        public CategoryService(ICategoryDAL dal)
        {
            categoryDAL = dal;
        }

        public void Insert(Category entity)
        {
            categoryDAL.Insert(entity);
        }

        public void Update(Category entity)
        {
            categoryDAL.Update(entity);
        }
        public void Delete(Category entity)
        {
            entity.IsActive = false;
            categoryDAL.Update(entity);
        }

        public void DeleteById(int entityId)
        {
            Category category = Get(entityId);
            category.IsActive = false;
            categoryDAL.Update(category);
        }

        public Category Get(int entityId)
        {
            return categoryDAL.GetEntity(a => a.ID == entityId);
        }

        public ICollection<Category> GetAll()
        {
            return categoryDAL.GetAll();
        }

       
    }
}
