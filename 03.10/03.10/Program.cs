// Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın

//int number = Convert.ToInt32(Console.ReadLine());
//bool ispow = true;
//while (number > 0)
//{
//    if(number % 2 == 1)
//    {
//        ispow = false;
//        break;
//    }
//    number /= 2;
//    if(number == 1)
//        break;
//}

//if(ispow)
//    Console.WriteLine("2nin quvvetidir");
//else
//    Console.WriteLine("2nin quvveti deyil");





// Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın

//int number = Convert.ToInt32(Console.ReadLine()); //4
//int count = 0; // 3
//while (number > 0)
//{
//    number /= 10;
//    count++;
//}
//Console.WriteLine(count);



//Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiryi indexi tapin, yoxdursa -1 print olsun

//int[] numbers = [1, 2, 3, 4, 6, 7, 8];
//int search = Convert.ToInt32(Console.ReadLine()); // 3
//int index = -1;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == search)
//        index = i;
//}
//Console.WriteLine(index);

//Verilmis bir stringin yalniz ortadaki simvolunu cixisa verin. eger cut sayda simvol varsa ortadaki iki simvolu ciisa verin. 

string s = "market";

if (s.Length % 2 == 1)
{
    Console.WriteLine(s[s.Length / 2]);
}
else
{
    Console.Write(s[s.Length / 2 - 1]);
    Console.WriteLine(s[s.Length / 2]);
}



//Verilmiş tam ədədin rəqəmlərinin cəmini tapın
int number = Convert.ToInt32(Console.ReadLine()); // 0
int sum = 0;
while (number > 0)
{
    sum += number % 10; // 4 + 2 + 1
    number /= 10;
}
Console.WriteLine(sum);