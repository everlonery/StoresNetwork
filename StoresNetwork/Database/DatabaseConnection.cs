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
        private const string ConnectionString = "Data Source=ACER\\SQLEXPRESS;Initial Catalog=StoresNetworkDatabase;Persist Security Info=False;User ID=sa;Password=12345678";
        public static SqlConnection GetConnection() => new(ConnectionString);

        #region Cities 
        public const string SelectAllCities = "sp_Cities_SelectAll";
        public const string SelectCity = "sp_Cities_SelectRow";
        public const string InsertCity = "sp_Cities_Insert";
        public const string DeleteCity = "sp_Cities_Delete";
        public const string UpdateCityName = "sp_Cities_UpdateName";
        #endregion
        #region Roles
        public const string SelectAllRoles = "sp_Roles_SelectAll";
        public const string SelectRole = "sp_Roles_SelectRow";
        public const string InsertRole = "sp_Roles_Insert";
        public const string DeleteRole = "sp_Roles_Delete";
        public const string UpdateRoleName = "sp_Roles_UpdateName";
        #endregion
    }
}
