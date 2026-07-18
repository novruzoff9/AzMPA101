using AzMPA101Api.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace AzMPA101Api.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}
