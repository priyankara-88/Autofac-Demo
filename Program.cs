using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofac_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure(); // Configures container

            using(var scope = container.BeginLifetimeScope()) // Creating a new scope for life time
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadKey();
        }
    }
}
