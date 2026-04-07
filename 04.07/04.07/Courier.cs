namespace _04._07;

internal class Courier
{
    private static int _idCounter = 0;
    public int Id { get; set; }
    public string Name { get; set; }   
    public bool IsAvailable { get; set; }

    public Courier(string name)
    {
        Id=++_idCounter;
        Name=name; 
        IsAvailable = true;

    }
}
