/*
Задача 64: Выполнить с помощью рекурсии.
Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

System.Console.WriteLine();
System.Console.WriteLine("Задача 64");
Console.Write("Введите число  N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbers(1, N));

/*
Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

System.Console.WriteLine();
System.Console.WriteLine("Задача 66");
Console.Write("Введите число  M: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите число  N: ");
int end = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {start} до {end} = {SumNumbers(start, end)}");

/*
Задача 68: Выполнить с помощью рекурсии.
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
System.Console.WriteLine();
System.Console.WriteLine("Задача 68");
Console.Write("Введите число  n: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число  m: ");
int m1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(FanAkkerman(n1, m1));


// ---------------= Методы =-----------------


string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (end + " " + PrintNumbers(start, end - 1));
}

int SumNumbers(int start, int end)
{
    if (start == end + 1) return 0;
    return (start + SumNumbers(start + 1, end));
}

int FanAkkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
        return FanAkkerman(n - 1, 1);
    else
        return FanAkkerman(n - 1, FanAkkerman(n, m - 1));
}