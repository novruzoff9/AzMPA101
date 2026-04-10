
using System.Threading.Tasks;

namespace _04._10;

internal class EmployeeService : IEmployeeService
{
    static List<Employe> employes = [];
    public void Add(Employe employe)
    {
        var exsist = employes.Find(x => x.Name == employe.Name && x.Surname == employe.Surname);
        if (exsist != null)
            throw new Exception("bele bir isci var");
        employes.Add(employe);
    }

    public List<Employe> GetAll()
    {
        return employes;
    }

    public Employe GetById(int id)
    {
        var exsist = employes.Find(x => x.Id == id);
        if (exsist == null)
            throw new Exception("isci tapilmadi");
        return exsist;
    }
    public List<Employe> GetByDepartment(Department department)
    {
        return employes.FindAll(x => x.Department == department);
    }
    public Employe GetMostExpensiveEmployee()
    {
        //return employes.MaxBy(x => x.Salary);
        return employes.OrderBy(x => x.Salary).Last();
    }
    public Employe GetCheapestEmployee()
    {
        return employes.OrderBy(x => x.Salary).First();
    }
    public double GetAverageSalary()
    {
        return employes.Average(x => x.Salary);
    }

    public int CountByDepartment(Department department)
    {
        return employes.Count(x => x.Department == department);
    }

    public List<Employe> GetBySalaryRange(double min, double max)
    {
        return employes.FindAll(x => x.Salary > min && x.Salary < max);
    }
    public void UpdateSalary(int id, double newSalary)
    {
        var exsist = employes.Find(x => x.Id == id);
        exsist.Salary = newSalary;
    }

    public void UpdateAllSalaries(double percentage)
    {
        employes.ForEach(x => x.Salary += x.Salary * percentage / 100);
    }
    public void Remove(int id)
    {
        var exsist = employes.Find(x => x.Id == id);
        employes.Remove(exsist);
    }
}

