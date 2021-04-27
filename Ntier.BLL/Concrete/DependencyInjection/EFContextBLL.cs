using Microsoft.Extensions.DependencyInjection;
using Ntier.BLL.Abstract;
using Ntier.DAL.Concrete.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier.BLL.Concrete.DependencyInjection
{
    public static class EFContextBLL
    {


        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScopeDAL();
            services.AddScoped<ICategoryBLL, CategoryService>();
            services.AddScoped<INoteBLL, NoteService>();
            services.AddScoped<IUserBLL, UserService>();
        }

    }
}
