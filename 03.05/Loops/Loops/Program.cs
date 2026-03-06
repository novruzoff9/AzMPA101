//int input1 = int.Parse(Console.ReadLine());
//int input2 = Convert.ToInt32(Console.ReadLine());

//input olunan edede qeder olan ededlerin ceminin hesablanmasi

//Console.Write("n daxil et: ");
//int n = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i<=n; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);

//switch case ile, input olunan qiymete uygun cixis ver:
//(2 - “Pis”, 3 - “Kafi”, 4 - “Yaxsi”, 5 -”Ela”, 
//Eks halda “2 - 5 arasi eded daxil edin”)

//int n = 3;
//int n = Convert.ToInt32(Console.ReadLine());

//switch (n)

//{
//    case 2:
//        Console.WriteLine("pis");
//        break;
//    case 3:
//        Console.WriteLine("kafi");
//        break;
//    case 4:
//        Console.WriteLine("yaxsi");
//        break;
//    case 5:
//        Console.WriteLine("ela");
//        break;
//    default:
//         Console.WriteLine("2-5 arasi eded daxil edin");
//        break;
//}

// verilmis n sayda daxil edilen ededin ceminin tapilmasi
//int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (int i = 0; i < n; i++)
//{
//    int input = Convert.ToInt32(Console.ReadLine());
//    sum += input;
//}
//Console.WriteLine(sum);

//int x = Convert.ToInt32(Console.ReadLine()); // 5
//int y = Convert.ToInt32(Console.ReadLine()); // 3
//int netice = 1;
//for (int i = 0; i < y; i++)
//{
//    netice *= x;
//}
//Console.WriteLine(netice);

//int netice = 1;
//while (true)
//{
//    int x = Convert.ToInt32(Console.ReadLine());
//    if (x == 0)
//    {
//        break;
//    }
//    netice *= x;
//}
//Console.WriteLine(netice);

//string password = "salam123";
//while (true)
//{
//    string input = Console.ReadLine();
//    if(input == password)
//    {
//        Console.WriteLine("Parol duzgundur");
//        break;
//    }
//    Console.WriteLine("Sifre duzgun deyil");
//}


//int x = Convert.ToInt32(Console.ReadLine()); // 17
//int y = Convert.ToInt32(Console.ReadLine()); // 18
//int maxi = -1;
//for (int i = 0; i <= x; i++)
//{
//    if (i % y == 0)
//    {
//        maxi = i;
//    }
//}
//Console.WriteLine(maxi);