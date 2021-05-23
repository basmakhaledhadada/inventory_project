
namespace inventory_project.view
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.GoUsers = new System.Windows.Forms.Button();
            this.GoStock = new System.Windows.Forms.Button();
            this.GoInvoice = new System.Windows.Forms.Button();
            this.GoOutvoice = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(288, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "INVENTORY MANAGMENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(632, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(219, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 149);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // GoUsers
            // 
            this.GoUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GoUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoUsers.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoUsers.ForeColor = System.Drawing.Color.White;
            this.GoUsers.Location = new System.Drawing.Point(12, 318);
            this.GoUsers.Name = "GoUsers";
            this.GoUsers.Size = new System.Drawing.Size(150, 38);
            this.GoUsers.TabIndex = 5;
            this.GoUsers.Text = "Users";
            this.GoUsers.UseVisualStyleBackColor = false;
            this.GoUsers.Click += new System.EventHandler(this.GoUsers_Click);
            // 
            // GoStock
            // 
            this.GoStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GoStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoStock.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoStock.ForeColor = System.Drawing.Color.White;
            this.GoStock.Location = new System.Drawing.Point(219, 318);
            this.GoStock.Name = "GoStock";
            this.GoStock.Size = new System.Drawing.Size(150, 38);
            this.GoStock.TabIndex = 6;
            this.GoStock.Text = "Stock Management";
            this.GoStock.UseVisualStyleBackColor = false;
            this.GoStock.Click += new System.EventHandler(this.GoStock_Click);
            // 
            // GoInvoice
            // 
            this.GoInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GoInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoInvoice.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoInvoice.ForeColor = System.Drawing.Color.White;
            this.GoInvoice.Location = new System.Drawing.Point(426, 318);
            this.GoInvoice.Name = "GoInvoice";
            this.GoInvoice.Size = new System.Drawing.Size(150, 38);
            this.GoInvoice.TabIndex = 7;
            this.GoInvoice.Text = "Invoice Bills";
            this.GoInvoice.UseVisualStyleBackColor = false;
            this.GoInvoice.Click += new System.EventHandler(this.GoInvoice_Click);
            // 
            // GoOutvoice
            // 
            this.GoOutvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GoOutvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoOutvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoOutvoice.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoOutvoice.ForeColor = System.Drawing.Color.White;
            this.GoOutvoice.Location = new System.Drawing.Point(632, 318);
            this.GoOutvoice.Name = "GoOutvoice";
            this.GoOutvoice.Size = new System.Drawing.Size(150, 38);
            this.GoOutvoice.TabIndex = 8;
            this.GoOutvoice.Text = "Outvoice Bills";
            this.GoOutvoice.UseVisualStyleBackColor = false;
            this.GoOutvoice.Click += new System.EventHandler(this.GoOutvoice_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Cairo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(632, 423);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(150, 38);
            this.Logout.TabIndex = 9;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 473);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.GoOutvoice);
            this.Controls.Add(this.GoInvoice);
            this.Controls.Add(this.GoStock);
            this.Controls.Add(this.GoUsers);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button GoUsers;
        private System.Windows.Forms.Button GoStock;
        private System.Windows.Forms.Button GoInvoice;
        private System.Windows.Forms.Button GoOutvoice;
        private System.Windows.Forms.Button Logout;
    }
}