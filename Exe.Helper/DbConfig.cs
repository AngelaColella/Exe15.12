using Exe.Core;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Exe.Helper
{
    public static class DbConfig
    {
        public static string connectionString { get; set; }
        public static string ComposeConnectionString(string dbServer, string dbName, string username, string password)
        {
            string connString = $"Server=tcp:{dbServer}.database.windows.net,1433;Initial Catalog={dbName};" +
                        $"Persist Security Info=False;User ID={username}; Password={password};" +
                        "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return connString;
        }
        public static ServiceProvider ConfigDI()
        {
            return new ServiceCollection()
                .AddTransient<BusinessLayer>()
                .AddTransient<IRepository<Product>, ProductRepository>()
                .BuildServiceProvider();
        }

    }

}
