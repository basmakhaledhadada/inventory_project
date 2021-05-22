using System;

using System.Windows.Forms;
using inventory_project.model;
using inventory_project.controller;

namespace inventory_project.view
{
    public partial class invoice : Form
    {
        StockController sc = new StockController();
        BillsController bc = new BillsController();


        public invoice()
        {
            InitializeComponent();
        }

        private void invoice_Load(object sender, EventArgs e)
        {
            dgv_invoice.DataSource = bc.SelectAll("invoice");
            Products.ValueMember = "id";
            Products.DisplayMember = "name";
            Products.DataSource = sc.SelectAll();
        }



        private void GoStock_Click(object sender, EventArgs e)
        {
            stock s = new stock();
            s.Show();
            Products.DataSource = sc.SelectAll();
        }

        private void AddToInvoice_Click(object sender, EventArgs e)
        {
            float total = float.Parse(Unit_Price.Text) * Int32.Parse(Quantity.Text);
            bc.insert("invoice", Int32.Parse(Products.SelectedValue.ToString()), float.Parse(Unit_Price.Text), Int32.Parse(Quantity.Text), total, Date.Text, Provider.Text);
            dgv_invoice.DataSource = bc.SelectAll("invoice");
        }

        private void UpdateInvoice_Click(object sender, EventArgs e)
        {
            float total = float.Parse(Unit_Price.Text) * Int32.Parse(Quantity.Text);
            bc.update("invoice", Int32.Parse(Bill_Id.Text), Int32.Parse(Products.SelectedValue.ToString()), float.Parse(Unit_Price.Text), Int32.Parse(Quantity.Text), total, Date.Text, Provider.Text);
            dgv_invoice.DataSource = bc.SelectAll("invoice");
        }

        private void DeleteInvoice_Click(object sender, EventArgs e)
        {
            bc.delete("invoice", Int32.Parse(Bill_Id.Text));
            dgv_invoice.DataSource = bc.SelectAll("invoice");
        }

        private void dgv_invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Bill_Id.Text = Convert.ToString(dgv_invoice.CurrentRow.Cells[0].Value);
                Products.SelectedValue = dgv_invoice.CurrentRow.Cells[1].Value;
                Unit_Price.Text = Convert.ToString(dgv_invoice.CurrentRow.Cells[2].Value);
                Quantity.Text = Convert.ToString(dgv_invoice.CurrentRow.Cells[3].Value);
                Date.Text = Convert.ToString(dgv_invoice.CurrentRow.Cells[5].Value);
                Provider.Text = Convert.ToString(dgv_invoice.CurrentRow.Cells[6].Value);
            }
        }

        private void SearchForInvoice_Click(object sender, EventArgs e)
        {
            Bills bl = bc.search("invoice", Int32.Parse(Search.Text));
            if (bl != null)
            {
                Bill_Id.Text = bl.bill_id.ToString();
                Products.SelectedValue = bl.product_id;
                Unit_Price.Text = bl.unit_price.ToString();
                Quantity.Text = bl.quantity.ToString();
                Provider.Text = bl.client;
                Date.Text = bl.date;
            }
        }
    }
}
