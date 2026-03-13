
MaxNumber(5, 2, 7);
//İstifadəçidən 3 ferqli eded alın. Onun reqemlerden mumkun olan en boyuk ededi yaradın və çap edin.  

void MaxNumber(int a, int b, int c)
{
    int max = a; // 3
    int min = 0; // 3
    if(b > c && b > a)
        max = b;
    else if (c > a && c > b)
        max = c;

    if (b < c && b < a)
        min = b;
    else if (c < a && c < b)
        min = c;

    int mid = a + b + c - (min + max);
    Console.WriteLine($"{max}{mid}{min}");
}


//Metod massiv qəbul edib, orada olan ən kiçik elementi qaytaran metod
int ArrMin(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

//Verilmish arrayin icindeki cut ededlerin cemini tapin.
void EvenSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            sum += arr[i];
    }
    Console.WriteLine(sum);
}


//Metod - a x və y göndəriləcək. x üstü y-i hesablayıb qaytaracaq
int Quvvet(int x, int y)
{
    int result = 1; // 125
	for (int i = 0; i < y; i++) // 0,1,2
	{
        result *= x;
    }
    return result;
}
//Console.WriteLine(CountNum(input));

//Metod - a n dəyəri göndəriləcək. 1-dən n-dək olan 2 rəqəmləri ədələrin sayını qaytaracaq

int CountNum(int n)
{
    int count = 0;
    for (int i = 1; i < n; i++)
    {
        if (i >= 10 && i <= 99)
        {
            count++;
        }
    }
    return count;
}

