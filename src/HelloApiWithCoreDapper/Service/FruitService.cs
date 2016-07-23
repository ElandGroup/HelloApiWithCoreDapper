using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using HelloApiWithCoreDapper.Models;

namespace HelloApiWithCoreDapper.Service
{
    public interface IFruitService
    {
        Task<IEnumerable<FruitDto>> FruitQuery();
    }
    public class FruitService : IFruitService
    {
        string connStr = @"Data Source=qds114812583.my3w.com,1433;Initial Catalog=qds114812583_db;
            User ID=qds114812583;password=Eland123;Integrated Security=False";
        public async Task<IEnumerable<FruitDto>> FruitQuery()
        {
            string sqlText = @"SELECT * FROM  Fruit";
            using (var conn = new SqlConnection(connStr))
            {
                return await conn.QueryAsync<FruitDto>(sqlText);
            }
        }

    }
}
