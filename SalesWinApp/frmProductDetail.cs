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
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }

        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ProductObject ProductInfo { get; set; }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtProductID.Text = ProductInfo.ProductId.ToString();
                txtCategoryID.Text = ProductInfo.CategoryId.ToString();
                txtProductName.Text = ProductInfo.ProductName;
                txtWeight.Text = ProductInfo.Weight;
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtUnitsInStock.Text = ProductInfo.UnitsInStock.ToString();
                //   Update [Product] set CategoryId =2, ProductName = 'PC Asus', Weight = '10 kg', UnitPrice = '5000.0000', UnitsInStock = 3 where ProductId = 5;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductObject
                {
                    ProductId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };

                if (InsertOrUpdate == false)
                {
                    ProductRepository.InsertProduct(product);
                    MessageBox.Show("Added");
                }
                else
                {
                    ProductRepository.UpdateProduct(product);
                    MessageBox.Show("Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product" : "Update a product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
