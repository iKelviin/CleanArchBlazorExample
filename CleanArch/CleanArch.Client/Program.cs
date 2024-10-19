using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Repositories;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Configurar HttpClient com BaseAddress (API URL)
builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri("https://localhost:3000") });

// Inje��o de depend�ncias - Application Layer Services e Infrastructure
builder.Services.AddScoped<IProductRepository, ProductRepository>(); // Reposit�rio
builder.Services.AddScoped<ProductService>(); // Servi�o

await builder.Build().RunAsync();
