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
    public partial class frmOrdersDetail : Form
    {
        public frmOrdersDetail()
        {
            InitializeComponent();
        }

        public IOrderRepository OrderRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderObject OrderInfo { get; set; }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtOrderID.Text = OrderInfo.OrderId.ToString();
                txtMemberID.Text = OrderInfo.MemberId.ToString();
                dtpOrderDate.Text = OrderInfo.OrderDate.ToString();
                dtpShippedDate.Text = OrderInfo.ShippedDate.ToString();
                txtFreight.Text = OrderInfo.Freight.ToString();
                dtpRequiredDate.Text = OrderInfo.RequiredDate.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new OrderObject
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(dtpOrderDate.Text),
                    ShippedDate = DateTime.Parse(dtpShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    RequiredDate = DateTime.Parse(dtpRequiredDate.Text)
                };

                if (InsertOrUpdate == false)
                {
                    OrderRepository.InsertOrder(order);
                    MessageBox.Show("Added");
                }
                else
                {
                    OrderRepository.UpdateOrder(order);
                    MessageBox.Show("Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order" : "Update a order");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
