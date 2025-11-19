using Microsoft.Data.Sqlite;
using ZombieSurvivalGame.Config;
using ZombieSurvivalGame.Services;
using ZombieSurvivalGame.Utils;

namespace ZombieSurvivalGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameService gameService = new GameService();
            gameService.Start();

            //try
            //{
            //             using(var conn = new SqliteConnection(DbConfig.ConnectionString))
            //             {
            //                 conn.Open();

            //                 using (var cmd = conn.CreateCommand()) {
            //                     cmd.CommandText = "INSERT INTO Profile (Username) VALUES ($username);";

            //                     cmd.Parameters.AddWithValue("$username", username);

            //                     cmd.ExecuteNonQuery();

            //                     Console.WriteLine("Added.");
            //                 }

            //                 Console.WriteLine("Db Path: " + DbConfig.DbPath);
            //             }
            //}
            //catch (Exception e)
            //{
            //             Console.WriteLine("Error in db: " + e.Message);

            //}
        }
    }

     
}
