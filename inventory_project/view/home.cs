using System;
using System.Windows.Forms;

namespace inventory_project.view
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
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

        private void Logout_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.ShowDialog();
        }
    }
}
