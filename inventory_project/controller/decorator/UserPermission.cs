using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project.controller
{
    class UserPermission : IPermission
    {
        public void delete()
        {
            Console.WriteLine("UserPermission");
        }

        public void insert()
        {
            Console.WriteLine("default");
        }

        public void update()
        {
            Console.WriteLine("default");
        }

        public void viewOnly()
        {
            Console.WriteLine("default");
        }
        public void addPermission()
        {

            Console.WriteLine("default");
        }
    }
}
