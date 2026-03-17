
namespace _03._17;

internal class Car : Vehicle
{
    public  double FuelCapacityLiters;
    public double FuelLiters;
    public double FuelConsumptionPer100Km;


    public Car(string brand, string model, int year, double fuelCapacityLiters, double fuelConsumptionPer100Km, double initialFuelLiters):base(brand,model,year)
    {
        if (fuelCapacityLiters > 0)
            FuelCapacityLiters = fuelCapacityLiters;
        if (fuelConsumptionPer100Km > 0)
            FuelConsumptionPer100Km = fuelConsumptionPer100Km;
        if (0 <= initialFuelLiters && initialFuelLiters <= fuelCapacityLiters)
            FuelLiters = initialFuelLiters;

    }
    public void Refuel(double litters)
    {
        if (litters > 0 && FuelLiters + litters <= FuelCapacityLiters)

            FuelLiters += litters;
        else {
            Console.WriteLine("tutumu asir");
        }

        
    }
    public override void Drive(int km)
    {
        base.Drive(km);
        double requiredLiters = (km / 100.0) * FuelConsumptionPer100Km;
        if (FuelLiters >= requiredLiters)
            FuelLiters -= requiredLiters;
        else
        {
            Console.WriteLine("kifayet qeder benzin yoxdur!");
        }
    }
    
}

