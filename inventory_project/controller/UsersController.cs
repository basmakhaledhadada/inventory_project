using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_project.model;
using MySql.Data.MySqlClient;

namespace inventory_project.controller
{
    class UsersController : IDbOperations<List<Users>>
    {
        public List<Users> users = new List<Users>();
        public List<Users> SelectAll()
        {
            var sql = "select * from inventory.users;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Users u = new Users(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                users.Add(u);
            }
            return users;
        }
        public int delete()
        {
            throw new NotImplementedException();
        }

        public int insert()
        {
            throw new NotImplementedException();
        }

        public int search()
        {
            throw new NotImplementedException();
        }

        public int update()
        {
            throw new NotImplementedException();
        }
    }
}
