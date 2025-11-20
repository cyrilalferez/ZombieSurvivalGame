using Microsoft.Data.Sqlite;

namespace ZombieSurvivalGame.Config
{
    public class SqliteDatabase : IDatabase
    {
        public SqliteConnection CreateConnection()
        {
            return new SqliteConnection(DbConfig.ConnectionString);
        }
        public void Initialize()
        {
            try
            {
                using (var conn = CreateConnection())
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            CREATE TABLE IF NOT EXISTS Characters (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Role TEXT NOT NULL,
                            Age INTEGER,
                            EyeType TEXT,
                            NoseType TEXT,
                            MouthType TEXT,
                            HasHair INTEGER,
                            HairStyle TEXT,
                            BodyType TEXT,
                            SkinColor TEXT,
                            Posture TEXT,
                            Shirt TEXT,
                            Pants TEXT,
                            Weapon TEXT
                        );
                        ";

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"[DB ERROR] Initialization failed: {e.Message}");
            }
        }
    }
}
