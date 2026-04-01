using _03._31;
Person person1 = new(5, "Aydin", new(2005, 04, 28));

//Console.WriteLine(person1.Age);
//person1.GetInfo();

Student student1 = new Student(101, "Eli Memmedov", new DateTime(2000, 5, 15), "ST2024001", 37);

student1.GetInfo();
Console.WriteLine("\n");
Console.WriteLine(student1.GetRole());