using AzMPA101Api.Models.Base;

namespace AzMPA101Api.Models;

public class OrderItem : BaseEntity
{
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
