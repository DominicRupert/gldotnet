using System.Collections.Generic;
using System.Data;
using System.Linq;
using gldotnet.Models;
using Dapper;

namespace gldotnet.Repositories
{
    public class CarsRepository
    {
        private readonly IDbConnection _db;
        public CarsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal List<Car> Get()
        {
            string sql = "SELECT * FROM cars"; 
            return _db.Query<Car>(sql).ToList();
          
             
 
        
        }
        internal Car Get(int id)
        {
            string sql = "SELECT * FROM cars WHERE id = @id";
            return _db.QueryFirstOrDefault<Car>(sql, new { id });
        }
        internal Car Create(Car carData)
        {
            string sql = @"
            INSERT INTO cars
              (make, price, color, year, description, image)
            VALUES
              (@Make, @Price, @Color, @Year, @Description, @Image)";
            _db.Execute(sql, carData);
            return carData;
        }
        internal Car Update(Car carData)
        {
            string sql = @"
            UPDATE cars
            SET 
              make = @Make,
              price = @Price,
              color = @Color,
              year = @Year,
              description = @Description,
              image = @Image
            WHERE id = @Id;"; int id =
            _db.ExecuteScalar<int>(sql, carData);
            carData.Id = id;
            return carData;
        }
        internal Car Delete(int id)
        {
            string sql = "DELETE FROM cars WHERE id = @id";
            _db.Execute(sql, new { id });
            return Get(id);
        }
    }
}