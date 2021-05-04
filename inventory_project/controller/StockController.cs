using inventory_project.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace inventory_project.controller
{
    class StockController : IDbOperations<List<Stock>>
    {
        public List<Stock> stock = new List<Stock>();
        public List<Stock> SelectAll()
        {
            var sql = "select * from inventory.stock;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Stock s = new Stock(reader.GetString(1), reader.GetFloat(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                    stock.Add(s);
                }
                return stock;
        }

        public int insert()
        {
            throw new NotImplementedException();
        }

        public int update()
        {
            throw new NotImplementedException();
        }
        public int delete()
        {
            throw new NotImplementedException();
        }

        public int search()
        {
            throw new NotImplementedException();
        }
    }
}
