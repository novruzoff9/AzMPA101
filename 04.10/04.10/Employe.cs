namespace _04._10;

internal class Employe
{
    public int Id { get; set; }
    public string Name {get; set; }
    public string Surname { get; set; }
    public Department Department { get; set; }
    public double Salary { get; set; }
    public DateTime HireDate { get; set; }

    private static int _idemploye = 1;

    public Employe()
    {
        Id = ++_idemploye;
    }
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Surname: {Surname}, Department: {Department}, Salary: {Salary}, HireDate: {HireDate}";
    }
}
