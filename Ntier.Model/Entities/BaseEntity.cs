using Ntier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.Model.Entities
{
   abstract class BaseEntity:IEntity
    {
        public BaseEntity()
        {
            DateOfRegistration = DateTime.Now;
        }
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfRegistration { get; set; }
        


    }
}
