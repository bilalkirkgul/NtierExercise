using Ntier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.Model.Entities
{
    public class Category:BaseEntity,IEntity
    {
        public Category()
        {
            IsActive = true;
        }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}
