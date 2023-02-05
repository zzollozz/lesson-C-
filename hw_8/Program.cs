/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.WriteLine("Задача 54:");
int[,] arrayZ54 = GetArray(4, 4, 0, 9);
PrintArray(arrayZ54);

System.Console.WriteLine();
System.Console.WriteLine("Отсортированный результат");
SortArray(arrayZ54);
PrintArray(arrayZ54);

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

System.Console.WriteLine();
Console.WriteLine("Задача 56:");
int[,] arrayZ56 = GetArray(4, 4, 0, 9);
PrintArray(arrayZ56);
SumElementsArray(arrayZ56);

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

System.Console.WriteLine();
Console.WriteLine("Задача 58:");
System.Console.WriteLine("Первая матрица");
int[,] matrix1 = GetArray(4, 4, 0, 9);
PrintArray(matrix1);

System.Console.WriteLine("Вторая матрица");
int[,] matrix2 = GetArray(4, 4, 0, 9);
PrintArray(matrix2);
System.Console.WriteLine("Произведение 2-х матриц");
PrintArray(ProductMatrix(matrix1, matrix2));


// ========== методы ==========

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

void SortArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int n = array[j, i];
            int c = i - 1;

            while (c >= 0 && array[j, c] < n)
            {
                array[j, c + 1] = array[j, c];
                array[j, c] = n;
                c--;
            }
        }
    }
}

void SumElementsArray(int[,] array)
{
    int[] res = new int[array.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        res[i] = temp;
    }
    int index = 0;
    for (int k = 1; k < res.Length; k++)
    {
        if (res[k] < res[0])
        {
            index = k;
        }
    }
    System.Console.WriteLine($"Строка с наименьшей суммой элементов: {index + 1}");
}


int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newArray = new int[matrix1.GetLength(0) - 1, matrix1.GetLength(1) - 1];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            newArray[i, j] = sum;
        }
    }
    return newArray;
}