using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inventory_project.model;

namespace inventory_project.controller
{
    interface IDbOperations<T>
    {
        T SelectAll();
        int insert();
        int update();
        int delete();
        int search();

    }
}
