/* Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Clear();
Console.WriteLine("Задача 1. Определение большего и меньшего числа");
Console.WriteLine("Введите первое число: ");

int number_a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number_b = int.Parse(Console.ReadLine()!);

if (number_a > number_b)
{
    Console.WriteLine($"Число {number_a} больше числа {number_b}");
}
else
{
    Console.WriteLine($"Число {number_a} меньше числа {number_b}");
}


/* Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("* * * * * * * * ");
Console.WriteLine("Задача 2. Определение максимального числа из трех");

Console.WriteLine("Введите первое число: ");
int number_A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int number_B = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int number_C = int.Parse(Console.ReadLine()!);

int maxNumber = 0;

if (number_A > number_B)
{
    maxNumber = number_A;
}
else
{
    maxNumber = number_B;
}
if (maxNumber < number_C)
{
    maxNumber = number_C;
}
Console.WriteLine($"Ответ: {maxNumber}");



/* Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("* * * * * * * * ");
Console.WriteLine("Задача 3. Определение четного числа");

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} является четным");
}
else
{
    Console.WriteLine($"Число {num} НЕ является четным");
}


/* Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("* * * * * * * * ");
Console.WriteLine("Задача 4. Определение четного числа от 1 до N.");
Console.Write("Укажите число N: ");
int lenNumber = int.Parse(Console.ReadLine()!);
int count = 1;
while (count < lenNumber)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}