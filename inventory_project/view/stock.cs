using System;
using System.Windows.Forms;
using inventory_project.model;
using inventory_project.controller;
using System.Linq;

namespace inventory_project.view
{
    public partial class stock : Form
    {
        StockController sc = new StockController();
        CategoriesController c = new CategoriesController();
        PermissionController pc = new PermissionController();
        
        public stock()
        {
            InitializeComponent();
        }
        private void stock_Load(object sender, EventArgs e)
        {
            dgv_stock.DataSource = sc.SelectAll();
            Category.ValueMember = "id";
            Category.DisplayMember = "name";
            Category.DataSource = c.SelectAll();
            checkPermission();
        }

        private void AddToStock_Click(object sender, EventArgs e)
        {
            if (Product_Name.Text == "" || Unit_Price.Text == "" || Description.Text == "" || Quantity.Text == "" || Category.SelectedIndex == -1)
            {
                MessageBox.Show("Inputs cant be empty", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sc.insert(Product_Name.Text, float.Parse(Unit_Price.Text), Description.Text, Int32.Parse(Quantity.Text), Int32.Parse(Category.SelectedValue.ToString()));
                dgv_stock.DataSource = sc.SelectAll();
            }
            Reset();
        }

        private void dgv_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Product_Id.Text = Convert.ToString(dgv_stock.CurrentRow.Cells[0].Value);
                Product_Name.Text = Convert.ToString(dgv_stock.CurrentRow.Cells[1].Value);
                Unit_Price.Text = Convert.ToString(dgv_stock.CurrentRow.Cells[2].Value);
                Description.Text = Convert.ToString(dgv_stock.CurrentRow.Cells[3].Value);
                Quantity.Text = Convert.ToString(dgv_stock.CurrentRow.Cells[4].Value);
                Category.SelectedValue = Convert.ToInt32(dgv_stock.CurrentRow.Cells[5].Value);
            }
        }

        private void UpdateForStock_Click(object sender, EventArgs e)
        {
            if (Product_Name.Text == "" || Unit_Price.Text == "" || Description.Text == "" || Quantity.Text == "" || Category.SelectedIndex == -1)
            {
                MessageBox.Show("Inputs cant be empty", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sc.update(Int32.Parse(Product_Id.Text), Product_Name.Text, float.Parse(Unit_Price.Text), Description.Text, Int32.Parse(Quantity.Text), Int32.Parse(Category.SelectedValue.ToString()));
                dgv_stock.DataSource = sc.SelectAll();
            }
            Reset();

        }

        private void DeleteForStock_Click(object sender, EventArgs e)
        {
            sc.delete(Int32.Parse(Product_Id.Text));
            dgv_stock.DataSource = sc.SelectAll();
            Reset();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            category c = new category();
            c.Show();
        }

        private void SearchForStock_Click(object sender, EventArgs e)
        {
            Stock product = sc.search(Search.Text);
            if(product != null)
            {
                Product_Id.Text = product.id.ToString();
                Product_Name.Text = product.name;
                Unit_Price.Text = product.unit_price.ToString();
                Category.SelectedValue = product.category;
                Quantity.Text = product.quantity.ToString();
                Description.Text = product.description;
            }
        }

        public void checkPermission()
        {
            Permissions pr = Program.list.SingleOrDefault(i => i.roll_id == "stock_viewonly");
            if (pr != null)
            {
                Edit.Enabled = false;
                pr = null;
            }

            pr = Program.list.SingleOrDefault(r => r.roll_id == "stock_insert");
            if (pr != null)
            {
                AddToStock.Enabled = true;
                pr = null;
            }
            pr = Program.list.SingleOrDefault(r => r.roll_id == "stock_update");
            if (pr != null)
            {
                UpdateForStock.Enabled = true;
                pr = null;
            }
            pr = Program.list.SingleOrDefault(r => r.roll_id == "stock_delete");
            if (pr != null)
            {
                DeleteForStock.Enabled = true;
                pr = null;
            }
        }
        public void Reset()
        {
            Product_Id.Text = "";
            Product_Name.Text = "";
            Unit_Price.Text = "";
            Description.Text = "";
            Quantity.Text = "";
            Category.SelectedIndex = -1;
        }
    }
}
