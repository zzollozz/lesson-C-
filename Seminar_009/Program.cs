
/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.Write("Введи число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(1, N));

/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/
System.Console.WriteLine();
System.Console.WriteLine("Задача 65");
Console.WriteLine("Введите число  N");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число  M");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(a, b));


/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
System.Console.WriteLine();
System.Console.WriteLine("Задача 67");
Console.WriteLine("Введите число  N");
int numbers = int.Parse(Console.ReadLine()!);
Console.WriteLine(NumberFiguresSum(numbers));

/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
System.Console.WriteLine();
System.Console.WriteLine("Задача 69");
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine(PoweredBy(A, B));

// ------------------Методы------------------

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

int NumberFiguresSum(int N)
{
    if (N == 0) return 0;
    return (N % 10 + NumberFiguresSum(N / 10));
}

int PoweredBy(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    else if (B == 1)
    {
        return A;
    }
    return (A * PoweredBy(A, B - 1));

}