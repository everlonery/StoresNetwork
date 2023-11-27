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
    internal class CategoriesDataController
    {
        public IEnumerable<Category> SelectAllCategories()
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Category>(
                    DatabaseConnection.SelectAllCategories,
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }
        public Category? SelectCategoryParent(int parentId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Category>(
                    DatabaseConnection.SelectCategoryParent,
                    new {ParentId = parentId},
                    commandType: CommandType.StoredProcedure
                    );
                if( rows.Any())
                    return rows.First();
                return null;
            }
        }
        public void InsertCategory(Category category)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.InsertCategory,
                    new { CategoryName = category.Name },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void DeleteCategory(int categoryId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.DeleteCategory,
                    new { CategoryId = categoryId },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void DeleteParent(int categoryId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.DeleteParent,
                    new { CategoryId = categoryId },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void UpdateCategoryName(int categoryId, string? name)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.UpdateCategoryName,
                    new { CategoryId = categoryId, NewName = name },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public void UpdateCategoryParent(int categoryId, int parentId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.UpdateCategoryParent,
                    new { CategoryId = categoryId, NewParentId = parentId },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }

        public IEnumerable<Category> GetOtherCategories(int categoryId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Category>(
                    DatabaseConnection.OtherCategories,
                    new { CategoryId = categoryId },
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }
    }
}
