using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using inventory_project.model;
using MySql.Data.MySqlClient;
namespace inventory_project.controller
{
    class BillsController : IBills
    {
        public string sql;
        public void delete(string bill_type, int id)
        {
            if (bill_type.Equals("invoice"))
            {
                sql = "DELETE FROM inventory.invoice WHERE `bill_id` = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                sql = "";
            }
            else
            {
                sql = "DELETE FROM inventory.outvoice WHERE `bill_id` = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                sql = "";
            }
        }

        public void insert(string bill_type, int product_id, float unit_price, int quantity, float total_price, string date, string client)
        {
            if (bill_type.Equals("invoice"))
            {
                sql = "INSERT INTO inventory.invoice (`product_id`, `unit_price`, `quantity`, `total_price`, `date`, `provider`) VALUES (@product_id, @unit_price, @quantity, @total_price, @date, @client)";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("product_id", product_id);
                cmd.Parameters.AddWithValue("unit_price", unit_price);
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.Parameters.AddWithValue("total_price", total_price);
                cmd.Parameters.AddWithValue("date", date);
                cmd.Parameters.AddWithValue("client", client);
                cmd.ExecuteNonQuery();
                sql = "";
                updateStock(product_id, quantity, bill_type);
            }
            else
            {
                sql = "INSERT INTO inventory.outvoice (`product_id`, `unit_price`, `quantity`, `total_price`, `date`, `reciever`) VALUES (@product_id, @unit_price, @quantity, @total_price, @date, @client)";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("product_id", product_id);
                cmd.Parameters.AddWithValue("unit_price", unit_price);
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.Parameters.AddWithValue("total_price", total_price);
                cmd.Parameters.AddWithValue("date", date);
                cmd.Parameters.AddWithValue("client", client);
                cmd.ExecuteNonQuery();
                sql = "";
                updateStock(product_id, quantity, bill_type);
            }
        }

        public Bills search(string bill_type, int bill)
        {
            List<Bills> list = this.SelectAll(bill_type);
            Bills bl = list.SingleOrDefault(b => b.bill_id == bill);
            if (bl is null)
            {
                MessageBox.Show("bill not found", "missing bill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bl;
            }
            else
            {
                MessageBox.Show("bill found", "found you bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return bl;
            }
        }

        public List<Bills> SelectAll(string bill_type)
        {
            if (bill_type.Equals("invoice"))
            {
                List<Bills> bills = new List<Bills>();
                sql = "SELECT * FROM inventory.invoice;";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bills b = new Bills(reader.GetInt32(0), reader.GetInt32(1), reader.GetFloat(2), reader.GetInt32(3), reader.GetFloat(4), reader.GetString(5), reader.GetString(6));
                        bills.Add(b);
                    }
                }
                sql = "";
                return bills;
            }
            else
            {
                List<Bills> bills = new List<Bills>();
                sql = "SELECT * FROM inventory.outvoice;";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Bills b = new Bills(reader.GetInt32(0), reader.GetInt32(1), reader.GetFloat(2), reader.GetInt32(3), reader.GetFloat(4), reader.GetString(5), reader.GetString(6));
                        bills.Add(b);
                    }
                }
                sql = "";
                return bills;
            }

        }

        public void update(string bill_type, int bill_id, int product_id, float unit_price, int quantity, float total_price, string date, string client)
        {
            if (bill_type.Equals("invoice"))
            {
                sql = "UPDATE inventory.outvoice SET `product_id`=@product_id,`unit_price`=@unit_price,`quantity`=@quantity,`total_price`=@total_price,`date`=@date,`provider`=@client  WHERE `bill_id`=@bill_id";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("product_id", product_id);
                cmd.Parameters.AddWithValue("bill_id", bill_id);
                cmd.Parameters.AddWithValue("unit_price", unit_price);
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.Parameters.AddWithValue("total_price", total_price);
                cmd.Parameters.AddWithValue("date", date);
                cmd.Parameters.AddWithValue("client", client);
                cmd.ExecuteNonQuery();
                sql = "";
                updateStock(product_id, quantity, bill_type);
            }
            else
            {
                sql = "UPDATE inventory.outvoice SET `product_id`=@product_id,`unit_price`=@unit_price,`quantity`=@quantity,`total_price`=@total_price,`date`=@date,`reciever`=@client WHERE `bill_id`=@bill_id";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("bill_id", bill_id);
                cmd.Parameters.AddWithValue("product_id", product_id);
                cmd.Parameters.AddWithValue("unit_price", unit_price);
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.Parameters.AddWithValue("total_price", total_price);
                cmd.Parameters.AddWithValue("date", date);
                cmd.Parameters.AddWithValue("client", client);
                cmd.ExecuteNonQuery();
                sql = "";
                updateStock(product_id, quantity, bill_type);
            }

        }
        public void updateStock(int product_id, int quantity, string bill_type)
        {
            if (bill_type == "invoice")
            {
                sql = "UPDATE inventory.stock SET `quantity`=@quantity + `quantity` WHERE `product_id`=@product_id";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("product_id", product_id);
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.ExecuteNonQuery();
                sql = "";
            }
            if (bill_type == "outvoice")
            {
                sql = "UPDATE inventory.stock SET `quantity`= `quantity` - @quantity WHERE `product_id`=@product_id";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("product_id", product_id);
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.ExecuteNonQuery();
                sql = "";
            }

        }

        public int getQuantity(int product_id)
        {
            int q = 0;
            sql = "SELECT quantity FROM inventory.stock where product_id=@product_id;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("product_id", product_id);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    q = reader.GetInt32(0);
                }
            }
            return q;
        }
    }
}
