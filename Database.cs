using Microsoft.Data.Sqlite;

namespace BuzzLock
{
    public static class Database
    {
        private static readonly string connectionString = "Data Source=BuzzLock.db";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }

        public static void Initialize()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                // Create Vault table
                string createVaultTable = @"
                    CREATE TABLE IF NOT EXISTS Vault (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserId INTEGER NOT NULL,
                        Account TEXT NOT NULL,
                        Username TEXT NOT NULL,
                        EncryptedPassword TEXT NOT NULL
                    );
                ";

                // Create Users table (for login & registration)
                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL
                    );
                ";

                using (var cmd = new SqliteCommand(createVaultTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SqliteCommand(createUsersTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
