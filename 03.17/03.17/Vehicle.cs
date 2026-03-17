using System.ComponentModel.DataAnnotations;

namespace _03._17;

internal class Vehicle
{
    public string Brand;
    public string Model;
    public int Year;
    public int MileageKm;
    public bool IsRunning;


    public Vehicle(string brand , string model,int year)
    {
        Brand = brand;
        Model = model;

        if (year >= 1886)
            Year = year;
        else
        {
            Console.WriteLine("1886-dan kiçik ola bilməz.");
        }
        MileageKm = 0;
        IsRunning = false;
    }
    public  void StartEngine()
    {
        IsRunning = true;

    }
    public void StopEngine()
    {
        IsRunning = false;
    }
    public virtual void Drive(int km)
    {
        if (km > 0 && IsRunning)
        {
            MileageKm += km;
        }
    }
    public virtual void VehicleInfo()
    {
        Console.WriteLine($"Type Vehicle");
        Console.WriteLine($"Brand : {Brand}");
        Console.WriteLine($"Model : {Model}");
        Console.WriteLine($"Year : {Year}");
        Console.WriteLine($"Millage : {MileageKm} km");
        Console.WriteLine($"Running : {IsRunning}");
    }

}
