
namespace SalesWinApp
{
    partial class frmOrdersDetails
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
            txtDiscount = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductID = new TextBox();
            txtOrderID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(104, 285);
            txtDiscount.Margin = new Padding(3, 4, 3, 4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(201, 27);
            txtDiscount.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(104, 231);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(201, 27);
            txtQuantity.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(104, 176);
            txtUnitPrice.Margin = new Padding(3, 4, 3, 4);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(201, 27);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(104, 123);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(201, 27);
            txtProductID.TabIndex = 11;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(104, 68);
            txtOrderID.Margin = new Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(201, 27);
            txtOrderID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 289);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 3;
            label7.Text = "Discount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 235);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 4;
            label6.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 180);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 5;
            label5.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 127);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 72);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Order ID";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Location = new Point(219, 343);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlDark;
            btnSave.Location = new Point(104, 343);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmNewOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 401);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductID);
            Controls.Add(txtOrderID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNewOrderDetail";
            Text = "NewOrderDetail";
            Load += NewOrderDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductID;
        private TextBox txtOrderID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
    }
}