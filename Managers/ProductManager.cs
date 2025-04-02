using System.Collections.Generic;
using YStore.Models;

namespace YStore.Managers
{
    public class ProductManager
    {
        private readonly IProductProvider _productProvider;

        public ProductManager(IProductProvider productProvider)
        {
            _productProvider = productProvider;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _productProvider.GetProducts();
            return products;
        }

        public void CreateProduct(Product product)
        {
            _productProvider.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _productProvider.UpdateProduct(product);
        }

        public void RemoveProduct(int id)
        {
            _productProvider.DeleteProduct(id);
        }
    }
}
