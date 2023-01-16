/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Задача 34: ");
int[] array = GetArray(10, 100, 999);
Console.WriteLine($"[{String.Join(", ", array)}]");
int result = 0;
foreach (int el in array)
{
    if (el % 2 == 0)
    {
        result += 1;
    }
}
Console.WriteLine($"Количество чётных чисел в массиве = {result}");


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. (позиции - это индексы, нечетные индексы это 1,3,5 и тд)
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Задача 36: ");
int[] arrayOne = GetArray(10, 0, 100);
Console.WriteLine($"[{String.Join(", ", arrayOne)}]");

int sumElem = 0;
for (int i = 0; i < arrayOne.Length; i++)
{
    if (i % 2 != 0)
    {
        sumElem += arrayOne[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumElem}");


/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.WriteLine("Задача 37: ");
int[] array2 = GetArray(10, 0, 9);

Console.WriteLine($"oldArray: [{String.Join(", ", array2)}]");

int[] arrayNew = new int[array2.Length / 2];
int count = 0;
while (count < array2.Length / 2)
{
    arrayNew[count] = array2[count] * array2[array2.Length - count - 1];
    count++;
}
Console.WriteLine($"Newarray: [{String.Join(", ", arrayNew)}]");


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
