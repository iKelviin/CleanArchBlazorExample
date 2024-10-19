using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System.Net.Http.Json;
namespace CleanArch.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly HttpClient _httpClient;
        private const string BASE_URL = "http://localhost:3000"; 
        public ProductRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Add(Product product)
        {
            var url = $"{BASE_URL}/products";
            var response = await _httpClient.PostAsJsonAsync(url, product);
        }

        public async Task Delete(int id)
        {
            var url = $"{BASE_URL}/products/{id}";
            var response = await _httpClient.DeleteAsync(url);
        }

        public async Task<Product> Get(int id)
        {
            var url = $"{BASE_URL}/products/{id}";
            var response = await _httpClient.GetFromJsonAsync<Product>(url);
            return response!;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var url = $"{BASE_URL}/products";
            var response = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>(url);
            return response!;
        }

        public async Task Update(Product product)
        {
            var url = $"{BASE_URL}/products/{product.Id}";
            var response = await _httpClient.PutAsJsonAsync(url, product);
        }
    }
}
