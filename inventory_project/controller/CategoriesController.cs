using inventory_project.model;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace inventory_project.controller
{
    class CategoriesController : ICategory
    {
        public string sql;
        public void delete(int id)
        {
            sql = "DELETE FROM inventory.categories  where `category_id`=@id;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            sql = "";
        }

        public void insert(string name)
        {
            sql = "INSERT INTO inventory.categories (`name`) VALUES (@name)";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.ExecuteNonQuery();
            sql = "";
        }


        public List<Categories> SelectAll()
        {
            List<Categories> categories = new List<Categories>();
            sql = "SELECT * FROM inventory.categories;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Categories c = new Categories(reader.GetInt32(0), reader.GetString(1));
                    categories.Add(c);
                }
            }
            sql = "";
            return categories;
        }

        public void update(int id, string name)
        {
            sql = "UPDATE inventory.categories SET `name`=@name where `category_id`=@id;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.ExecuteNonQuery();
            sql = "";
        }
    }
}
