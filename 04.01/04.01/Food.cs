

namespace _04._01;

internal abstract class Food
{
    public int Id { get; set; }
    public string Name { get; set; }

    private DateTime productionTime;
    public DateTime Created
    {
        get
        {
            return productionTime; 
        }
        set
        {
            if (value > DateTime.Now)
                Console.WriteLine("Duzgun tarixi qeyd edin.");
            else
                productionTime = value;



        }


    }
    public TimeSpan PrepareTime { get; set; }

    private double calorivalue;
    public double Calories
    {
        get
        {
            return calorivalue;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Kalori deyeri menfi ola bilmez.");
            else
                calorivalue = value;
        }
    }

    public abstract double Calcprice();

}
