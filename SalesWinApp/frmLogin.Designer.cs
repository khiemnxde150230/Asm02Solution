namespace SalesWinApp
{
    partial class frmLogin
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
            lbEmail = new Label();
            lbPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnAdminLogin = new Button();
            btnExit = new Button();
            lbFstoreLogin = new Label();
            btnUserLogin = new Button();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(40, 162);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(40, 208);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(275, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = SystemColors.ControlDark;
            btnAdminLogin.Location = new Point(40, 271);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(114, 29);
            btnAdminLogin.TabIndex = 4;
            btnAdminLogin.Text = "Admin Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlDark;
            btnExit.Location = new Point(406, 271);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lbFstoreLogin
            // 
            lbFstoreLogin.AutoSize = true;
            lbFstoreLogin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbFstoreLogin.Location = new Point(228, 70);
            lbFstoreLogin.Name = "lbFstoreLogin";
            lbFstoreLogin.Size = new Size(118, 25);
            lbFstoreLogin.TabIndex = 20;
            lbFstoreLogin.Text = "FStore Login";
            // 
            // btnUserLogin
            // 
            btnUserLogin.BackColor = SystemColors.ControlDark;
            btnUserLogin.Location = new Point(228, 271);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(114, 29);
            btnUserLogin.TabIndex = 21;
            btnUserLogin.Text = "User Login";
            btnUserLogin.UseVisualStyleBackColor = false;
            btnUserLogin.Click += btnUserLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 450);
            Controls.Add(btnUserLogin);
            Controls.Add(lbFstoreLogin);
            Controls.Add(btnExit);
            Controls.Add(btnAdminLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbEmail;
        private Label lbPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnAdminLogin;
        private Button btnExit;
        private Label lbFstoreLogin;
        private Button btnUserLogin;
    }
}