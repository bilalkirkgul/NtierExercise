using Microsoft.Extensions.DependencyInjection;
using Ntier.DAL.Abstract;
using Ntier.DAL.Concrete.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.DAL.Concrete.DependencyInjection
{
  public static  class EFContextDAL
    {
        public static void AddScopeDAL(this IServiceCollection services)
        {
            services.AddScoped<ICategoryDAL, CategoryRepository>();
            services.AddScoped<INoteDAL, NoteRepository>();
            services.AddScoped<IUserDAL, UserRepository>();
        }

    }
}
