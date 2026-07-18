namespace AzMPA101Api.Dto;

public class ProductCreateDto
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}
