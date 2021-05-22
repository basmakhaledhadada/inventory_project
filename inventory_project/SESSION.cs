using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_project.model;

namespace inventory_project
{
    static class SESSION
    {
        public static List<Permissions> p = new List<Permissions>();

        private static int _id;

        public static int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
