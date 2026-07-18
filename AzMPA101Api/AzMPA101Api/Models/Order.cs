using AzMPA101Api.Models.Base;

namespace AzMPA101Api.Models;

public class Order : BaseEntity
{
    public decimal TotalPrice { get; set; }
    public List<OrderItem> Items { get; set; }
}
