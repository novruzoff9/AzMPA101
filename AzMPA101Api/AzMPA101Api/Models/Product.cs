using AzMPA101Api.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace AzMPA101Api.Models;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int Stock { get; set; }
    public Category Category { get; set; }
}
