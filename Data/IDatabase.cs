using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSurvivalGame.Config
{
    internal interface IDatabase
    {
        SqliteConnection CreateConnection();
        void Initialize();
    }
}
