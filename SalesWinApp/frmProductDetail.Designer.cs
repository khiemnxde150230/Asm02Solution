
namespace SalesWinApp
{
    partial class frmProductDetail
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
            txtWeight = new TextBox();
            txtProductName = new TextBox();
            txtCategoryID = new TextBox();
            txtProductID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(134, 257);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(197, 27);
            txtWeight.TabIndex = 10;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(134, 192);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(197, 27);
            txtProductName.TabIndex = 11;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(134, 135);
            txtCategoryID.Margin = new Padding(3, 4, 3, 4);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(197, 27);
            txtCategoryID.TabIndex = 12;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(134, 80);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(197, 27);
            txtProductID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 261);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 196);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 5;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 139);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 6;
            label2.Text = "Category ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 84);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 7;
            label1.Text = "Product ID";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlDark;
            btnSave.Location = new Point(134, 427);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Location = new Point(246, 427);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(134, 379);
            txtUnitsInStock.Margin = new Padding(3, 4, 3, 4);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(197, 27);
            txtUnitsInStock.TabIndex = 17;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(134, 319);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(197, 27);
            txtUnitPrice.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 383);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 15;
            label6.Text = "Units In Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 323);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 16;
            label5.Text = "Unit Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(151, 15);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 19;
            label7.Text = "Product";
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 532);
            Controls.Add(label7);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProductDetail";
            Text = "ProductDetail";
            Load += ProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtWeight;
        private TextBox txtProductName;
        private TextBox txtCategoryID;
        private TextBox txtProductID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}