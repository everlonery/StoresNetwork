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
        public const string InsertRole = "sp_Roles_Insert";
        public const string DeleteRole = "sp_Roles_Delete";
        public const string UpdateRoleName = "sp_Roles_UpdateName";
        #endregion
        #region Categories
        public const string SelectAllCategories = "sp_Categories_SelectAll";
        public const string SelectCategoryParent = "sp_Categories_SelectParent";
        public const string InsertCategory = "sp_Categories_Insert";
        public const string DeleteCategory = "sp_Categories_Delete";
        public const string UpdateCategoryName = "sp_Categories_UpdateName";
        public const string UpdateCategoryParent = "sp_Categories_UpdateParent";
        #endregion
    }
}
