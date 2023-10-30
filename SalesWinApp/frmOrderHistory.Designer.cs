namespace SalesWinApp
{
    partial class frmOrderHistory
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
            dtpRequiredDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            dtpOrderDate = new DateTimePicker();
            txtFreight = new TextBox();
            txtMemberID = new TextBox();
            txtOrderID = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dgvOrderList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(547, 427);
            dtpRequiredDate.Margin = new Padding(3, 4, 3, 4);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(218, 27);
            dtpRequiredDate.TabIndex = 75;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(547, 480);
            dtpShippedDate.Margin = new Padding(3, 4, 3, 4);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(218, 27);
            dtpShippedDate.TabIndex = 76;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(547, 378);
            dtpOrderDate.Margin = new Padding(3, 4, 3, 4);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(218, 27);
            dtpOrderDate.TabIndex = 77;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(235, 480);
            txtFreight.Margin = new Padding(3, 4, 3, 4);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(163, 27);
            txtFreight.TabIndex = 72;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(235, 427);
            txtMemberID.Margin = new Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(163, 27);
            txtMemberID.TabIndex = 73;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(235, 378);
            txtOrderID.Margin = new Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(163, 27);
            txtOrderID.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 484);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 66;
            label1.Text = "Freight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 484);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 67;
            label5.Text = "ShippedDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 431);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 68;
            label4.Text = "RequiredDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 382);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 69;
            label3.Text = "OrderDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 434);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 70;
            label7.Text = "Member ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(130, 382);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 71;
            label8.Text = "Order ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(473, 33);
            label9.Name = "label9";
            label9.Size = new Size(129, 25);
            label9.TabIndex = 65;
            label9.Text = "Order History";
            // 
            // dgvOrderList
            // 
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(130, 71);
            dgvOrderList.Margin = new Padding(3, 4, 3, 4);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 25;
            dgvOrderList.Size = new Size(786, 287);
            dgvOrderList.TabIndex = 64;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlDark;
            btnClose.Location = new Point(830, 423);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 78;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmOrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 536);
            Controls.Add(btnClose);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtFreight);
            Controls.Add(txtMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(dgvOrderList);
            Name = "frmOrderHistory";
            Text = "frmOrderHistory";
            Load += frmOrderHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private DateTimePicker dtpOrderDate;
        private TextBox txtFreight;
        private TextBox txtMemberID;
        private TextBox txtOrderID;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dgvOrderList;
        private Button btnClose;
    }
}