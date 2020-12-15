using Exe.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exe15._12
{
    public class ConfigDI
    {
        public static ServiceProvider ConfigDI()
        {
            return new ServiceCollection()
                .AddTransient<BusinessLayer>()
               
                .AddTransient<IRepository<Product>, ProductRepository>()

                .BuildServiceProvider();
        }
    }
}
}
