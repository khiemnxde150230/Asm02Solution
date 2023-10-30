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
    public partial class frmOrders : Form
    {

        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        public frmOrders()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtOrderID.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            dtpOrderDate.Text = string.Empty;
            dtpRequiredDate.Text = string.Empty;
            dtpShippedDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
        }

        private OrderObject GetOrderObject()
        {
            OrderObject order = null;
            try
            {
                order = new OrderObject
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(dtpOrderDate.Text),
                    ShippedDate = DateTime.Parse(dtpShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    RequiredDate = DateTime.Parse(dtpRequiredDate.Text)

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return order;
        }

        public void LoadOrderList()
        {
            var orders = orderRepository.GetOrders();
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
                if (orders.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load Order list");
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvOrderList.CellDoubleClick += dgvOrderList_CellDoubleClick;
        }

        private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrdersDetail frmOrderDetail = new frmOrdersDetail
            {
                Text = "Update order",
                InsertOrUpdate = true,
                OrderInfo = GetOrderObject(),
                OrderRepository = orderRepository
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrdersDetail frmOrderDetail = new frmOrdersDetail
            {
                Text = "Add order",
                InsertOrUpdate = false,
                OrderRepository = orderRepository
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                orderRepository.DeleteOrder(order.OrderId);
                LoadOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a order");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSearch.Text);
            SearchOrderbyID(id);
        }
        public void SearchOrderbyID(int id)
        {
            var order = orderRepository.GetOrderById(id);
            IEnumerable<OrderObject> orders = new List<OrderObject>() { order };


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
                if (orders.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load Order list");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            frmOrderDetails f = new frmOrderDetails();
            f.Show();
        }
    }
}
