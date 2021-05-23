using System;
using System.Windows.Forms;
using inventory_project.controller;

namespace inventory_project.view
{
    public partial class category : Form
    {
        CategoriesController c = new CategoriesController();
        public category()
        {
            InitializeComponent();
        }

        private void category_Load(object sender, EventArgs e)
        {
            dgv_category.DataSource = c.SelectAll();
        }

        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Category_Id.Text = Convert.ToString(dgv_category.CurrentRow.Cells[0].Value);
                Category_Name.Text = Convert.ToString(dgv_category.CurrentRow.Cells[1].Value);
            }
        }
        private void AddToCategory_Click(object sender, EventArgs e)
        {
            if (Category_Name.Text != "")
            {
                c.insert(Category_Name.Text);
                Reset();
                dgv_category.DataSource = c.SelectAll();
            }
            else
            {
                MessageBox.Show("Inputs cant be empty", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateCategory_Click(object sender, EventArgs e)
        {
            if (Category_Name.Text != "")
            {
                c.update(Convert.ToInt32(Category_Id.Text), Category_Name.Text);
                Reset();
                dgv_category.DataSource = c.SelectAll();
            }
            else
            {
                MessageBox.Show("Inputs cant be empty", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            c.delete(Convert.ToInt32(Category_Id.Text));
            Reset();
            dgv_category.DataSource = c.SelectAll();
        }
        public void Reset()
        {
            Category_Id.Text = "";
            Category_Name.Text = "";
        }
    }
}
