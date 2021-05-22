using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project.model
{
    class Permissions
    {
        public string roll_id { get; set; }
        public string type { get; set; }
        public Permissions(string roll_id, string type)
        {
            this.roll_id = roll_id;
            this.type = type;
        }
    }
}
