using Ntier.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.Model.Entities
{
    public class Note:BaseEntity,IEntity
    {
        public Note()
        {
            IsActive = true;
        }
        public string WorkSubject { get; set; }
        public string Description { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime WorkTime { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public User User { get; set; }
        public int UserID { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }

    }
}
