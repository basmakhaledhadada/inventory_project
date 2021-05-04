﻿using System;
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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void users_Load(object sender, EventArgs e)
        {
            UsersController sc = new UsersController();
            dgv_users.DataSource = sc.SelectAll();
        }
    }
}
