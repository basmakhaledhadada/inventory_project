using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_project.controller
{
    abstract class UserDecorator : IPermission
    {
        protected IPermission userPermission;
        
        public UserDecorator(IPermission userpermission)
        {
            this.userPermission = userpermission;
        }
        public abstract void delete();
        public abstract void insert();
        public abstract void update();
        public abstract void viewOnly();
        public abstract void addPermission();

    }
}
