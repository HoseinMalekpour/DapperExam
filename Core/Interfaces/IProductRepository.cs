using DapperExam.Core.dto;

namespace DapperExam.Core.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProduct();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdatedProduct(Product product);
        void RemoveProduct(int id);
    }
}
