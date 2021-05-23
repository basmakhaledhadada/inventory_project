namespace inventory_project.view
{
    partial class category
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateCategory = new System.Windows.Forms.Button();
            this.DeleteCategory = new System.Windows.Forms.Button();
            this.AddToCategory = new System.Windows.Forms.Button();
            this.Category_Name = new System.Windows.Forms.TextBox();
            this.Category_Id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Category Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Category Name";
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(3, 307);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.Size = new System.Drawing.Size(476, 98);
            this.dgv_category.TabIndex = 29;
            this.dgv_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.UpdateCategory);
            this.panel2.Controls.Add(this.DeleteCategory);
            this.panel2.Controls.Add(this.AddToCategory);
            this.panel2.Location = new System.Drawing.Point(280, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 244);
            this.panel2.TabIndex = 25;
            // 
            // UpdateCategory
            // 
            this.UpdateCategory.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategory.Location = new System.Drawing.Point(55, 154);
            this.UpdateCategory.Name = "UpdateCategory";
            this.UpdateCategory.Size = new System.Drawing.Size(100, 30);
            this.UpdateCategory.TabIndex = 10;
            this.UpdateCategory.Text = "Update";
            this.UpdateCategory.UseVisualStyleBackColor = true;
            this.UpdateCategory.Click += new System.EventHandler(this.UpdateCategory_Click);
            // 
            // DeleteCategory
            // 
            this.DeleteCategory.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCategory.Location = new System.Drawing.Point(55, 190);
            this.DeleteCategory.Name = "DeleteCategory";
            this.DeleteCategory.Size = new System.Drawing.Size(100, 30);
            this.DeleteCategory.TabIndex = 11;
            this.DeleteCategory.Text = "Delete";
            this.DeleteCategory.UseVisualStyleBackColor = true;
            this.DeleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // AddToCategory
            // 
            this.AddToCategory.Font = new System.Drawing.Font("Cairo SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCategory.Location = new System.Drawing.Point(55, 118);
            this.AddToCategory.Name = "AddToCategory";
            this.AddToCategory.Size = new System.Drawing.Size(100, 30);
            this.AddToCategory.TabIndex = 9;
            this.AddToCategory.Text = "Add";
            this.AddToCategory.UseVisualStyleBackColor = true;
            this.AddToCategory.Click += new System.EventHandler(this.AddToCategory_Click);
            // 
            // Category_Name
            // 
            this.Category_Name.Location = new System.Drawing.Point(18, 151);
            this.Category_Name.Name = "Category_Name";
            this.Category_Name.Size = new System.Drawing.Size(154, 20);
            this.Category_Name.TabIndex = 26;
            // 
            // Category_Id
            // 
            this.Category_Id.Enabled = false;
            this.Category_Id.Location = new System.Drawing.Point(18, 95);
            this.Category_Id.Name = "Category_Id";
            this.Category_Id.Size = new System.Drawing.Size(53, 20);
            this.Category_Id.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 67);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "CATEGORY MANAGMENT";
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Category_Name);
            this.Controls.Add(this.Category_Id);
            this.Controls.Add(this.panel1);
            this.Name = "category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "category";
            this.Load += new System.EventHandler(this.category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UpdateCategory;
        private System.Windows.Forms.Button DeleteCategory;
        private System.Windows.Forms.Button AddToCategory;
        private System.Windows.Forms.TextBox Category_Name;
        private System.Windows.Forms.TextBox Category_Id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}