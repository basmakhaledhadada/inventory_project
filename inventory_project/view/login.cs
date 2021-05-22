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
    public partial class login : Form
    {
        UsersController u = new UsersController();
        PermissionController pc = new PermissionController();
        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
        }

        private void log_Click(object sender, EventArgs e)
        {
            int id = u.auth(email.Text, password.Text);
            if (id != 0)
            {
                this.Hide();
                home h = new home();
                h.ShowDialog();
                SESSION.Id = id;


                
                
            }
            else
            {
                MessageBox.Show("Email or password are not correct");
            }
        }
    }
}
