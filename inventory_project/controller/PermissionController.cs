using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_project.model;
using MySql.Data.MySqlClient;
using inventory_project.controller;
namespace inventory_project.controller
{
    class PermissionController
    {
        public string sql;
        public List<Permissions> SelectAll(int id)
        {
            List<Permissions> p = new List<Permissions>();
            sql = "SELECT roll_id, type FROM inventory.users_rolls where user_id=@id;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("id", id);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Permissions c = new Permissions(reader.GetString(0), reader.GetString(1));
                    p.Add(c);
                }
            }
            sql = "";
            return p;
        }

        public void delete(int id)
        {
            sql = "DELETE FROM inventory.users_rolls WHERE `user_id` = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            sql = "";
        }
    }
}
