namespace _04._07;

internal class Customer
{
    private static int _idCounter = 0;
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }

    public Customer( string name,string city)
    {
        Id = ++_idCounter;
        Name = name;
        City = city;
    }
}

