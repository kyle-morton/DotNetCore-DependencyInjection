using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DNC_DI.app.Infrastructure
{
    public class Boostrapper
    {
        public void Run()
        {
            var services = new ServiceCollection();

            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetExecutingAssembly())
                .Where(c => c.Name.EndsWith("Repository") || c.Name.EndsWith("Handler"))
                .AsPublicImplementedInterfaces();

            services.BuildServiceProvider();
        }
    }
}
