
namespace SalesWinApp
{
    partial class frmMain
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
            btnProducts = new Button();
            btnMembers = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            btnOrders = new Button();
            btnOrderDetail = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.ControlDark;
            btnProducts.Location = new Point(188, 140);
            btnProducts.Margin = new Padding(3, 4, 3, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(115, 44);
            btnProducts.TabIndex = 20;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnMembers
            // 
            btnMembers.BackColor = SystemColors.ControlDark;
            btnMembers.Location = new Point(59, 140);
            btnMembers.Margin = new Padding(3, 4, 3, 4);
            btnMembers.Name = "btnMembers";
            btnMembers.Size = new Size(111, 44);
            btnMembers.TabIndex = 19;
            btnMembers.Text = "Members";
            btnMembers.UseVisualStyleBackColor = false;
            btnMembers.Click += btnMembers_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(129, 55);
            label1.Name = "label1";
            label1.Size = new Size(363, 50);
            label1.TabIndex = 11;
            label1.Text = "FStore Management";
            // 
            // btnOrders
            // 
            btnOrders.BackColor = SystemColors.ControlDark;
            btnOrders.Location = new Point(321, 140);
            btnOrders.Margin = new Padding(3, 4, 3, 4);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(106, 44);
            btnOrders.TabIndex = 21;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnOrderDetail
            // 
            btnOrderDetail.BackColor = SystemColors.ControlDark;
            btnOrderDetail.Location = new Point(450, 140);
            btnOrderDetail.Margin = new Padding(3, 4, 3, 4);
            btnOrderDetail.Name = "btnOrderDetail";
            btnOrderDetail.Size = new Size(106, 44);
            btnOrderDetail.TabIndex = 22;
            btnOrderDetail.Text = "Order Detail";
            btnOrderDetail.UseVisualStyleBackColor = false;
            btnOrderDetail.Click += btnOrderDetail_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ControlDark;
            btnExit.Location = new Point(265, 217);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 35);
            btnExit.TabIndex = 23;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 278);
            Controls.Add(btnExit);
            Controls.Add(btnOrderDetail);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(btnMembers);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProducts;
        private Button btnMembers;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Button btnOrders;
        private Button btnOrderDetail;
        private Button btnExit;
    }
}