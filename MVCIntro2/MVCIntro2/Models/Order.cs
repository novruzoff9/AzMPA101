namespace MVCIntro2.Models;

public class Order : BaseEntity
{
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
}