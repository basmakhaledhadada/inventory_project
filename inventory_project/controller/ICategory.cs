using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_project.model;

namespace inventory_project.controller
{
    interface ICategory
    {
        List<Categories> SelectAll();
        void insert(string name);
        void update(int id, string name);
        void delete(int id);
    }
}
