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
                string createTable = @"
                    CREATE TABLE IF NOT EXISTS Vault (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Account TEXT NOT NULL,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Algorithm TEXT
                    );
                ";

                using (var cmd = new SqliteCommand(createTable, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
