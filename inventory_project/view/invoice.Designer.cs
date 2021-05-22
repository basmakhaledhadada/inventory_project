
namespace inventory_project.view
{
    partial class invoice
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_invoice = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchForInvoice = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.TextBox();
            this.UpdateInvoice = new System.Windows.Forms.Button();
            this.DeleteInvoice = new System.Windows.Forms.Button();
            this.AddToInvoice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Unit_Price = new System.Windows.Forms.TextBox();
            this.Provider = new System.Windows.Forms.TextBox();
            this.Bill_Id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Products = new System.Windows.Forms.ComboBox();
            this.GoStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Provider";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Bill Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Product Name";
            // 
            // dgv_invoice
            // 
            this.dgv_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoice.Location = new System.Drawing.Point(0, 307);
            this.dgv_invoice.Name = "dgv_invoice";
            this.dgv_invoice.Size = new System.Drawing.Size(794, 159);
            this.dgv_invoice.TabIndex = 29;
            this.dgv_invoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_invoice_CellClick);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SearchForInvoice);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.UpdateInvoice);
            this.panel2.Controls.Add(this.DeleteInvoice);
            this.panel2.Controls.Add(this.AddToInvoice);
            this.panel2.Location = new System.Drawing.Point(595, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 244);
            this.panel2.TabIndex = 25;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(17, 28);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(168, 20);
            this.Search.TabIndex = 12;
            // 
            // UpdateInvoice
            // 
            this.UpdateInvoice.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateInvoice.Location = new System.Drawing.Point(55, 154);
            this.UpdateInvoice.Name = "UpdateInvoice";
            this.UpdateInvoice.Size = new System.Drawing.Size(100, 30);
            this.UpdateInvoice.TabIndex = 10;
            this.UpdateInvoice.Text = "Update";
            this.UpdateInvoice.UseVisualStyleBackColor = true;
            this.UpdateInvoice.Click += new System.EventHandler(this.UpdateInvoice_Click);
            // 
            // DeleteInvoice
            // 
            this.DeleteInvoice.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInvoice.Location = new System.Drawing.Point(55, 190);
            this.DeleteInvoice.Name = "DeleteInvoice";
            this.DeleteInvoice.Size = new System.Drawing.Size(100, 30);
            this.DeleteInvoice.TabIndex = 11;
            this.DeleteInvoice.Text = "Delete";
            this.DeleteInvoice.UseVisualStyleBackColor = true;
            this.DeleteInvoice.Click += new System.EventHandler(this.DeleteInvoice_Click);
            // 
            // AddToInvoice
            // 
            this.AddToInvoice.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToInvoice.Location = new System.Drawing.Point(55, 118);
            this.AddToInvoice.Name = "AddToInvoice";
            this.AddToInvoice.Size = new System.Drawing.Size(100, 30);
            this.AddToInvoice.TabIndex = 9;
            this.AddToInvoice.Text = "Add";
            this.AddToInvoice.UseVisualStyleBackColor = true;
            this.AddToInvoice.Click += new System.EventHandler(this.AddToInvoice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quantity";
            // 
            // Unit_Price
            // 
            this.Unit_Price.Location = new System.Drawing.Point(333, 95);
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.Size = new System.Drawing.Size(154, 20);
            this.Unit_Price.TabIndex = 24;
            // 
            // Provider
            // 
            this.Provider.Location = new System.Drawing.Point(333, 143);
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(154, 20);
            this.Provider.TabIndex = 23;
            // 
            // Bill_Id
            // 
            this.Bill_Id.Location = new System.Drawing.Point(15, 95);
            this.Bill_Id.Name = "Bill_Id";
            this.Bill_Id.Size = new System.Drawing.Size(53, 20);
            this.Bill_Id.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 67);
            this.panel1.TabIndex = 21;
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
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(117, 143);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(154, 20);
            this.Quantity.TabIndex = 36;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(117, 198);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 37;
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(117, 94);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(154, 21);
            this.Products.TabIndex = 38;
            // 
            // GoStock
            // 
            this.GoStock.Location = new System.Drawing.Point(277, 95);
            this.GoStock.Name = "GoStock";
            this.GoStock.Size = new System.Drawing.Size(50, 23);
            this.GoStock.TabIndex = 55;
            this.GoStock.Text = "Edit";
            this.GoStock.UseVisualStyleBackColor = true;
            this.GoStock.Click += new System.EventHandler(this.GoStock_Click);
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 466);
            this.Controls.Add(this.GoStock);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_invoice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Unit_Price);
            this.Controls.Add(this.Provider);
            this.Controls.Add(this.Bill_Id);
            this.Controls.Add(this.panel1);
            this.Name = "invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_invoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchForInvoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button UpdateInvoice;
        private System.Windows.Forms.Button DeleteInvoice;
        private System.Windows.Forms.Button AddToInvoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Unit_Price;
        private System.Windows.Forms.TextBox Provider;
        private System.Windows.Forms.TextBox Bill_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox Products;
        private System.Windows.Forms.Button GoStock;
    }
}