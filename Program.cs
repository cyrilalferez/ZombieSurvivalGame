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
        }
    }
}
