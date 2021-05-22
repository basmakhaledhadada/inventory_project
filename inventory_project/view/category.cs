using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



        private void button1_Click(object sender, EventArgs e)
        {
            c.insert(Category_Name.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            c.update(Convert.ToInt32(Category_Id.Text), Category_Name.Text);
            dgv_category.DataSource = c.SelectAll();
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            c.delete(Convert.ToInt32(Category_Id.Text));
            dgv_category.DataSource = c.SelectAll();
        }
    }
}
