// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
Console.WriteLine("Задача 46:");
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);


/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
*/
System.Console.WriteLine();
Console.WriteLine("Задача 48:");

Console.Write("Введите количество строк: ");
int rows_Z48 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns_Z48 = int.Parse(Console.ReadLine()!);

int[,] array_Z48 = GetArray_Z48(rows_Z48, columns_Z48);
PrintArray(array_Z48);


/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 49 2
5 9 2 9
64 4 4 4
...
*/
System.Console.WriteLine();
Console.WriteLine("Задача 49:");

Console.Write("Введите количество строк: ");
int rows_Z49 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns_Z49 = int.Parse(Console.ReadLine()!);

int[,] array_Z49 = GetArray(rows_Z48, columns_Z48, 0, 10);
PrintArray(array_Z49);

System.Console.WriteLine("----- результат -----");

ArraySquared(array);
PrintArray(array);

/*
Задача 51: Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали с индексами (0,0); (1;1) и т.д. 
*/
System.Console.WriteLine();
Console.WriteLine("Задача 51:");

Console.Write("Введите количество строк: ");
int rows_Z51 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns_Z51 = int.Parse(Console.ReadLine()!);

int[,] array_Z51 = GetArray(rows_Z48, columns_Z48, 0, 10);
PrintArray(array_Z51);

System.Console.WriteLine($"результат = {SumElArray(array_Z51)}");



// -------------------Методы---------------------------------
// Создание двухМерного массива

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
// Вывод на печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(); // перевод строки
    }
}

// Выполнение условия: Aₘₙ = m+n
int[,] GetArray_Z48(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = result[i, j] = i + j;
        }
    }
    return result;
}
// Возведение знаения в квадрат четных индексов
void ArraySquared(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
}

int SumElArray(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result += array[i, j];
            }
        }
    }
    return result;
}