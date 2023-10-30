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
    public partial class frmOrdersDetails : Form
    {
        public frmOrdersDetails()
        {
            InitializeComponent();
        }

        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderDetailObject OrderDetailInfo { get; set; }

        private void NewOrderDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtOrderID.Text = OrderDetailInfo.OrderId.ToString();
                txtProductID.Text = OrderDetailInfo.ProductId.ToString();
                txtUnitPrice.Text = OrderDetailInfo.UnitPrice.ToString();
                txtQuantity.Text = OrderDetailInfo.Quantity.ToString();
                txtDiscount.Text = OrderDetailInfo.Discount.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetailObject = new OrderDetailObject
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProductID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount = float.Parse(txtDiscount.Text)
                };

                if (InsertOrUpdate == false)
                {
                    OrderDetailRepository.InsertOrderDetail(orderDetailObject);
                }
                else
                {
                    OrderDetailRepository.UpdateOrderDetail(orderDetailObject);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order detail " : "Update a order detail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
