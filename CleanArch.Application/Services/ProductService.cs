using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services;

public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _productRepository.GetAll();
    }

    public async Task<Product> GetProductById(int id)
    {
        return await _productRepository.Get(id);
    }

    public async Task AddProduct(Product product)
    {
        await _productRepository.Add(product);
    }

    public async Task UpdateProduct(Product product)
    {
        await _productRepository.Update(product);
    }

    public async Task DeleteProduct(int id)
    {
        await _productRepository.Delete(id);
    }
}
