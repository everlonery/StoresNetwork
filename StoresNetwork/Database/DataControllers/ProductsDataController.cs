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
    internal class ProductsDataController
    {
        public IEnumerable<Product> SelectAllProducts()
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Product>(
                    DatabaseConnection.SelectAllProducts,
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }
        public void DeleteProduct(int productId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.DeleteProduct,
                    new { ProductId = productId },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void InsertProduct(Product product)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.InsertProduct,
                    new { Name = product.Name, Price = product.Price},
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void UpdateProductName(int productId, string? name)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.UpdateProductName,
                    new { ProductId = productId, Name = name },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void UpdateProductPrice(int productId, double price)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.UpdateProductPrice,
                    new { ProductId = productId, Price = price },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
    }
}
