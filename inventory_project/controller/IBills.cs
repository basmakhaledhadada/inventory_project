using System.Collections.Generic;
using inventory_project.model;
namespace inventory_project.controller
{
    interface IBills
    {
        List<Bills> SelectAll(string bill_type);
        void insert(string bill_type, int product_id, float unit_price, int quantity, float total_price, string date, string client);
        void update(string bill_type, int bill_id, int product_id, float unit_price, int quantity, float total_price, string date, string client);
        void delete(string bill_type, int id);
        Bills search(string bill_type, int bill);
    }
}
