using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers f = new frmMembers();
            f.Show();
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts fp = new frmProducts();
            fp.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders fo = new frmOrders();
            fo.Show();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            frmOrderDetails fod = new frmOrderDetails();
            fod.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
