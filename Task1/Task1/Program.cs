//Verilmiş ədədin müsbət mənfi və ya 0-a bərabər olması

//double num = -3.5;

//if (num > 0)
//{
//    Console.WriteLine("musbet");
//}
//else if (num < 0)
//{
//    Console.WriteLine("menfi");
//}
//else
//{
//    Console.WriteLine("sifirdir");
//}

// Verilmis ədəd cüt ədəddirsə 
//int num = 3;
//if (num % 2 == 0)
//    Console.WriteLine("cut ededir");
//else
//{
//    Console.WriteLine("tek ededir");
//}


//Yaş dəyişəni təyin et. Əgər
//0 - 18: usaq
//18 - 65 yetiskin
//65> yasli 


//int age = 18;

//if (age >= 0 && age < 18) 
//{
//    Console.WriteLine("Usaq");
//}
//else if (age>=18 && age<65)
//{
//    Console.WriteLine("Yetiskin");
//}
//else
//{
//    Console.WriteLine("Yasli");
//}

//mebleg deyiseni verilir. Əgər:
//məbləğ 100dən azdırsa olduğu kimi
//100-500 arasıdırsa 10% endirim
//500dən böyükdürsə 20% endirim tətbiq olunsun.
//sonda odenilmeli mebleg ekranda gosterilsin

//double pay = 600;
//if (pay < 100)
//{
//    Console.WriteLine(pay);
//}
//else if (pay >= 100 && pay < 500) 
//{
//    pay = pay * 0.9;
//    Console.WriteLine(pay);
//}
//else
//{
//    pay = pay * 0.8;
//    Console.WriteLine(pay);
//}


//maas ve tecrube ili deyisenleri verilir eger:
//tecrube 0-2 il arasidirsa bonus yoxdur
//2-5 il arasidirsa 15% bonus
//5 ilden coxdursa 25% bonus

//double salary = 15;
//int year =2;
//if (year > 0 && year <= 2)
//{
//    Console.WriteLine("bonus yoxdur");
//}
//else if(year>2&& year <= 5)
//{
//    salary =salary+( salary*0.15);
//    Console.WriteLine(salary);   
//}
//else
//{
//    salary = salary+(salary * 0.25);
//    Console.WriteLine(salary);
//}


//mesafe(km ilə) verilib.odenisi hesablamag lazimdirI
//0-5 km arasi 5 manat
//5-15 km arasi 5 manat + her km ucun 0.8 manat
//15 km ve cox 5 manat + her km ucun 0.6 manat

int dist = 7;
int manat = 5;
if (dist >= 0 && dist < 5)
{
    Console.WriteLine(manat);
}
else if (dist >= 5 && dist < 15)
{
    double x = dist * 0.8 + manat;
    Console.WriteLine(x);
}
else
{
    double y = dist * 0.6 + manat;
    Console.WriteLine(y);
}