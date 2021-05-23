using System;
using System.Drawing;
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
            password.PasswordChar = '*';
        }

        private void log_Click(object sender, EventArgs e)
        {
            int id = u.auth(email.Text, password.Text);
            if (id != 0)
            {
                Program.user_id = id;
                Program.list = pc.SelectAll(Program.user_id);
                this.Hide();
                home h = new home();
                h.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("email or password are not correct", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
