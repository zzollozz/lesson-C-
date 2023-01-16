// --------------ВСЕ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ--------------

/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, 
будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Программа возводит число A в натуральную степень B.");

Console.Write("Ведите чило: ");
int number_1 = int.Parse(Console.ReadLine()!);
Console.Write("Ведите степень возведения: ");
int number_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {number_1} в степени {number_2} = {qwerty(number_1, number_2)}");


int qwerty(int A, int B)
{
    int count = 0;
    int result = 0;

    while(count < B)
    {
        result = result + (A * A);
        count ++;
    }
    return result;
}

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Программа выдаёт сумму цифр в числе.");

Console.Write("Ведите чило: ");
int numbers = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {numbers} его сумма цифр = {GetSumNumbers(numbers)}");


int GetSumNumbers(int numbers)
{
    int sumNumbers = 0;
    string result = numbers.ToString();
    for (int i = 0; i < result.Length; i++)
    {
        sumNumbers += Convert.ToInt32(new string(result[i], 1));
    }
    return sumNumbers;
}





/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
(числа берете любые) */

Console.WriteLine("Программа которая задаёт массив из 8 элементов и выводит их на экран.");

int[] Array = GetArray(8);
Console.WriteLine($"[{String.Join(", ", Array)}]");


int[] GetArray(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(10, 100);
    }
    return Array;
}