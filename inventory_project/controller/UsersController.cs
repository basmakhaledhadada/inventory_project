using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using inventory_project.model;
using MySql.Data.MySqlClient;

namespace inventory_project.controller
{
    class UsersController : IUsers
    {
       
        public string sql;

        public int auth(string email, string password)
        {
            int id= 0;
            sql = "SELECT user_id FROM inventory.users WHERE email=@email AND password=@password;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("password", password);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                
            }
            sql = "";
            return id;
        }

        public void delete(int id)
        {
            sql = "DELETE FROM inventory.users WHERE `user_id` = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            sql = "";
        }

        public void insert(string name, string email, string password)
        {
            sql = "INSERT INTO inventory.users (`username`, `email`, `password`) VALUES (@name, @email, @password)";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("password", password);
            cmd.ExecuteNonQuery();
            sql = "";
        }

        public Users search(string user)
        {
            int id = 0;
            bool result = Int32.TryParse(user, out id);
            if (result == true)
            {
                List<Users> list = this.SelectAll();
                Users us = list.SingleOrDefault(u => u.id == id);
                if (us is null)
                {
                    MessageBox.Show("User not found");
                    return us;
                }
                else
                {
                    MessageBox.Show("User found!");
                    return us;
                }

            }

            else
            {
                List<Users> list = this.SelectAll();
                Users us = list.SingleOrDefault(u => u.username == user);
                if (user is null)
                {
                    MessageBox.Show("User not found");
                    return us;
                }
                else
                {
                    MessageBox.Show("User found!");
                    return us;
                }
            }
        }

        public List<Users> SelectAll()
        {
       List<Users> users = new List<Users>();
        sql = "SELECT * FROM inventory.users;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Users u = new Users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    users.Add(u);
                }
            }
            sql = "";
            return users;
        }

        public void update(int id, string name, string email, string password)
        {
            sql = "UPDATE inventory.users SET `username`=@name,`email`=@email,`password`=@password WHERE `user_id` = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("password", password);
            cmd.ExecuteNonQuery();
            sql = "";
        }
    }
}
