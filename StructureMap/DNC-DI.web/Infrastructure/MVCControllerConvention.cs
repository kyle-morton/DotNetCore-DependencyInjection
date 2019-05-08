using Microsoft.AspNetCore.Mvc;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Graph.Scanning;
using StructureMap.Pipeline;
using StructureMap.TypeRules;
using System;
using System.Linq;

namespace DNC_DI.web.Infrastructure
{

    /// <summary>
    /// Setup w/ StructureMap that allows dependencies for a MVC Controller to be injected
    /// </summary>
    public class MVCControllerConvention : IRegistrationConvention
    {
        public void Process(Type type, Registry registry)
        {
            if (type.CanBeCastTo<Controller>() && !type.IsAbstract)
            {
                registry.For(type).LifecycleIs(new UniquePerRequestLifecycle());
            }
        }

        public void ScanTypes(TypeSet types, Registry registry)
        {
            foreach (var type in types.AllTypes().Where(type => type.CanBeCastTo<Controller>() && !type.IsAbstract))
            {
                registry.For(type).LifecycleIs(new UniquePerRequestLifecycle());
            }
        }
    }
}
