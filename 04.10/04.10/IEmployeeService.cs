namespace _04._10;

internal interface IEmployeeService
{
    List<Employe> GetAll();
    Employe GetById(int id);
    void Add(Employe employe);
}
