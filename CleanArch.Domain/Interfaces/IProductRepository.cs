using CleanArch.Domain.Entities;
namespace CleanArch.Domain.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product> Get(int id);
    Task Add(Product product);
    Task Update(Product product);
    Task Delete(int id);
}
