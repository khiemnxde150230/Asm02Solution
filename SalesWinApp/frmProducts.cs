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
    public partial class frmProducts : Form
    {

        IProductRepository productRepository = new ProductRepository();
        BindingSource source;

        public frmProducts()
        {
            InitializeComponent();
        }

        private void ClearText()
        {
            txtProductID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
        }

        private ProductObject GetProductObject()
        {
            ProductObject product = null;
            try
            {
                product = new ProductObject
                {
                    ProductId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }

        public void LoadProductList()
        {
            var products = productRepository.GetProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
                if (products.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetail pd = new frmProductDetail
            {
                Text = "Add product",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            if (pd.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                productRepository.DeleteProduct(product.ProductId);
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvProductList.CellDoubleClick += DgvProductList_CellDoubleClick;
        }

        private void DgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail pd = new frmProductDetail
            {
                Text = "Update product",
                InsertOrUpdate = true,
                ProductInfo = GetProductObject(),
                ProductRepository = productRepository
            };
            if (pd.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSearch.Text);
            SearchProductbyID(id);
        }

        public void SearchProductbyID(int id)
        {
            var product = productRepository.GetProductById(id);
            IEnumerable<ProductObject> products = new List<ProductObject>() { product };


            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
                if (products.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load product list");
            }
        }
    }
}
