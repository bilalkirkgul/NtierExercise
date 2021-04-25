using Ntier.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.Model.Entities
{
    class User:BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public KullaniciRole KullanıcıRole { get; set; }

    }
}
