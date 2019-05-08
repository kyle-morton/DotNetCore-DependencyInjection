using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DNC_DI.web.Infrastructure
{
    public static class IocContainer
    {

        /// <summary>
        /// Registers the assemblies to scan & mediatR w/ Structure Map DI container
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceProvider ConfigureIOC(IServiceCollection services)
        {
            var container = new Container();

            container.Configure(config =>
            {
                config.Scan(c =>
                {
                    c.Assembly(Assembly.Load("DNC-DI.data"));
                    c.Assembly(Assembly.Load("DNC-DI.logic"));
                    c.TheCallingAssembly();
                    c.ConnectImplementationsToTypesClosing(typeof(IRequestHandler<,>));
                    c.ConnectImplementationsToTypesClosing(typeof(INotificationHandler<>));
                    c.With(new MVCControllerConvention());
                    c.WithDefaultConventions();
                });

                // MediatR Configuration 

                //Pipeline
                config.For(typeof(IPipelineBehavior<,>)).Add(typeof(RequestPreProcessorBehavior<,>));
                config.For(typeof(IPipelineBehavior<,>)).Add(typeof(RequestPostProcessorBehavior<,>));

                // This is the default but let's be explicit. At most we should be container scoped.
                config.For<IMediator>().LifecycleIs<TransientLifecycle>().Use<Mediator>();

                config.Populate(services);

            });

            return container.GetInstance<IServiceProvider>();
        }

    }
}
