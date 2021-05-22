using System.Collections.Generic;
using inventory_project.model;
namespace inventory_project.controller
{
    interface IStock
    {
        List<Stock> SelectAll();
        void insert(string name, float price, string description, int quantity, int category);
        void update(int id, string name, float price, string description, int quantity, int category);
        void delete(int id);
        Stock search(string product);
    }
}
