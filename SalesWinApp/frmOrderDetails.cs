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
    public partial class frmOrderDetails : Form
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {

        }

        private void ClearText()
        {
            txtOrderID.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
        }

        private OrderDetailObject GetOrderDetailObject()
        {
            OrderDetailObject orderDetailObject = null;
            try
            {
                orderDetailObject = new OrderDetailObject
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProductID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = float.Parse(txtDiscount.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order detail");
            }
            return orderDetailObject;
        }

        public void LoadOrderDetailList()
        {
            var orderDetails = orderDetailRepository.GetOrderDetails();
            try
            {
                source = new BindingSource();
                source.DataSource = orderDetails;

                txtOrderID.DataBindings.Clear();
                txtProductID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtDiscount.DataBindings.Add("Text", source, "Discount");

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = source;
                if (orderDetails.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order detail list");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderDetailList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrdersDetails n = new frmOrdersDetails()
            {
                Text = "Add new order detail",
                InsertOrUpdate = false,
                OrderDetailRepository = orderDetailRepository
            };
            if (n.ShowDialog() == DialogResult.OK)
            {
                LoadOrderDetailList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = GetOrderDetailObject();
                orderDetailRepository.DeleteOrderDetail(orderDetail.OrderId);
                LoadOrderDetailList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a order detail");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
