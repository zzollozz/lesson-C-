// группы методов

void Metod1()
{
    Console.WriteLine("Автор …");
}


void Metod2(string msg){
    Console.WriteLine(msg);
}

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine($"{msg} № {i + 1}"); 
        i++;
    }
}


int Metod3() 
{
    return DateTime.Now.Year;
}

string Metod4(int count, string text)
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



// Вызовы методов

Metod1();
Metod2("Текст сообщения");
Metod21("Текст", 4);

int year = Metod3(); 
Console.WriteLine(year);

string res = Metod4(10, "|====");
Console.WriteLine(res);


// ЦЫКЛ  FOR

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = { i * j }");
    }
    Console.WriteLine();
}


//          Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{ newValue}";
        else result = result + $"{ text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replase(text, 'k', 'K');
Console.WriteLine(newText);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PtintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{ array[i]}");
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
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

Console.WriteLine("******************************************************************");
// PtintArray(arr);
SelectionSort(arr);
PtintArray(arr);