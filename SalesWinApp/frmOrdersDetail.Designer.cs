
namespace SalesWinApp
{
    partial class frmOrdersDetail
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(119, 303);
            dtpRequiredDate.Margin = new Padding(3, 4, 3, 4);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(218, 27);
            dtpRequiredDate.TabIndex = 45;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(119, 356);
            dtpShippedDate.Margin = new Padding(3, 4, 3, 4);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(218, 27);
            dtpShippedDate.TabIndex = 46;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(119, 251);
            dtpOrderDate.Margin = new Padding(3, 4, 3, 4);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(218, 27);
            dtpOrderDate.TabIndex = 47;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(119, 197);
            txtFreight.Margin = new Padding(3, 4, 3, 4);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(218, 27);
            txtFreight.TabIndex = 42;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(119, 144);
            txtMemberID.Margin = new Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(218, 27);
            txtMemberID.TabIndex = 43;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(119, 95);
            txtOrderID.Margin = new Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(218, 27);
            txtOrderID.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 201);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 36;
            label6.Text = "Freight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 364);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 37;
            label5.Text = "ShippedDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 311);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 38;
            label4.Text = "RequiredDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 259);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 39;
            label2.Text = "OrderDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 151);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 40;
            label7.Text = "Member ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 99);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 41;
            label8.Text = "Order ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 31);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 48;
            label3.Text = "Order";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlDark;
            btnSave.Location = new Point(119, 412);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 49;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Location = new Point(251, 412);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 459);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(txtFreight);
            Controls.Add(txtMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label8);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrderDetail";
            Text = "frmOrderDetail";
            Load += frmOrderDetail_Load;
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
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
    }
}