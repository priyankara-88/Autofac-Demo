using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Autofac_Demo
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>(); 
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>(); // Individual mapping

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary))) // Mapping  logic for a bunch in once by using a pattern
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
