
namespace inventory_project.view
{
    partial class outvoice
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Unit_Price = new System.Windows.Forms.TextBox();
            this.Reciever = new System.Windows.Forms.TextBox();
            this.Bill_Id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchForInvoice = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateOutvoice = new System.Windows.Forms.Button();
            this.AddToOutvoice = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_outvoice = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteOutvoice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.ComboBox();
            this.GoStock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outvoice)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(117, 199);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(296, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bill MANAGMENT";
            // 
            // Unit_Price
            // 
            this.Unit_Price.Location = new System.Drawing.Point(346, 94);
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.Size = new System.Drawing.Size(154, 20);
            this.Unit_Price.TabIndex = 41;
            // 
            // Reciever
            // 
            this.Reciever.Location = new System.Drawing.Point(346, 143);
            this.Reciever.Name = "Reciever";
            this.Reciever.Size = new System.Drawing.Size(154, 20);
            this.Reciever.TabIndex = 40;
            // 
            // Bill_Id
            // 
            this.Bill_Id.Enabled = false;
            this.Bill_Id.Location = new System.Drawing.Point(15, 95);
            this.Bill_Id.Name = "Bill_Id";
            this.Bill_Id.Size = new System.Drawing.Size(53, 20);
            this.Bill_Id.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 67);
            this.panel1.TabIndex = 38;
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
            // SearchForInvoice
            // 
            this.SearchForInvoice.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForInvoice.Location = new System.Drawing.Point(17, 54);
            this.SearchForInvoice.Name = "SearchForInvoice";
            this.SearchForInvoice.Size = new System.Drawing.Size(80, 28);
            this.SearchForInvoice.TabIndex = 13;
            this.SearchForInvoice.Text = "Search";
            this.SearchForInvoice.UseVisualStyleBackColor = true;
            this.SearchForInvoice.Click += new System.EventHandler(this.SearchForInvoice_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(17, 28);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(168, 20);
            this.Search.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Quantity";
            // 
            // UpdateOutvoice
            // 
            this.UpdateOutvoice.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateOutvoice.Location = new System.Drawing.Point(55, 154);
            this.UpdateOutvoice.Name = "UpdateOutvoice";
            this.UpdateOutvoice.Size = new System.Drawing.Size(100, 30);
            this.UpdateOutvoice.TabIndex = 10;
            this.UpdateOutvoice.Text = "Update";
            this.UpdateOutvoice.UseVisualStyleBackColor = true;
            this.UpdateOutvoice.Click += new System.EventHandler(this.UpdateOutvoice_Click);
            // 
            // AddToOutvoice
            // 
            this.AddToOutvoice.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToOutvoice.Location = new System.Drawing.Point(55, 118);
            this.AddToOutvoice.Name = "AddToOutvoice";
            this.AddToOutvoice.Size = new System.Drawing.Size(100, 30);
            this.AddToOutvoice.TabIndex = 9;
            this.AddToOutvoice.Text = "Add";
            this.AddToOutvoice.UseVisualStyleBackColor = true;
            this.AddToOutvoice.Click += new System.EventHandler(this.AddToOutvoice_Click);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(117, 143);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(154, 20);
            this.Quantity.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Reciever";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Bill Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Product Name";
            // 
            // dgv_outvoice
            // 
            this.dgv_outvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_outvoice.Location = new System.Drawing.Point(0, 307);
            this.dgv_outvoice.Name = "dgv_outvoice";
            this.dgv_outvoice.Size = new System.Drawing.Size(794, 158);
            this.dgv_outvoice.TabIndex = 44;
            this.dgv_outvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_outvoice_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SearchForInvoice);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.UpdateOutvoice);
            this.panel2.Controls.Add(this.DeleteOutvoice);
            this.panel2.Controls.Add(this.AddToOutvoice);
            this.panel2.Location = new System.Drawing.Point(595, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 244);
            this.panel2.TabIndex = 42;
            // 
            // DeleteOutvoice
            // 
            this.DeleteOutvoice.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOutvoice.Location = new System.Drawing.Point(55, 190);
            this.DeleteOutvoice.Name = "DeleteOutvoice";
            this.DeleteOutvoice.Size = new System.Drawing.Size(100, 30);
            this.DeleteOutvoice.TabIndex = 11;
            this.DeleteOutvoice.Text = "Delete";
            this.DeleteOutvoice.UseVisualStyleBackColor = true;
            this.DeleteOutvoice.Click += new System.EventHandler(this.DeleteOutvoice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Date";
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(117, 94);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(154, 21);
            this.Products.TabIndex = 53;
            // 
            // GoStock
            // 
            this.GoStock.Location = new System.Drawing.Point(277, 92);
            this.GoStock.Name = "GoStock";
            this.GoStock.Size = new System.Drawing.Size(50, 23);
            this.GoStock.TabIndex = 54;
            this.GoStock.Text = "Edit";
            this.GoStock.UseVisualStyleBackColor = true;
            this.GoStock.Click += new System.EventHandler(this.GoStock_Click);
            // 
            // outvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 466);
            this.Controls.Add(this.GoStock);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Unit_Price);
            this.Controls.Add(this.Reciever);
            this.Controls.Add(this.Bill_Id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_outvoice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Name = "outvoice";
            this.Text = "outvoice";
            this.Load += new System.EventHandler(this.outvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_outvoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Unit_Price;
        private System.Windows.Forms.TextBox Reciever;
        private System.Windows.Forms.TextBox Bill_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchForInvoice;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UpdateOutvoice;
        private System.Windows.Forms.Button AddToOutvoice;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_outvoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteOutvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Products;
        private System.Windows.Forms.Button GoStock;
    }
}