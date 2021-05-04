using MySql.Data.MySqlClient;
using System;
using System.Threading;

namespace inventory_project
{
    class DBconn
    {
        private static string Server = "localhost";
        private static string Username = "root";
        private static string Port = "3306";
        private static string Password = "";
       

        static string conf = "datasource=" + Server + ";port=" + Port + ";username=" + Username + ";password=" + Password;

        static MySqlConnection db;
        
        //preform singletone
        public static MySqlConnection Connection
        {
            get
            {
                if (db == null)
                {
                    LazyInitializer.EnsureInitialized(ref db, CreateConnection);
                }
                return db;
            }
        }

        static MySqlConnection CreateConnection()
        {
            var db = new MySqlConnection(conf);
            

            db.Open();
            return db;
        }

        // close connection
        static void CloseConnection()
        {
            if (db != null)
            {
                db.Close();
                db.Dispose();
                db = null;
            }
        }
    }
}
