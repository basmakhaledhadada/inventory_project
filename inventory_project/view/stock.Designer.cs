
namespace inventory_project.view
{
    partial class stock
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Product_Id = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Unit_Price = new System.Windows.Forms.TextBox();
            this.Product_Name = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.AddToStock = new System.Windows.Forms.Button();
            this.UpdateForStock = new System.Windows.Forms.Button();
            this.DeleteForStock = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchForStock = new System.Windows.Forms.Button();
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(288, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "STOCK MANAGMENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 67);
            this.panel1.TabIndex = 1;
            // 
            // Product_Id
            // 
            this.Product_Id.Enabled = false;
            this.Product_Id.Location = new System.Drawing.Point(15, 96);
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.Size = new System.Drawing.Size(53, 20);
            this.Product_Id.TabIndex = 2;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(348, 144);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(85, 20);
            this.Quantity.TabIndex = 4;
            // 
            // Unit_Price
            // 
            this.Unit_Price.Location = new System.Drawing.Point(348, 96);
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.Size = new System.Drawing.Size(85, 20);
            this.Unit_Price.TabIndex = 5;
            // 
            // Product_Name
            // 
            this.Product_Name.Location = new System.Drawing.Point(117, 96);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(154, 20);
            this.Product_Name.TabIndex = 6;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "clean",
            "toys",
            "food"});
            this.Category.Location = new System.Drawing.Point(117, 144);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(154, 21);
            this.Category.TabIndex = 7;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(117, 215);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(154, 73);
            this.Description.TabIndex = 8;
            this.Description.Text = "";
            // 
            // AddToStock
            // 
            this.AddToStock.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToStock.Location = new System.Drawing.Point(55, 118);
            this.AddToStock.Name = "AddToStock";
            this.AddToStock.Size = new System.Drawing.Size(100, 30);
            this.AddToStock.TabIndex = 9;
            this.AddToStock.Text = "Add";
            this.AddToStock.UseVisualStyleBackColor = true;
            this.AddToStock.Click += new System.EventHandler(this.AddToStock_Click);
            // 
            // UpdateForStock
            // 
            this.UpdateForStock.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateForStock.Location = new System.Drawing.Point(55, 154);
            this.UpdateForStock.Name = "UpdateForStock";
            this.UpdateForStock.Size = new System.Drawing.Size(100, 30);
            this.UpdateForStock.TabIndex = 10;
            this.UpdateForStock.Text = "Update";
            this.UpdateForStock.UseVisualStyleBackColor = true;
            this.UpdateForStock.Click += new System.EventHandler(this.UpdateForStock_Click);
            // 
            // DeleteForStock
            // 
            this.DeleteForStock.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteForStock.Location = new System.Drawing.Point(55, 190);
            this.DeleteForStock.Name = "DeleteForStock";
            this.DeleteForStock.Size = new System.Drawing.Size(100, 30);
            this.DeleteForStock.TabIndex = 11;
            this.DeleteForStock.Text = "Delete";
            this.DeleteForStock.UseVisualStyleBackColor = true;
            this.DeleteForStock.Click += new System.EventHandler(this.DeleteForStock_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(17, 28);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(168, 20);
            this.Search.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SearchForStock);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.UpdateForStock);
            this.panel2.Controls.Add(this.DeleteForStock);
            this.panel2.Controls.Add(this.AddToStock);
            this.panel2.Location = new System.Drawing.Point(595, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 244);
            this.panel2.TabIndex = 6;
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
            // SearchForStock
            // 
            this.SearchForStock.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchForStock.Location = new System.Drawing.Point(17, 54);
            this.SearchForStock.Name = "SearchForStock";
            this.SearchForStock.Size = new System.Drawing.Size(80, 28);
            this.SearchForStock.TabIndex = 13;
            this.SearchForStock.Text = "Search";
            this.SearchForStock.UseVisualStyleBackColor = true;
            this.SearchForStock.Click += new System.EventHandler(this.SearchForStock_Click);
            // 
            // dgv_stock
            // 
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(0, 312);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.Size = new System.Drawing.Size(794, 140);
            this.dgv_stock.TabIndex = 9;
            this.dgv_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stock_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Product Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Description";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(278, 144);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(50, 23);
            this.Edit.TabIndex = 21;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 452);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_stock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Product_Name);
            this.Controls.Add(this.Unit_Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Product_Id);
            this.Controls.Add(this.panel1);
            this.Name = "stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stock";
            this.Load += new System.EventHandler(this.stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Product_Id;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Unit_Price;
        private System.Windows.Forms.TextBox Product_Name;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button AddToStock;
        private System.Windows.Forms.Button UpdateForStock;
        private System.Windows.Forms.Button DeleteForStock;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SearchForStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Edit;
    }
}