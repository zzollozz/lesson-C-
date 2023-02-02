/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Задача 47:");
Console.Write("Введите количество строк: ");
int rowsZ47 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columnsZ47 = int.Parse(Console.ReadLine()!);

double[,] arrayZ47 = GetArrayZ47(rowsZ47, columnsZ47);

PrintArrayZ47(arrayZ47);

/*
Задача 50. Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве,
а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
System.Console.WriteLine();
Console.WriteLine("Задача 50:");
int[,] arrayZ50 = GetArray(5, 5, 0, 50);
Console.Write("Укажите число для поиска в массиве: ");
int namber = int.Parse(Console.ReadLine()!);
GetNamberArray(arrayZ50, namber);
System.Console.WriteLine("вывод массива для проверки:");
PrintArray(arrayZ50);

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
System.Console.WriteLine();
Console.WriteLine("Задача 52:");
int[,] arrayZ52 = GetArray(2, 2, 0, 50);
System.Console.WriteLine("Задан массив:");
PrintArray(arrayZ52);

System.Console.WriteLine();
// Console.WriteLine(arrayZ52.GetLength(1));
System.Console.WriteLine("Cреднее арифметическое элементов в каждом столбце: ");
for (int j = 0; j < arrayZ52.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arrayZ52.GetLength(0); i++)
    {
        sum += arrayZ52[i, j];
    }
    Console.Write($"{sum / arrayZ52.GetLength(0)}");
}




// ========== методы ==========

double[,] GetArrayZ47(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
    return result;
}

void PrintArrayZ47(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetNamberArray(int[,] arr, int namber)
{
    bool Flag = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == namber)
            {
                Flag = true;
            }
        }
    }
    if (Flag)
    {
        Console.WriteLine($"Заданное число: {namber} найдено!");
    }
    else
    {
        Console.WriteLine($"Заданное число: {namber} НЕ найдено!");
    }
}