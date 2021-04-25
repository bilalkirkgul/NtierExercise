using Ntier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.Model.Entities
{
  public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        


    }
}
