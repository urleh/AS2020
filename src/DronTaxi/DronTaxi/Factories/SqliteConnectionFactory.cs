using DronTaxi.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronTaxi.Factories
{
    class SqliteConnectionFactory :  IConnectionFactory
    {
        private IDbConnection _connection;

        public IDbConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new SQLiteConnection(@"Data Source=.\DronTaxi.db");
                _connection.Open();

            }

            return _connection;
        }
    }
}
