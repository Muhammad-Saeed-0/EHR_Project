﻿using EHR_MVC.Repositories.Contracts;
using EHR_MVC.Repositories.Implementation;

namespace EHR_API.Extensions
{
    public static class ServiceExtensions
    {
        
        public static void ConfigureInterfaces(this IServiceCollection services)
        {
            services.AddHttpClient<IGovernorateService, GovernorateService>();
            services.AddScoped<IGovernorateService, GovernorateService>();
        }

    }
}
