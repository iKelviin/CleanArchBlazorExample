using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "The price must be greater than 0")]
    public decimal Price { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "The stock must be a non-negative number")]
    public int Stock { get; set; }
}