using Ntier.Core.DataAccess.EntityFramework;
using Ntier.DAL.Abstract;
using Ntier.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.DAL.Concrete.Repository
{

    class UserRepository:EFRepositoryBase<User,NtierExerciseDbContext>,IUserDAL
    {
    }
}
