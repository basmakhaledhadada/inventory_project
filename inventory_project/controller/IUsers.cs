using System.Collections.Generic;
using inventory_project.model;
namespace inventory_project.controller
{
    interface IUsers
    {
        List<Users> SelectAll();
        void insert(string name, string email, string password);
        void update(int id,string name, string email, string password);
        void delete(int id);
        Users search(string user);
        int auth(string email, string password);

    }
}
