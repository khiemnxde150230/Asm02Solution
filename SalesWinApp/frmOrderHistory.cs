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
    public partial class frmOrderHistory : Form
    {
        private int memberId;
        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        public frmOrderHistory(int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
        }

        private void frmOrderHistory_Load(object sender, EventArgs e)
        {
            var orders = orderRepository.GetOrderByMemberID(memberId);
            try
            {
                source = new BindingSource();
                source.DataSource = orders;

                txtOrderID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                dtpOrderDate.DataBindings.Clear();
                dtpRequiredDate.DataBindings.Clear();
                dtpShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                dtpOrderDate.DataBindings.Add("Text", source, "OrderDate");
                dtpRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                dtpShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order list");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
