using System.Collections.Generic;
using System.Linq;
using System.Data;
using gldotnet.Models;
using Dapper;


namespace gldotnet.Repositories
{
    public class HousesRepository
    {
        private readonly IDbConnection _db;
        public HousesRepository(IDbConnection db)
        {
            _db = db;
        }
        internal List<House> Get()
        {
            string sql = "SELECT * FROM houses";
            return _db.Query<House>(sql).ToList();
        }
        internal House Get(int id)
        {
            string sql = "SELECT * FROM houses WHERE id = @id";
            return _db.QueryFirstOrDefault<House>(sql, new { id });
        }
        internal House Create(House houseData)
        {
            string sql = @"
            INSERT INTO houses
              (make, price, color, year, description, image)
            VALUES
              (@Make, @Price, @Color, @Year, @Description, @Image)";
            _db.Execute(sql, houseData);
            return houseData;
        }
        internal House Update(House houseData)
        {
            string sql = @"
            UPDATE houses
            SET 
           
            WHERE id = @Id;"; int id =
            _db.ExecuteScalar<int>(sql, houseData);
            houseData.Id = id;
            return houseData;
        }
        internal House Delete(int id)
        {
            string sql = "DELETE FROM houses WHERE id = @id";
            _db.Execute(sql, new { id });
            return Get(id);
        }
    }
}
