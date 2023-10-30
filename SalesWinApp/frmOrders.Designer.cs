namespace SalesWinApp
{
    partial class frmOrders
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
            label10 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
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
            btnClose = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            btnLoad = new Button();
            label9 = new Label();
            dgvOrderList = new DataGridView();
            btnOrderDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(592, 49);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 62;
            label10.Text = "Search ID";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlDark;
            btnSearch.Location = new Point(804, 45);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 32);
            btnSearch.TabIndex = 61;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(660, 46);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(129, 27);
            txtSearch.TabIndex = 60;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(500, 441);
            dtpRequiredDate.Margin = new Padding(3, 4, 3, 4);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(218, 27);
            dtpRequiredDate.TabIndex = 57;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(500, 494);
            dtpShippedDate.Margin = new Padding(3, 4, 3, 4);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(218, 27);
            dtpShippedDate.TabIndex = 58;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(500, 392);
            dtpOrderDate.Margin = new Padding(3, 4, 3, 4);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(218, 27);
            dtpOrderDate.TabIndex = 59;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(188, 494);
            txtFreight.Margin = new Padding(3, 4, 3, 4);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(163, 27);
            txtFreight.TabIndex = 54;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(188, 441);
            txtMemberID.Margin = new Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(163, 27);
            txtMemberID.TabIndex = 55;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(188, 392);
            txtOrderID.Margin = new Padding(3, 4, 3, 4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(163, 27);
            txtOrderID.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 498);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 48;
            label1.Text = "Freight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 498);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 49;
            label5.Text = "ShippedDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 445);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 50;
            label4.Text = "RequiredDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 396);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 51;
            label3.Text = "OrderDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 448);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 52;
            label7.Text = "Member ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 396);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 53;
            label8.Text = "Order ID";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlDark;
            btnClose.Location = new Point(884, 341);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 47;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.Location = new Point(884, 256);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.ControlDark;
            btnNew.Location = new Point(884, 165);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(86, 31);
            btnNew.TabIndex = 45;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ControlDark;
            btnLoad.Location = new Point(884, 85);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(86, 31);
            btnLoad.TabIndex = 42;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(439, 49);
            label9.Name = "label9";
            label9.Size = new Size(95, 25);
            label9.TabIndex = 41;
            label9.Text = "List Order";
            // 
            // dgvOrderList
            // 
            dgvOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(83, 85);
            dgvOrderList.Margin = new Padding(3, 4, 3, 4);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 25;
            dgvOrderList.Size = new Size(786, 287);
            dgvOrderList.TabIndex = 40;
            dgvOrderList.CellDoubleClick += dgvOrderList_CellDoubleClick;
            // 
            // btnOrderDetail
            // 
            btnOrderDetail.BackColor = SystemColors.ControlDark;
            btnOrderDetail.Location = new Point(83, 43);
            btnOrderDetail.Margin = new Padding(3, 4, 3, 4);
            btnOrderDetail.Name = "btnOrderDetail";
            btnOrderDetail.Size = new Size(138, 31);
            btnOrderDetail.TabIndex = 63;
            btnOrderDetail.Text = "Order Detail";
            btnOrderDetail.UseVisualStyleBackColor = false;
            btnOrderDetail.Click += btnOrderDetail_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 695);
            Controls.Add(btnOrderDetail);
            Controls.Add(label10);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
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
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(label9);
            Controls.Add(dgvOrderList);
            Name = "frmOrders";
            Text = "frmOrders";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Button btnSearch;
        private TextBox txtSearch;
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
        private Button btnClose;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private Label label9;
        private DataGridView dgvOrderList;
        private Button btnOrderDetail;
    }
}