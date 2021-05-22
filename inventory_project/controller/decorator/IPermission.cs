namespace inventory_project.controller
{
    interface IPermission
    {
        void viewOnly();
        void insert();
        void update();
        void delete();
        void addPermission();
    }
}
