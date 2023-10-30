namespace SalesWinApp
{
    partial class frmMainUser
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
            btnMemberDetail = new Button();
            btnOrderHistory = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 41);
            label1.Name = "label1";
            label1.Size = new Size(405, 50);
            label1.TabIndex = 12;
            label1.Text = "Welcome FStore's User";
            // 
            // btnMemberDetail
            // 
            btnMemberDetail.BackColor = SystemColors.ControlDark;
            btnMemberDetail.Location = new Point(115, 153);
            btnMemberDetail.Margin = new Padding(3, 4, 3, 4);
            btnMemberDetail.Name = "btnMemberDetail";
            btnMemberDetail.Size = new Size(160, 44);
            btnMemberDetail.TabIndex = 20;
            btnMemberDetail.Text = "Member Detail";
            btnMemberDetail.UseVisualStyleBackColor = false;
            btnMemberDetail.Click += btnMemberDetail_Click;
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.BackColor = SystemColors.ControlDark;
            btnOrderHistory.Location = new Point(406, 153);
            btnOrderHistory.Margin = new Padding(3, 4, 3, 4);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Size = new Size(173, 44);
            btnOrderHistory.TabIndex = 21;
            btnOrderHistory.Text = "Order History";
            btnOrderHistory.UseVisualStyleBackColor = false;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlDark;
            btnExit.Location = new Point(293, 212);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 35);
            btnExit.TabIndex = 24;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmMainUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 284);
            Controls.Add(btnExit);
            Controls.Add(btnOrderHistory);
            Controls.Add(btnMemberDetail);
            Controls.Add(label1);
            Name = "frmMainUser";
            Text = "User Control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMemberDetail;
        private Button btnOrderHistory;
        private Button btnExit;
    }
}