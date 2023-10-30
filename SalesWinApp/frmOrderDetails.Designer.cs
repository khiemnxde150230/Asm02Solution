
namespace SalesWinApp
{
    partial class frmOrderDetails
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
            components = new System.ComponentModel.Container();
            dgvOrderDetailList = new DataGridView();
            txtOrderID = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtProductID = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDiscount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetailList
            // 
            dgvOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailList.Location = new Point(14, 48);
            dgvOrderDetailList.Margin = new Padding(3, 4, 3, 4);
            dgvOrderDetailList.Name = "dgvOrderDetailList";
            dgvOrderDetailList.RowHeadersWidth = 51;
            dgvOrderDetailList.RowTemplate.Height = 25;
            dgvOrderDetailList.Size = new Size(786, 287);
            dgvOrderDetailList.TabIndex = 0;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(104, 365);
            txtOrderID.Margin = new Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(159, 27);
            txtOrderID.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ControlDark;
            btnLoad.Location = new Point(815, 48);
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
            btnNew.Location = new Point(815, 135);
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
            btnDelete.Location = new Point(815, 220);
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
            btnClose.Location = new Point(815, 304);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 369);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Order ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 12);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 1;
            label3.Text = "Order Detail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 424);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 1;
            label4.Text = "Product ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 477);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 1;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 369);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 1;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(313, 424);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 1;
            label7.Text = "Discount";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(104, 420);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(159, 27);
            txtProductID.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(104, 473);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(159, 27);
            txtUnitPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(382, 365);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(154, 27);
            txtQuantity.TabIndex = 2;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(382, 420);
            txtDiscount.Margin = new Padding(3, 4, 3, 4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(154, 27);
            txtDiscount.TabIndex = 2;
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 533);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductID);
            Controls.Add(txtOrderID);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dgvOrderDetailList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrderDetails";
            Text = "frmOrderDetails";
            Load += frmOrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetailList;
        private TextBox txtOrderID;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtProductID;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
    }
}