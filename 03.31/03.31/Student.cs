namespace _03._31;

internal class Student : Person
{
    private string studentNumber;
    public string StudentNumber
    {
        get
        {
            return studentNumber;
        }
        set
        {
            if (value.Length > 3)
            {
                studentNumber = value;
            }
            else
            {
                Console.WriteLine("Telebenin kodu 3 simvoldan kicik ola bilmez.");
            }
        }
    }
    private int gPA;
    public int GPA
    {
        get
        {
            return gPA;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("0-dan kicik ola bilmez.");
            }
            else if (value > 100)
            {
                Console.WriteLine("100-den boyuk ola bilmez.");
            }
            else
            {
                gPA = value;
            }
        }
    }
    public bool IsHonorStudent
    {
        get
        {
            return GPA > 90;
        }
    }
    public Student (int id, string fullName, DateTime birthDate, string studentNumber, int gPA) : base (id, fullName, birthDate)
    {
        StudentNumber = studentNumber;
        GPA = gPA;
    }
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Ortalama: {GPA}, Elacidirmi? {IsHonorStudent}");
    }
    public override string GetRole()
    {
        return "student";
    }



}
