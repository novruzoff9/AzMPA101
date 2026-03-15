//int[] arr = [23, 56, 34, 129];
//AzalanSira(arr);
//string word = "bakidan ne qeder uzaqdi";
//Console.WriteLine(LongestWord(word));
//Console.WriteLine(CountOfWord(word));

//#1Verilmiş massivi azalan sırada düzən metod
//void AzalanSira(int[]arr)
//{
//    Array.Sort(arr);
//    Array.Reverse(arr);
//    foreach (int a in arr)
//    {
//        Console.WriteLine(a);
//    }
//}



//string LongestWord(string word)
//{
//    string max = "";
//    string[] woRds = word.Split(' ');

//    foreach (string item in woRds)
//    {
//        if (item.Length > max.Length)
//            max = item;
//    }
//    return max;
//}


//int CountOfWord(string word)
//{
//    string[] array = word.Split(" ");
//    return array.Length;
//}


//Verilmis cumlede 3 herfden cox sozleri secib qaytaran metod
//void LongWordsInSentence(string cumle)
//{
//    string[] cumlex = cumle.Split(" ");
//    string result = "";

//    foreach (string soz in cumlex)
//    {
//        if (soz.Length > 3)
//        {
//            result += soz + " ";
//        }
//    }
//    Console.WriteLine(result);
//}
//string cumle = "bakidan ne qeder uzaqdi";
//LongWordsInSentence(cumle);



//Verilmiş massivdə ən böyük və ən kiçik elementin yerini dəyişən metod
void WrapElements(int[] arr)
{
    int max = arr.Max();
    int min = arr.Min();

    // {4,7,9,9,3}
    int maxIndex = Array.IndexOf(arr, max); // 2
    int minIndex = Array.IndexOf(arr, min); // 3
    int temp = arr[minIndex]; // 1
    arr[minIndex] = arr[maxIndex];
    arr[maxIndex] = temp;
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
}
int[] arr = { 4, 7, 1, 9, 3 };
WrapElements(arr);