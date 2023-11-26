using Dapper;
using StoresNetwork.Database.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork.Database.DataControllers
{
    internal class RolesDataController
    {
        public IEnumerable<Role> SelectAllRoles()
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Role>(
                    DatabaseConnection.SelectAllRoles,
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }
        public Role SelectRole(int roleId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Role>(
                    DatabaseConnection.SelectRole,
                    new { RoleId = roleId },
                    commandType: CommandType.StoredProcedure
                    );
                return rows.First();
            }
        }
        public void InsertRole(Role role)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.InsertRole,
                    new { RoleName = role.Name },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void DeleteRole(int roleId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.DeleteRole,
                    new { RoleId = roleId },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void UpdateRoleName(int roleId, string? name)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.UpdateRoleName,
                    new { RoleId = roleId, NewName = name },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
    }
}
