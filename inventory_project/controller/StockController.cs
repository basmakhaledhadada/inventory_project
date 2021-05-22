using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using inventory_project.model;
using System.Windows.Forms;
namespace inventory_project.controller
{
    class StockController : IStock
    {
        public string sql;
        public List<Stock> SelectAll()
        {
            List<Stock> stock = new List<Stock>();
            sql = "SELECT * FROM inventory.stock;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Stock s = new Stock(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5));
                    stock.Add(s);
                }
            }
            sql = "";
            return stock;
        }

        public void insert(string name, float price, string description, int quantity, int category)
        {
            sql = "INSERT INTO inventory.stock (`product_name`, `unit_price`, `description`, `quantity`, `category_id`) VALUES (@name, @unit_price, @description, @quantity, @category)";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("unit_price", price);
            cmd.Parameters.AddWithValue("description", description);
            cmd.Parameters.AddWithValue("quantity", quantity);
            cmd.Parameters.AddWithValue("category", category);
            cmd.ExecuteNonQuery();
            sql = "";
        }

        public void update(int id, string name, float price, string description, int quantity, int category)
        {
            sql = "UPDATE inventory.stock SET `product_name`=@name,`unit_price`=@unit_price,`description`=@description,`quantity`=@quantity,`category_id`=@category WHERE `product_id` = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("unit_price", price);
            cmd.Parameters.AddWithValue("description", description);
            cmd.Parameters.AddWithValue("quantity", quantity);
            cmd.Parameters.AddWithValue("category", category);
            cmd.ExecuteNonQuery();
            sql = "";
        }
        public void delete(int id)
        {
            sql = "DELETE FROM inventory.stock WHERE `product_id` = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            sql = "";
        }

        public Stock search(string product)
        {
            int id = 0;   
            bool result = Int32.TryParse(product, out id);
            if (result == true)
            {
                List<Stock> list = this.SelectAll();
                Stock item = list.SingleOrDefault(p => p.id == id);
                if (item is null)
                {
                    MessageBox.Show("Product not found");
                    return item;
                }
                else
                {
                    MessageBox.Show("Product found!");
                    return item;
                }
                
            }

            else
            {
                List<Stock> list = this.SelectAll();
                Stock item = list.SingleOrDefault(p => p.name == product);
                if (item is null)
                {
                    MessageBox.Show("Product not found");
                    return item;
                }
                else
                {
                    MessageBox.Show("Product found!");
                    return item;
                }
            }
        }
    }
}
