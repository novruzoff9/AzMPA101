namespace _04._01;

internal class Pizza : Food
{
    public double Radius { get; set; }
    public bool IsHot { get; set; }

    public override double Calcprice()
    {
        double area = Math.PI * Radius * Radius;
        double price = area * 0.1;
        if (IsHot)
        {
            price += 1.15;
        }
        return price;
    }

    public override string ToString()
    {
        return $"Pizza: Id={Id}, Name={Name}, Created={Created}, PrepareTime={PrepareTime}, Calories={Calories}, Radius={Radius}, IsHot={IsHot}, Price={Calcprice():0.00}";
    }
}
