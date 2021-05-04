using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project.model
{
    class Users
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int permission { get; set; }
 

        public Users(string username, string email, string password, int permission)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.permission = permission;

        }
    }
}
