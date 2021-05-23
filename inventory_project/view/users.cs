using System;
using System.Windows.Forms;
using inventory_project.model;
using inventory_project.controller;
using System.Linq;

namespace inventory_project.view
{
    public partial class users : Form
    {
        UsersController user = new UsersController();
        PermissionController per = new PermissionController();
        Boolean[] stockPermission = new Boolean[4];
        Boolean[] billsPermission = new Boolean[4];
        Boolean[] usersPermission = new Boolean[4];
        public users()
        {
            InitializeComponent();
        }
        private void users_Load(object sender, EventArgs e)
        {
           dgv_users.DataSource = user.SelectAll();
           checkPermission();
        }

        private void AddToUsers_Click(object sender, EventArgs e)
        {
            if (User_Name.Text == "" || Email.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Inputs cant be empty", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user.insert(User_Name.Text, Email.Text, Password.Text);
                dgv_users.DataSource = user.SelectAll();
                Reset();
                if (ViewOnly_Stock.Checked)
                {
                    this.stockPermission[0] = true;
                }
                else
                {
                    if (Insert_Stock.Checked)
                    {
                        this.stockPermission[1] = true;
                    }
                    if (Update_Stock.Checked)
                    {
                        this.stockPermission[2] = true;
                    }
                    if (Delete_Stock.Checked)
                    {
                        this.stockPermission[3] = true;
                    }
                }

                if (ViewOnly_Users.Checked)
                {
                    this.usersPermission[0] = true;
                }
                else
                {
                    if (Insert_Users.Checked)
                    {
                        this.usersPermission[1] = true;
                    }
                    if (Update_Users.Checked)
                    {
                        this.usersPermission[2] = true;
                    }
                    if (Delete_Users.Checked)
                    {
                        this.usersPermission[3] = true;
                    }
                }

                if (ViewOnly_Bills.Checked)
                {
                    this.stockPermission[0] = true;
                }
                else
                {
                    if (Insert_Bills.Checked)
                    {
                        this.billsPermission[1] = true;
                    }
                    if (Update_Bills.Checked)
                    {
                        this.billsPermission[2] = true;
                    }
                    if (Delete_Bills.Checked)
                    {
                        this.billsPermission[3] = true;
                    }
                }
                IPermission p = new UserPermission();
                StockPermission s = new StockPermission(p, stockPermission);
                BillsPermission b = new BillsPermission(s, billsPermission);
                UsersPermission u = new UsersPermission(b, usersPermission);
                IPermission permissions = u;
                permissions.addPermission();
                for (int i = 0; i < stockPermission.Length; i++) { stockPermission[i] = false; }
                for (int i = 0; i < billsPermission.Length; i++) { billsPermission[i] = false; }
                for (int i = 0; i < usersPermission.Length; i++) { usersPermission[i] = false; }
            }
        }

        private void dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                User_Id.Text = Convert.ToString(dgv_users.CurrentRow.Cells[0].Value);
                dgv_permissions.DataSource = null;
                dgv_permissions.DataSource = per.SelectAll(Int32.Parse(User_Id.Text));
                User_Name.Text = Convert.ToString(dgv_users.CurrentRow.Cells[1].Value);
                Email.Text = Convert.ToString(dgv_users.CurrentRow.Cells[2].Value);
                Password.Text = Convert.ToString(dgv_users.CurrentRow.Cells[3].Value);
            }
        }

        private void UpdateUsers_Click(object sender, EventArgs e)
        {
            if (User_Name.Text == "" || Email.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Inputs cant be empty", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user.update(Int32.Parse(User_Id.Text), User_Name.Text, Email.Text, Password.Text);
                dgv_users.DataSource = user.SelectAll();
                per.delete(Int32.Parse(User_Id.Text));
                Reset();
                if (ViewOnly_Stock.Checked)
                {
                    this.stockPermission[0] = true;
                }
                else
                {
                    if (Insert_Stock.Checked)
                    {
                        this.stockPermission[1] = true;
                    }
                    if (Update_Stock.Checked)
                    {
                        this.stockPermission[2] = true;
                    }
                    if (Delete_Stock.Checked)
                    {
                        this.stockPermission[3] = true;
                    }
                }

                if (ViewOnly_Users.Checked)
                {
                    this.usersPermission[0] = true;
                }
                else
                {
                    if (Insert_Users.Checked)
                    {
                        this.usersPermission[1] = true;
                    }
                    if (Update_Users.Checked)
                    {
                        this.usersPermission[2] = true;
                    }
                    if (Delete_Users.Checked)
                    {
                        this.usersPermission[3] = true;
                    }
                }

                if (ViewOnly_Bills.Checked)
                {
                    this.billsPermission[0] = true;
                }
                else
                {
                    if (Insert_Bills.Checked)
                    {
                        this.billsPermission[1] = true;
                    }
                    if (Update_Bills.Checked)
                    {
                        this.billsPermission[2] = true;
                    }
                    if (Delete_Bills.Checked)
                    {
                        this.billsPermission[3] = true;
                    }
                }
                IPermission p = new UserPermission();
                StockPermission s = new StockPermission(p, stockPermission);
                BillsPermission b = new BillsPermission(s, billsPermission);
                UsersPermission u = new UsersPermission(b, usersPermission);
                IPermission permissions = u;
                permissions.addPermission();
            }
        }
    
        private void DeleteUsers_Click(object sender, EventArgs e)
        {
            user.delete(Int32.Parse(User_Id.Text));
            dgv_users.DataSource = user.SelectAll();
            per.delete(Int32.Parse(User_Id.Text));
            Reset();
            

        }

        private void SearchForUser_Click(object sender, EventArgs e)
        {
            Users us = user.search(Search.Text);
            if(us != null)
            {
                User_Id.Text = us.id.ToString();
                User_Name.Text = us.username;
                Email.Text = us.email;
                Password.Text = us.password;
            }
        }

        private void ViewOnly_Bills_CheckStateChanged(object sender, EventArgs e)
        {
            if (ViewOnly_Bills.Checked == true)
            {
                Insert_Bills.Enabled = false;
                Update_Bills.Enabled = false;
                Delete_Bills.Enabled = false;
                Insert_Bills.Checked = false;
                Update_Bills.Checked = false;
                Delete_Bills.Checked = false;
            }
            else
            {
                Insert_Bills.Enabled = true;
                Update_Bills.Enabled = true;
                Delete_Bills.Enabled = true;
            }
        }

        private void ViewOnly_Stock_CheckStateChanged(object sender, EventArgs e)
        {
            if (ViewOnly_Stock.Checked == true)
            {
                Insert_Stock.Enabled = false;
                Update_Stock.Enabled = false;
                Delete_Stock.Enabled = false;
                Insert_Stock.Checked = false;
                Update_Stock.Checked = false;
                Delete_Stock.Checked = false;
            }
            else
            {
                Insert_Stock.Enabled = true;
                Update_Stock.Enabled = true;
                Delete_Stock.Enabled = true;
            }
        }
        private void ViewOnly_Users_CheckStateChanged(object sender, EventArgs e)
        {
            if (ViewOnly_Users.Checked == true)
            {
                Insert_Users.Enabled = false;
                Update_Users.Enabled = false;
                Delete_Users.Enabled = false;
                Insert_Users.Checked = false;
                Update_Users.Checked = false;
                Delete_Users.Checked = false;

            }
            else
            {
                Insert_Users.Enabled = true;
                Update_Users.Enabled = true;
                Delete_Users.Enabled = true;
            }
        }
        public void checkPermission()
        {

            Permissions pr = Program.list.SingleOrDefault(r => r.roll_id == "users_insert");
            if (pr != null)
            {
                AddToUsers.Enabled = true;
                pr = null;
            }
            pr = Program.list.SingleOrDefault(r => r.roll_id == "users_update");
            if (pr != null)
            {
                UpdateUsers.Enabled = true;
                pr = null;
            }
            pr = Program.list.SingleOrDefault(r => r.roll_id == "users_delete");
            if (pr != null)
            {
                DeleteUsers.Enabled = true;
                pr = null;
            }
        }
        public void Reset()
        {
            User_Id.Text = "";
            User_Name.Text = "";
            Email.Text = "";
            Password.Text = "";
        }
    }
}
