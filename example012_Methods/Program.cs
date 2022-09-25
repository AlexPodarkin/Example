Console.Clear();

void Method1()
{ Console.WriteLine("Autor Aleks"); }
//Method1();
void Method2(string mgs)
{
    Console.WriteLine(mgs);
}
//Method2(mgs: "textMessege");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    { Console.WriteLine(msg); i++; }
}
//Method21(msg: "Hi",count: 3);
//Method21(count: 3,msg: "Hi");
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//System.Console.WriteLine(year);

/* string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10,"bla "); */

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "bla ");
//Console.WriteLine(res);

/* for (int i = 2; i <= 10; i++)
{
    System.Console.WriteLine($"\n   Umnochenie na {i} \n");
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i*j}");
    } 
} */

string text = "-я думаю сказал князь, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашего милого Винцекенгорсе,"
            + "кккк сссс кккк сссс";
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}

/* string newText = Replase(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText,'к','К');
Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replase(newText,'с','С');
Console.WriteLine(newText);
System.Console.WriteLine(); */

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

