using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int productId)
        {
            ProductDAO.Instance.Remove(productId);
        }

        public ProductObject GetProductById(int productId)
        {
            return ProductDAO.Instance.GetProductByID(productId);
        }

        public IEnumerable<ProductObject> GetProducts()
        {
            return ProductDAO.Instance.GetProductList();
        }

        public void InsertProduct(ProductObject product)
        {
            ProductDAO.Instance.AddNew(product);
        }

        public void UpdateProduct(ProductObject product)
        {
            ProductDAO.Instance.Update(product);

        }
    }
}
