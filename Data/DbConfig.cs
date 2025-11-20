namespace ZombieSurvivalGame.Config
{
    internal class DbConfig
    {
        public static readonly string DbPath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName, "ZombieSurvival.db");
        public static readonly string ConnectionString = $"Data Source={DbPath}";
    }
}
