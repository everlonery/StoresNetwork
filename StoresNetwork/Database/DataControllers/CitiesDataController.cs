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
    internal class CitiesDataController
    {
        public IEnumerable<City> SelectAllCities()
        {
            using(var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<City>(
                    DatabaseConnection.SelectAllCities, 
                    commandType: CommandType.StoredProcedure
                    );
                return rows;
            }
        }
        public void InsertCity(City city)
        {
            using(var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.InsertCity,
                    new { CityName = city.Name},
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void DeleteCity(int cityId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.DeleteCity,
                    new { CityId = cityId },
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
        public void UpdateCityName(int cityId, string? name)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DatabaseConnection.UpdateCityName,
                    new { CityId = cityId, NewName = name},
                    commandType: CommandType.StoredProcedure
                    );
            }
        }
    }
}
