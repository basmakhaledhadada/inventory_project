using System;
using System.Collections.Specialized;
using MySql.Data.MySqlClient;

namespace inventory_project.controller
{
    class BillsPermission : UserDecorator
    {
        public int id;
        Boolean[] p = new Boolean[4];
        public string sql;
        public BillsPermission(IPermission userpermission, Boolean[] p) : base(userpermission)
        {
            this.p = p;
        }

        public override void delete()
        {

            if (this.p[3] == true)
            {
                this.id = this.getLastUser();
                sql = "INSERT INTO inventory.`users_rolls`(`user_id`, `roll_id`, `type`) VALUES (@user_id ,@roll_id, @type)";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("user_id", this.id);
                cmd.Parameters.AddWithValue("roll_id", "bills_delete");
                cmd.Parameters.AddWithValue("type", "bills");
                cmd.ExecuteNonQuery();
                sql = "";
            }
        }

        public override void insert()
        {
            if (this.p[1] == true)
            {
                this.id = this.getLastUser();
                sql = "INSERT INTO inventory.`users_rolls`(`user_id`, `roll_id`, `type`) VALUES (@user_id ,@roll_id, @type)";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("user_id", this.id);
                cmd.Parameters.AddWithValue("roll_id", "bills_insert");
                cmd.Parameters.AddWithValue("type", "bills");
                cmd.ExecuteNonQuery();
                sql = "";
            }
        }

        public override void update()
        {
            if (this.p[2] == true)
            {
                this.id = this.getLastUser();
                sql = "INSERT INTO inventory.`users_rolls`(`user_id`, `roll_id`, `type`) VALUES (@user_id ,@roll_id, @type)";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("user_id", this.id);
                cmd.Parameters.AddWithValue("roll_id", "bills_update");
                cmd.Parameters.AddWithValue("type", "bills");
                cmd.ExecuteNonQuery();

            }
        }

        public override void viewOnly()
        {
            if (this.p[0] == true)
            {
                this.id = this.getLastUser();
                sql = "INSERT INTO inventory.`users_rolls`(`user_id`, `roll_id`, `type`) VALUES (@user_id ,@roll_id, @type)";
                MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
                cmd.Parameters.AddWithValue("user_id", this.id);
                cmd.Parameters.AddWithValue("roll_id", "bills_viewonly");
                cmd.Parameters.AddWithValue("type", "bills");
                cmd.ExecuteNonQuery();
                sql = "";
            }
        }
        public override void addPermission()
        {
            userPermission.addPermission();
            this.viewOnly();
            this.insert();
            this.update();
            this.delete();
        }
        public int getLastUser()
        {
            int id;
            sql = "SELECT user_id from inventory.users ORDER BY user_id DESC LIMIT 1;";
            MySqlCommand cmd = new MySqlCommand(sql, DBconn.Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                id = reader.GetInt32(0);

            }
            Console.WriteLine(id);
            return id;
        }
    }
}