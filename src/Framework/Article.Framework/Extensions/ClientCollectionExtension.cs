using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Framework.Extensions
{
    public static class ClientCollectionExtension
    {
        public static IServiceCollection AddUnititiClientFramework(this IServiceCollection services, IConfiguration configuration)
        {


            return services;
        }
    }
}
