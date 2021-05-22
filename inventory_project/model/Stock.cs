using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project.model
{
    class Stock
    {
        public int id { get; set; }
        public string name { get; set; }
        public float unit_price { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public int category { get; set; }

        public Stock(int id, string name, float unit_price, string description, int quantity, int category)
        {
            this.id = id;
            this.name = name;
            this.unit_price = unit_price;
            this.description = description;
            this.quantity = quantity;
            this.category = category;
        }

    }
}
