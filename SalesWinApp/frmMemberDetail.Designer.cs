
namespace SalesWinApp
{
    partial class frmMemberDetail
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
            txtPassword = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtCompanyName = new TextBox();
            txtEmail = new TextBox();
            txtMemberID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(138, 380);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(206, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(138, 313);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(206, 27);
            txtCountry.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(138, 257);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(206, 27);
            txtCity.TabIndex = 11;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(138, 188);
            txtCompanyName.Margin = new Padding(3, 4, 3, 4);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(206, 27);
            txtCompanyName.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 120);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 27);
            txtEmail.TabIndex = 13;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(138, 65);
            txtMemberID.Margin = new Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(206, 27);
            txtMemberID.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 384);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 3;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 317);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 261);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 5;
            label4.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 192);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 6;
            label3.Text = "Company Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 125);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 69);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 8;
            label1.Text = "Member ID";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlDark;
            btnSave.Location = new Point(138, 441);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlDark;
            btnCancel.Location = new Point(259, 441);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(138, 12);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 20;
            label7.Text = "Member";
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 508);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMemberDetail";
            Text = "MemberDetail";
            Load += MemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private TextBox txtMemberID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
        private Label label7;
    }
}