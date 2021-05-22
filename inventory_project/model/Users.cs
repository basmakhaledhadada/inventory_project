using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project.model
{
    class Users
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Users(int id, string username, string email, string password)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
        }
    }
}
