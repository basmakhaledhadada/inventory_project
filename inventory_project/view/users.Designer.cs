
namespace inventory_project.view
{
    partial class users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchForUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.TextBox();
            this.UpdateUsers = new System.Windows.Forms.Button();
            this.DeleteUsers = new System.Windows.Forms.Button();
            this.AddToUsers = new System.Windows.Forms.Button();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.User_Id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StockPermission = new System.Windows.Forms.GroupBox();
            this.Delete_Stock = new System.Windows.Forms.CheckBox();
            this.Update_Stock = new System.Windows.Forms.CheckBox();
            this.ViewOnly_Stock = new System.Windows.Forms.CheckBox();
            this.Insert_Stock = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete_Bills = new System.Windows.Forms.CheckBox();
            this.ViewOnly_Bills = new System.Windows.Forms.CheckBox();
            this.Update_Bills = new System.Windows.Forms.CheckBox();
            this.Insert_Bills = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Delete_Users = new System.Windows.Forms.CheckBox();
            this.ViewOnly_Users = new System.Windows.Forms.CheckBox();
            this.Update_Users = new System.Windows.Forms.CheckBox();
            this.Insert_Users = new System.Windows.Forms.CheckBox();
            this.dgv_permissions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StockPermission.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permissions)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "User Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "User Name";
            // 
            // dgv_users
            // 
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(0, 311);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.Size = new System.Drawing.Size(730, 187);
            this.dgv_users.TabIndex = 29;
            this.dgv_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Looking for something?";
            // 
            // SearchForUser
            // 
            this.SearchForUser.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForUser.Location = new System.Drawing.Point(17, 54);
            this.SearchForUser.Name = "SearchForUser";
            this.SearchForUser.Size = new System.Drawing.Size(80, 28);
            this.SearchForUser.TabIndex = 13;
            this.SearchForUser.Text = "Search";
            this.SearchForUser.UseVisualStyleBackColor = true;
            this.SearchForUser.Click += new System.EventHandler(this.SearchForUser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SearchForUser);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.UpdateUsers);
            this.panel2.Controls.Add(this.DeleteUsers);
            this.panel2.Controls.Add(this.AddToUsers);
            this.panel2.Location = new System.Drawing.Point(728, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 244);
            this.panel2.TabIndex = 25;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(17, 28);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(168, 20);
            this.Search.TabIndex = 12;
            // 
            // UpdateUsers
            // 
            this.UpdateUsers.Enabled = false;
            this.UpdateUsers.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUsers.Location = new System.Drawing.Point(55, 154);
            this.UpdateUsers.Name = "UpdateUsers";
            this.UpdateUsers.Size = new System.Drawing.Size(100, 30);
            this.UpdateUsers.TabIndex = 10;
            this.UpdateUsers.Text = "Update";
            this.UpdateUsers.UseVisualStyleBackColor = true;
            this.UpdateUsers.Click += new System.EventHandler(this.UpdateUsers_Click);
            // 
            // DeleteUsers
            // 
            this.DeleteUsers.Enabled = false;
            this.DeleteUsers.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUsers.Location = new System.Drawing.Point(55, 190);
            this.DeleteUsers.Name = "DeleteUsers";
            this.DeleteUsers.Size = new System.Drawing.Size(100, 30);
            this.DeleteUsers.TabIndex = 11;
            this.DeleteUsers.Text = "Delete";
            this.DeleteUsers.UseVisualStyleBackColor = true;
            this.DeleteUsers.Click += new System.EventHandler(this.DeleteUsers_Click);
            // 
            // AddToUsers
            // 
            this.AddToUsers.Enabled = false;
            this.AddToUsers.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToUsers.Location = new System.Drawing.Point(55, 118);
            this.AddToUsers.Name = "AddToUsers";
            this.AddToUsers.Size = new System.Drawing.Size(100, 30);
            this.AddToUsers.TabIndex = 9;
            this.AddToUsers.Text = "Add";
            this.AddToUsers.UseVisualStyleBackColor = true;
            this.AddToUsers.Click += new System.EventHandler(this.AddToUsers_Click);
            // 
            // User_Name
            // 
            this.User_Name.Location = new System.Drawing.Point(117, 95);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(154, 20);
            this.User_Name.TabIndex = 26;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(322, 95);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(154, 20);
            this.Email.TabIndex = 24;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(117, 143);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(154, 20);
            this.Password.TabIndex = 23;
            // 
            // User_Id
            // 
            this.User_Id.Location = new System.Drawing.Point(15, 95);
            this.User_Id.Name = "User_Id";
            this.User_Id.Size = new System.Drawing.Size(53, 20);
            this.User_Id.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 67);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(288, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "USERS MANAGMENT";
            // 
            // StockPermission
            // 
            this.StockPermission.Controls.Add(this.Delete_Stock);
            this.StockPermission.Controls.Add(this.Update_Stock);
            this.StockPermission.Controls.Add(this.ViewOnly_Stock);
            this.StockPermission.Controls.Add(this.Insert_Stock);
            this.StockPermission.Location = new System.Drawing.Point(95, 187);
            this.StockPermission.Name = "StockPermission";
            this.StockPermission.Size = new System.Drawing.Size(154, 100);
            this.StockPermission.TabIndex = 49;
            this.StockPermission.TabStop = false;
            this.StockPermission.Text = "Stock Management";
            // 
            // Delete_Stock
            // 
            this.Delete_Stock.AutoSize = true;
            this.Delete_Stock.Location = new System.Drawing.Point(6, 71);
            this.Delete_Stock.Name = "Delete_Stock";
            this.Delete_Stock.Size = new System.Drawing.Size(57, 17);
            this.Delete_Stock.TabIndex = 55;
            this.Delete_Stock.Text = "Delete";
            this.Delete_Stock.UseVisualStyleBackColor = true;
            // 
            // Update_Stock
            // 
            this.Update_Stock.AutoSize = true;
            this.Update_Stock.Location = new System.Drawing.Point(6, 55);
            this.Update_Stock.Name = "Update_Stock";
            this.Update_Stock.Size = new System.Drawing.Size(61, 17);
            this.Update_Stock.TabIndex = 54;
            this.Update_Stock.Text = "Update";
            this.Update_Stock.UseVisualStyleBackColor = true;
            // 
            // ViewOnly_Stock
            // 
            this.ViewOnly_Stock.AutoSize = true;
            this.ViewOnly_Stock.Location = new System.Drawing.Point(6, 23);
            this.ViewOnly_Stock.Name = "ViewOnly_Stock";
            this.ViewOnly_Stock.Size = new System.Drawing.Size(73, 17);
            this.ViewOnly_Stock.TabIndex = 52;
            this.ViewOnly_Stock.Text = "View Only";
            this.ViewOnly_Stock.UseVisualStyleBackColor = true;
            this.ViewOnly_Stock.CheckStateChanged += new System.EventHandler(this.ViewOnly_Stock_CheckStateChanged);
            // 
            // Insert_Stock
            // 
            this.Insert_Stock.AutoSize = true;
            this.Insert_Stock.Location = new System.Drawing.Point(6, 39);
            this.Insert_Stock.Name = "Insert_Stock";
            this.Insert_Stock.Size = new System.Drawing.Size(52, 17);
            this.Insert_Stock.TabIndex = 53;
            this.Insert_Stock.Text = "Insert";
            this.Insert_Stock.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete_Bills);
            this.groupBox2.Controls.Add(this.ViewOnly_Bills);
            this.groupBox2.Controls.Add(this.Update_Bills);
            this.groupBox2.Controls.Add(this.Insert_Bills);
            this.groupBox2.Location = new System.Drawing.Point(280, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 100);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bills Management";
            // 
            // Delete_Bills
            // 
            this.Delete_Bills.AutoSize = true;
            this.Delete_Bills.Location = new System.Drawing.Point(6, 71);
            this.Delete_Bills.Name = "Delete_Bills";
            this.Delete_Bills.Size = new System.Drawing.Size(57, 17);
            this.Delete_Bills.TabIndex = 59;
            this.Delete_Bills.Text = "Delete";
            this.Delete_Bills.UseVisualStyleBackColor = true;
            // 
            // ViewOnly_Bills
            // 
            this.ViewOnly_Bills.AutoSize = true;
            this.ViewOnly_Bills.Location = new System.Drawing.Point(6, 23);
            this.ViewOnly_Bills.Name = "ViewOnly_Bills";
            this.ViewOnly_Bills.Size = new System.Drawing.Size(73, 17);
            this.ViewOnly_Bills.TabIndex = 56;
            this.ViewOnly_Bills.Text = "View Only";
            this.ViewOnly_Bills.UseVisualStyleBackColor = true;
            this.ViewOnly_Bills.CheckStateChanged += new System.EventHandler(this.ViewOnly_Bills_CheckStateChanged);
            // 
            // Update_Bills
            // 
            this.Update_Bills.AutoSize = true;
            this.Update_Bills.Location = new System.Drawing.Point(6, 55);
            this.Update_Bills.Name = "Update_Bills";
            this.Update_Bills.Size = new System.Drawing.Size(61, 17);
            this.Update_Bills.TabIndex = 58;
            this.Update_Bills.Text = "Update";
            this.Update_Bills.UseVisualStyleBackColor = true;
            // 
            // Insert_Bills
            // 
            this.Insert_Bills.AutoSize = true;
            this.Insert_Bills.Location = new System.Drawing.Point(6, 39);
            this.Insert_Bills.Name = "Insert_Bills";
            this.Insert_Bills.Size = new System.Drawing.Size(52, 17);
            this.Insert_Bills.TabIndex = 57;
            this.Insert_Bills.Text = "Insert";
            this.Insert_Bills.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Delete_Users);
            this.groupBox3.Controls.Add(this.ViewOnly_Users);
            this.groupBox3.Controls.Add(this.Update_Users);
            this.groupBox3.Controls.Add(this.Insert_Users);
            this.groupBox3.Location = new System.Drawing.Point(467, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 100);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Users Management";
            // 
            // Delete_Users
            // 
            this.Delete_Users.AutoSize = true;
            this.Delete_Users.Location = new System.Drawing.Point(6, 71);
            this.Delete_Users.Name = "Delete_Users";
            this.Delete_Users.Size = new System.Drawing.Size(57, 17);
            this.Delete_Users.TabIndex = 59;
            this.Delete_Users.Text = "Delete";
            this.Delete_Users.UseVisualStyleBackColor = true;
            // 
            // ViewOnly_Users
            // 
            this.ViewOnly_Users.AutoSize = true;
            this.ViewOnly_Users.Location = new System.Drawing.Point(6, 23);
            this.ViewOnly_Users.Name = "ViewOnly_Users";
            this.ViewOnly_Users.Size = new System.Drawing.Size(73, 17);
            this.ViewOnly_Users.TabIndex = 56;
            this.ViewOnly_Users.Text = "View Only";
            this.ViewOnly_Users.UseVisualStyleBackColor = true;
            this.ViewOnly_Users.CheckStateChanged += new System.EventHandler(this.ViewOnly_Users_CheckStateChanged);
            // 
            // Update_Users
            // 
            this.Update_Users.AutoSize = true;
            this.Update_Users.Location = new System.Drawing.Point(6, 55);
            this.Update_Users.Name = "Update_Users";
            this.Update_Users.Size = new System.Drawing.Size(61, 17);
            this.Update_Users.TabIndex = 58;
            this.Update_Users.Text = "Update";
            this.Update_Users.UseVisualStyleBackColor = true;
            // 
            // Insert_Users
            // 
            this.Insert_Users.AutoSize = true;
            this.Insert_Users.Location = new System.Drawing.Point(6, 39);
            this.Insert_Users.Name = "Insert_Users";
            this.Insert_Users.Size = new System.Drawing.Size(52, 17);
            this.Insert_Users.TabIndex = 57;
            this.Insert_Users.Text = "Insert";
            this.Insert_Users.UseVisualStyleBackColor = true;
            // 
            // dgv_permissions
            // 
            this.dgv_permissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_permissions.Location = new System.Drawing.Point(728, 311);
            this.dgv_permissions.Name = "dgv_permissions";
            this.dgv_permissions.Size = new System.Drawing.Size(207, 187);
            this.dgv_permissions.TabIndex = 61;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 498);
            this.Controls.Add(this.dgv_permissions);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.StockPermission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User_Id);
            this.Controls.Add(this.panel1);
            this.Name = "users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "users";
            this.Load += new System.EventHandler(this.users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StockPermission.ResumeLayout(false);
            this.StockPermission.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchForUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button UpdateUsers;
        private System.Windows.Forms.Button DeleteUsers;
        private System.Windows.Forms.Button AddToUsers;
        private System.Windows.Forms.TextBox User_Name;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox User_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox StockPermission;
        private System.Windows.Forms.CheckBox Delete_Stock;
        private System.Windows.Forms.CheckBox Update_Stock;
        private System.Windows.Forms.CheckBox ViewOnly_Stock;
        private System.Windows.Forms.CheckBox Insert_Stock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Delete_Bills;
        private System.Windows.Forms.CheckBox ViewOnly_Bills;
        private System.Windows.Forms.CheckBox Update_Bills;
        private System.Windows.Forms.CheckBox Insert_Bills;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Delete_Users;
        private System.Windows.Forms.CheckBox ViewOnly_Users;
        private System.Windows.Forms.CheckBox Update_Users;
        private System.Windows.Forms.CheckBox Insert_Users;
        private System.Windows.Forms.DataGridView dgv_permissions;
    }
}