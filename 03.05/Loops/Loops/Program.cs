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
int n = Convert.ToInt32(Console.ReadLine());

switch (n)

{
    case 2:
        Console.WriteLine("pis");
        break;
    case 3:
        Console.WriteLine("kafi");
        break;
    case 4:
        Console.WriteLine("yaxsi");
        break;
    case 5:
        Console.WriteLine("ela");
        break;
    default:
         Console.WriteLine("2-5 arasi eded daxil edin");
        break;
}
