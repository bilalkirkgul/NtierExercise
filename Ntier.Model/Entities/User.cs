using Ntier.Core.Entity;
using Ntier.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.Model.Entities
{
   public class User:BaseEntity,IEntity
    {
        public User()
        {
            IsActive = true;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public KullaniciRole KullanıcıRole { get; set; }
        public ICollection<Note> Notes { get; set; }

    }
}
