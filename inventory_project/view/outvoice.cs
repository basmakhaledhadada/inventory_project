using System;
using System.Windows.Forms;
using inventory_project.model;
using inventory_project.controller;
using System.Linq;

namespace inventory_project.view
{
    public partial class outvoice : Form
    {
        int total;
        int c;
        StockController sc = new StockController();
        BillsController bc = new BillsController();
        public outvoice()
        {
            InitializeComponent();
        }

        private void GoStock_Click(object sender, EventArgs e)
        {
            stock s = new stock();
            s.Show();
            Products.DataSource = sc.SelectAll();
            
           
            
        }

        private void outvoice_Load(object sender, EventArgs e)
        {
            dgv_outvoice.DataSource = bc.SelectAll("outvoice");
            Products.ValueMember = "id";
            Products.DisplayMember = "name";
            Products.DataSource = sc.SelectAll();
            checkPermission();
        }

        private void AddToOutvoice_Click(object sender, EventArgs e)
        {
            if (Products.SelectedIndex == -1 || Unit_Price.Text == "" || Quantity.Text == "" || Date.Text == "" || Reciever.Text == "")
            {
                MessageBox.Show("Inputs cant be empty", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float total = float.Parse(Unit_Price.Text) * Int32.Parse(Quantity.Text);
                bc.insert("outvoice", Int32.Parse(Products.SelectedValue.ToString()), float.Parse(Unit_Price.Text), Int32.Parse(Quantity.Text), total, Date.Text, Reciever.Text);
                dgv_outvoice.DataSource = bc.SelectAll("outvoice");
            }


        }

        private void UpdateOutvoice_Click(object sender, EventArgs e)
        {
            if (Products.SelectedIndex == -1 || Unit_Price.Text == "" || Quantity.Text == "" || Date.Text == "" || Reciever.Text == "")
            {
                MessageBox.Show("Inputs cant be empty", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float total = float.Parse(Unit_Price.Text) * Int32.Parse(Quantity.Text);
                bc.update("outvoice", Int32.Parse(Bill_Id.Text), Int32.Parse(Products.SelectedValue.ToString()), float.Parse(Unit_Price.Text), Int32.Parse(Quantity.Text), total, Date.Text, Reciever.Text);
                dgv_outvoice.DataSource = bc.SelectAll("outvoice");
            }

        }

        private void dgv_outvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Bill_Id.Text = Convert.ToString(dgv_outvoice.CurrentRow.Cells[0].Value);
                Products.SelectedValue = dgv_outvoice.CurrentRow.Cells[1].Value;
                Unit_Price.Text = Convert.ToString(dgv_outvoice.CurrentRow.Cells[2].Value);
                Quantity.Text = Convert.ToString(dgv_outvoice.CurrentRow.Cells[3].Value);
                Date.Text = Convert.ToString(dgv_outvoice.CurrentRow.Cells[5].Value);
                Reciever.Text = Convert.ToString(dgv_outvoice.CurrentRow.Cells[6].Value);
            }
        }

        private void DeleteOutvoice_Click(object sender, EventArgs e)
        {
            bc.delete("outvoice", Int32.Parse(Bill_Id.Text));
            dgv_outvoice.DataSource = bc.SelectAll("outvoice");
        }

        private void SearchForInvoice_Click(object sender, EventArgs e)
        {
            Bills bl = bc.search("outvoice", Int32.Parse(Search.Text));
            if (bl != null)
            {
                Bill_Id.Text = bl.bill_id.ToString();
                Products.SelectedValue = bl.product_id;
                Unit_Price.Text = bl.unit_price.ToString();
                Quantity.Text = bl.quantity.ToString();
                Reciever.Text = bl.client;
                Date.Text = bl.date;
            }
        }
        public void checkPermission()
        {
            Permissions pr = Program.list.SingleOrDefault(r => r.roll_id == "bills_viewonly");
            if (pr != null)
            {
                GoStock.Enabled = false;
                pr.roll_id = null;
            }
            pr = Program.list.SingleOrDefault(r => r.roll_id == "bills_insert");
            if (pr != null)
            {
                AddToOutvoice.Enabled = true;
                pr.roll_id = null;
            }

            pr = Program.list.SingleOrDefault(r => r.roll_id == "bills_update");
            if (pr != null)
            {
                UpdateOutvoice.Enabled = true;
                pr.roll_id = null;
            }
            pr = Program.list.SingleOrDefault(r => r.roll_id == "bills_delete");
            if (pr != null)
            {
                DeleteOutvoice.Enabled = true;
                pr.roll_id = null;
            }
        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quantity.Text = bc.getQuantity(Int32.Parse(Products.SelectedValue.ToString())).ToString();
            total = Int32.Parse(Quantity.Text);
            c = total;
            if (c == 0)
            {
                AddToOutvoice.Enabled = false; 
            }
            else
            {
                AddToOutvoice.Enabled = true;
            }
        }

        private void Increase_Click(object sender, EventArgs e)
        {
            
            if (c < total)
            {
                c++;
                Decrease.Enabled = true;
                Quantity.Text = c.ToString();
            }
            if (c == total)
            {
                Increase.Enabled = false;
            }
        }

        private void Decrease_Click(object sender, EventArgs e)
        {
            
            if (c <= total && c != 0)
            {
                c--;
                Increase.Enabled = true;
                Quantity.Text = c.ToString();
            }
            if (c == 0)
            {
                Decrease.Enabled = false;
            }

        }
        public void Reset()
        {
            Bill_Id.Text = "";
            Products.SelectedIndex = -1;
            Unit_Price.Text = "";
            Quantity.Text = "";
            Date.Text = "";
            Reciever.Text = "";
        }
    }
}
