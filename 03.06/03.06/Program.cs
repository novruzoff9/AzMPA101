// Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
string str = "test";
bool hasValue = false;
for (int i = 0; i < str.Length; i++)
{
   if (str[i] == 'a' || str[i] == 'A')
   {
       hasValue = true;
       break;
   }
}
if (hasValue)
{
   Console.WriteLine("A herfi var");
}
else
{
   Console.WriteLine("A herfi yoxdur");
}



// Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
string str = "test";
int count = 0;
for (int i = 0; i < str.Length; i++)
{
   if (str[i] == 'a' || str[i] == 'A')
   {
       count++;
   }
}
Console.WriteLine(count);


//Ədədlər massivindəki bütün elementləri faktorialına yüksəldin 
//(məs: { 5, 4, 6} -> { 120, 24, 720 })
int[] numbers = [5, 4, 6];
foreach (int number in numbers)
{
   int faktorial = 1;
   for (int i = 1; i <= number; i++)
   {
       faktorial *= i;
   }
   Console.WriteLine(faktorial);
}

//Ədədlər massivində massivdə olan ən kiçik ədədi çıxardın 
//(məs: { 7, 12, 5, 8} -> { 7, 12, 8})

int[] numbers = [7, 12, 5, 8, 3];
int mini = numbers[0]; // 5
foreach (int number in numbers)
{
   if(number < mini)
   {
       mini = number;
   }
}
for (int i = 0; i < numbers.Length; i++)
{
   if (numbers[i] != mini)
   {
       Console.WriteLine(numbers[i]);
   }
}



// N və M ədədi veriləcək. o aralıqda olan polindrom ədədləri tapıb çıxışa verən proqram
int n = Convert.ToInt32(Console.ReadLine()); //145
int m = Convert.ToInt32(Console.ReadLine());

for (int i = n; i <= m; i++)
{
    int number = i; // 0
    int ters_number = 0;
    while(number > 0) // 0
    {
        int qaliq = number % 10; // 1
        ters_number = ters_number * 10 + qaliq; // 541
        number = number / 10;
    }
    if(i == ters_number)
    {
        Console.WriteLine(i);
    }
}
