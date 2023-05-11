using Microsoft.EntityFrameworkCore;
using ProductMicroservices.Models;

namespace ProductMicroservices.Repository
{
    public interface IProductRepository
    {
        public void DeleteProduct(int productId);

        public Product GetProductByID(int productId);

        public IEnumerable<Product> GetProducts();

        public void InsertProduct(Product product);

        public void Save();

        public void UpdateProduct(Product product);
    }
}
