using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SQLite;
using Catel.MVVM;
using Catel.IoC;
using DronTaxi.Factories.Interfaces;
using DronTaxi.Factories;
using DronTaxi.Services.Sqlite;
using DronTaxi.Services.Interfaces;
using DronTaxi.Common;
using Dapper;

namespace DronTaxi
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

            ServiceLocator.Default.RegisterType<IConnectionFactory, SqliteConnectionFactory>();

            ServiceLocator.Default.RegisterType<IUserService, UserService>();

            var srv = ServiceLocator.Default.ResolveType<IUserService>();

            var a = srv.GetUsers();

        }
    }
}
