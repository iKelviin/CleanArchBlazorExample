using CleanArch.Application.Services;
using CleanArch.Components;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do HttpClient
builder.Services.AddHttpClient<IProductRepository, ProductRepository>(client =>
{
    client.BaseAddress = new Uri("https://localhost:3000"); // URL da API
});

// Inje��o de depend�ncias
builder.Services.AddScoped<ProductService>();

// Adiciona servi�os para Razor Components e Blazor Server
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Mapeia componentes Blazor
app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(CleanArch.Client._Imports).Assembly);

app.Run();
