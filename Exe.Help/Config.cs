
using System;

namespace Exe.Help
{
    public static class Config
    {
        public static string connectionString { get; set; }
        public static string ComposeConnectionString(string dbServer, string dbName, string username, string password)
        {
            string connString = $"Server=tcp:{dbServer}.database.windows.net,1433;Initial Catalog={dbName};" +
                        $"Persist Security Info=False;User ID={username}; Password={password};" +
                        "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return connString;
        }

    }

}
