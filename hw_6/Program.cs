/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
Для строки можно использовать данный метод:
string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
(пользователь вводит в консоли числа через пробел и они формируют строку)
*/

System.Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.");
System.Console.Write("Введите любое колличество чисел через пробел: ");
string stringArray = Console.ReadLine()!;
string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int count = 0;
for (int i = 0; i < numS.Length; i++)
{
    if( int.Parse(numS[i]) > 0)
    {
        count += 1;
    }
}
Console.WriteLine($"Вы указали массив из чисел: [{String.Join(", ", numS)}]");
System.Console.WriteLine($"из указанного масива {count} чисел больше 0");



/*
Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов 
(не менее 6) в промежутке от 0 до 100, а на выходе выводит этот же массив, 
но отсортированный по возрастанию(от меньшего числа к большему).
*/
System.Console.WriteLine();

Console.WriteLine("Задача 43: Программа принимает массив и сортирует по возрастанию");
int[] array = GetArray(7, 0, 100);
Console.WriteLine($"Mассив из чисел: [{String.Join(", ", array)}]");
SortArray(array);
Console.WriteLine($"отсортированный массив: [{String.Join(", ", array)}]");




// ========== методы ==========


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int n = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > n)
        {
            array[j + 1] = array[j];
            array[j] = n;
            j--;
        }
    }
}
