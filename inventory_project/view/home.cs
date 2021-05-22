using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_project.view
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            //var db = DBconn.Connection;

            //if (DBconn.CheckMySqlConnection("datasource=localhost;port=3306;username=root;password="))
            //{
            //    label2.Text = "success!";
            //}
            //else
            //{
            //    label2.Text = "faild!";
            //}


        }

        private void GoUsers_Click(object sender, EventArgs e)
        {
            users userform = new users();
            userform.Show();
            
        }

        private void GoStock_Click(object sender, EventArgs e)
        {
            stock stockform = new stock();
            stockform.Show();
        }

        private void GoInvoice_Click(object sender, EventArgs e)
        {
            invoice billform = new invoice();
            billform.Show();
        }

        private void GoOutvoice_Click(object sender, EventArgs e)
        {
            outvoice billform = new outvoice();
            billform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
        }
    }
}
