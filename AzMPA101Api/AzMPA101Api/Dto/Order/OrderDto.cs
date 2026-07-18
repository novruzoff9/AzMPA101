namespace AzMPA101Api.Dto.Order;

public class OrderDto
{
    public decimal TotalPrice { get; set; }
    public List<OrderItemDto> Items { get; set; }
}

public class OrderItemDto
{
    public decimal Price { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
}
