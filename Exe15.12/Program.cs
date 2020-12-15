using System;

namespace Exe15._12
{
    class Program
    {
        static void Main(string[] args)
        {
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
            string connectionString = ComposeConnectionString(dbServer, dbName, username, password);
            // Mostrarla a video
            Console.WriteLine("This is your connection string: " + connectionString);
        }

        private static string ComposeConnectionString(string dbServer, string dbName, string username, string password)
        {
            string connString = $"Server=tcp:{dbServer}.database.windows.net,1433;Initial Catalog={dbName};" +
                        $"Persist Security Info=False;User ID={username}; Password={password};" +
                        "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return connString;
        }

        private static string GetData(string message)
        {
            Console.Write("Type the " + message + ": ");
            var value = Console.ReadLine();
            return value;
        }


    }
}
