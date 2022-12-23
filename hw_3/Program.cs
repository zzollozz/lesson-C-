/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

System.Console.WriteLine("Программа провереяет является ли число палиндромом.");
System.Console.Write("Введите пятизначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb.ToString().Length != 5)
{
    System.Console.WriteLine("Число введено не верно!");
}
else if (numb.ToString()[0] == numb.ToString()[4] && numb.ToString()[1] == numb.ToString()[3])
{
    System.Console.WriteLine($"число {numb} является палиндромом!");
}
else
{
    System.Console.WriteLine($"число {numb}  НЕ является палиндромом!");
}


/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.WriteLine("Программа находит расстояние между точками в 3D пространстве.");

System.Console.Write("Введите коррдинату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите коордианту x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z1 - z2), 2)), 2);

System.Console.WriteLine($"Расстояние между точками в 3D пространстве: {result}");



/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

System.Console.WriteLine("Программа выдает таблицу кубов от 1 до числа N");
System.Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= numberN; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}