using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.Database
{
    internal static class DatabaseConnection
    {
        private const string ConnectionString = "Data Source=WS-000030129;Initial Catalog=BikeStores;Persist Security Info=False;User ID=sa;Password=12345678";
        public static SqlConnection GetConnection() => new(ConnectionString);

        #region Cities

        #endregion
    }
}
