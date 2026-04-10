# İşçi İdarəetmə Sistemi

1. `Employee` adında class yaradılacaq:
    - `Id` (statik olaraq artacaq)
    - `Name`
    - `Surname`
    - `Department` (enum olacaq, aşağıda verilib)
    - `Salary`
    - `HireDate`

2. Enum:
    - `Department`: `HR`, `IT`, `Finance`, `Marketing`, `Operations`

3. İnterfeys: `IEmployeeService`
    - `Add(Employee employee)` -> işçi əlavə et
    - `GetById(int id)` -> id-yə görə işçi qaytar
    - `GetAll()` -> bütün işçiləri qaytar
    - `GetByDepartment(Department department)` -> departamentə görə filter
    - `GetMostExpensiveEmployee()` -> ən yüksək maaşlı işçi
    - `GetCheapestEmployee()` -> ən az maaşlı işçi
    - `GetAverageSalary()` -> orta maaş
    - `CountByDepartment(Department department)` -> departamentə görə say
    - `GetBySalaryRange(double min, double max)` -> maaşa aralığına görə filter
    - `UpdateSalary(int id, double newSalary)` -> İşçinin maaşını artır
    - `UpdateAllSalaries(double percentage)` -> Bütün işçilərin maaşını fazile artır
    - `Remove(int id)` -> id-yə görə işçi sil


4. `EmployeeService` class-ı:
    - Daxildə statik `List<Employee>` saxlasın
    - Eyni `Name + Surname` ilə işçi əlavə olunarsa `ConflictException` atılsın
    - Tapılmayan id üçün `NotFoundException` atılsın

5. Extension metodlar (`EmployeeExtensions`):
    - `GetShortInfo(this Employee employee)`:
        `Name - Surname - Department` formatında qaytarsın
    - `IsInWork(this Employee employee)`:
         işçinin hal-hazırda şirkətdə işləyib işləmədiyini göstərən bir metod olsun. Əgər `HireDate` indiki tarixdən əvvəl və `Salary` sıfırdan böyükdürsə, bu metod `true`, əks halda
        `bool` qaytarsın