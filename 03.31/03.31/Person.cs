using System.Security.Cryptography.X509Certificates;

namespace _03._31
{
    internal class Person
    {
        public int Id { get; init; }
        public DateTime RegistrationDate { get; init; }

        public Person(int id, string fullName, DateTime birthDate)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;
            RegistrationDate = DateTime.Now;
        }



        private string fullName;
        public string FullName {
            get
            {
                return fullName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    {
                    Console.WriteLine("Ad bos ola bilmez."); ;
                    }
                else
                {
                    fullName = value;
                }
            }
        }
        private DateTime birthDate;
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                if (value>DateTime.Now)
                {
                    Console.WriteLine("Movcud tarixden sonra ola bilmez.");
                }
                else
                {
                    birthDate = value;
                }
            }
        }
        public int Age
        {
            get
            {
                TimeSpan diff = DateTime.Now - birthDate;
                return diff.Days / 365;
            }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Id: {Id}, Ad: {FullName}, Dogum tarixi: {birthDate}, Yas: {Age}, Qeydiyyat tarixi {RegistrationDate}");
        }
        public virtual string GetRole()
        {
            return "person";
        }
    }
}
