namespace _03._16;

internal class SmartPhone
{
    public string Model;
    public string Brand;
    public int BatteryLevel;
    public int StorageCapacity;
    public int UsedStorage;
    public bool IsLocked;

    public SmartPhone (string brand, string model, int storageCapacity)
    {
        Brand = brand;
        Model = model;
        StorageCapacity = storageCapacity;
        BatteryLevel = 0;
        UsedStorage = 0;
        IsLocked = true;
    }
    public void UnlockPhone ()
    {
        if (IsLocked)
        {
            IsLocked = false; 
            Console.WriteLine("Telefon Achildi");
        }
        else
            Console.WriteLine("Telefon artiq aciqdir");
    }
    public void InstallApp (int size)
    {
        if(UsedStorage + size <= StorageCapacity)
        {
            UsedStorage += size;
            Console.WriteLine("Tetbiq yuklendi");
        }
        else
            Console.WriteLine("Yaddashda bu tetbiq ucun bosh yer yoxdu");
    }

    public void ChargeBattery(int amount)
    {
        BatteryLevel += amount;

        if (BatteryLevel > 100)
        {
            BatteryLevel = 100;
        }
        Console.WriteLine($"Batareya seviyyesi : {BatteryLevel}%");
    }

    public void PhoneInfo()
    {
        string lockStatus = IsLocked ? "Yes" : "No";

        Console.WriteLine($"Brand: {Brand} ");
        Console.WriteLine($"Model: {Model} ");
        Console.WriteLine($"Battery Level : {BatteryLevel}%");
        Console.WriteLine($"Storage : {StorageCapacity}GB Used: {UsedStorage}GB)");
        Console.WriteLine($"Is Locked : {lockStatus}");
    }
}