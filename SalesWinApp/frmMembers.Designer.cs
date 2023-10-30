
namespace SalesWinApp
{
    partial class frmMembers
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
            dgvMemberList = new DataGridView();
            label1 = new Label();
            txtMemberID = new TextBox();
            btnLoad = new Button();
            txtEmail = new TextBox();
            txtCompanyName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            label7 = new Label();
            label8 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(14, 61);
            dgvMemberList.Margin = new Padding(3, 4, 3, 4);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.Size = new Size(887, 296);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 405);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Member ID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(128, 401);
            txtMemberID.Margin = new Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(206, 27);
            txtMemberID.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = SystemColors.ControlDark;
            btnLoad.Location = new Point(710, 401);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(86, 31);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 456);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(128, 506);
            txtCompanyName.Margin = new Padding(3, 4, 3, 4);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(206, 27);
            txtCompanyName.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(474, 401);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(201, 27);
            txtCity.TabIndex = 2;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(474, 457);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(201, 27);
            txtCountry.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(474, 506);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 27);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 461);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 510);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 1;
            label3.Text = "Company Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 405);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 1;
            label4.Text = "City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 461);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 1;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 510);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 1;
            label6.Text = "Password";
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.ControlDark;
            btnNew.Location = new Point(710, 450);
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
            btnDelete.Location = new Point(710, 499);
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
            btnClose.Location = new Point(815, 450);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(182, 12);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 11;
            label7.Text = "List Member";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(567, 28);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 12;
            label8.Text = "Search ID:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(647, 23);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(161, 27);
            txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlDark;
            btnSearch.Location = new Point(815, 23);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmMembers
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
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMemberList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMembers";
            Text = "frmMembers";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberList;
        private Label label1;
        private TextBox txtMemberID;
        private Button btnLoad;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
        private Label label7;
        private Label label8;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}