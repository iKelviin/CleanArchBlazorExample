using System.ComponentModel.DataAnnotations;
namespace CleanArch.Domain.Entities;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "O preço precisa ser maior que zero")]
    public decimal Price { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "O Estoque não pode ter valores negativos.")]
    public int Stock { get; set; }
}