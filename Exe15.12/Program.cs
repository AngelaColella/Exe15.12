using Exe.Core;
using Exe.Help;
using System;

namespace Exe15._12
{
    static class Program
    {
        static void Main(string[] args)
        {
            #region DependencyInjection
            //var serviceProvider = ConfigDI.ConfigDI();
            //BusinessLayer layer = serviceProvider.GetService<BusinessLayer>(); 
            #endregion

            // Chiedere il nome di un database server, il nome del database, uno username e la password da linea di comando
            string dbServer = GetData("database server");
            string dbName = GetData("database name");
            string username = GetData("username");
            string password = GetData("password");

            #region Connection string da Azure
            // Server=tcp:academy-azuresql.database.windows.net,1433;
            // Initial Catalog=academy-exe-db;Persist Security Info=False;
            // User ID=AngelaColella; Password={your_password};
            // MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False; 
            // Connection Timeout=30; 
            #endregion


            // Comporre la stringa di connessione del database usando i dati precedenti 
            Config.connectionString = Config.ComposeConnectionString(dbServer, dbName, username, password);
            
            // Mostrarla a video
            Console.WriteLine("This is your connection string: " + Config.connectionString);

            // Richiesta dati del primo prodotto all'utente e inserimento 
            Product product = new Product();
            product.Code = GetData("Product code");
            product.Name = GetData("Product name");
            product.Description = GetData("Product description");
            product.Price = System.Convert.ToInt32(GetData("Product price"));

            // Richiesta dati del secondo prodotto all'utente e inserimento 
            Product product2 = new Product();
            product2.Code = GetData("Product code");
            product2.Name = GetData("Product name");
            product2.Description = GetData("Product description");
            product2.Price = System.Convert.ToInt32(GetData("Product price"));

        }


        private static string GetData(string message)
        {
            Console.Write("Type the " + message + ": ");
            var value = Console.ReadLine();
            return value;
        }


    }
}
