using Microsoft.Extensions.DependencyInjection;
using Service.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Data
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDal(this IServiceCollection services)
        {
            services.AddSingleton<IWebsiteInfoDal, WebsiteInfoDal>();

            return services;
        }
    }
}
