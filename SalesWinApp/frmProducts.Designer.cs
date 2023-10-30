
namespace SalesWinApp
{
    partial class frmProducts
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
            label1 = new Label();
            txtProductID = new TextBox();
            dgvProductList = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCategoryID = new TextBox();
            txtProductName = new TextBox();
            txtWeight = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            label5 = new Label();
            label6 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 421);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(117, 417);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(164, 27);
            txtProductID.TabIndex = 1;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(14, 75);
            dgvProductList.Margin = new Padding(3, 4, 3, 4);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 25;
            dgvProductList.Size = new Size(781, 315);
            dgvProductList.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 536);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Category ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 476);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 0;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 421);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 0;
            label4.Text = "Weight";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(117, 532);
            txtCategoryID.Margin = new Padding(3, 4, 3, 4);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(164, 27);
            txtCategoryID.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(117, 472);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(164, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(406, 417);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(151, 27);
            txtWeight.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(406, 472);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(151, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(406, 532);
            txtUnitsInStock.Margin = new Padding(3, 4, 3, 4);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(151, 27);
            txtUnitsInStock.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ControlDark;
            btnLoad.Location = new Point(815, 75);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(86, 31);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.ControlDark;
            btnNew.Location = new Point(815, 167);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(86, 31);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.Location = new Point(815, 256);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlDark;
            btnClose.Location = new Point(815, 359);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 476);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 0;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 536);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 0;
            label6.Text = "Units In Stock";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlDark;
            btnSearch.Location = new Point(706, 35);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(538, 35);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(161, 27);
            txtSearch.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(464, 40);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 16;
            label8.Text = "Search ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(73, 24);
            label7.Name = "label7";
            label7.Size = new Size(113, 25);
            label7.TabIndex = 15;
            label7.Text = "List Product";
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(dgvProductList);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductID;
        private DataGridView dgvProductList;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCategoryID;
        private TextBox txtProductName;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
        private Label label5;
        private Label label6;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label8;
        private Label label7;
    }
}