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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }
        private void stock_Load(object sender, EventArgs e)
        {
            StockController sc = new StockController();
            dgv_stock.DataSource = sc.SelectAll();
        }
    }
}
