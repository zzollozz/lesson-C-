﻿// // Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// System.Console.WriteLine("Введите переменную x: ");
// int x = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите переменную y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x > 0 && y > 0)
// {
//     System.Console.WriteLine("Точка находится в первой четверти");
// }
// else if(x < 0 && y > 0)
// {
//     System.Console.WriteLine("Точка находится во второй четверти");
// }
// else if(x < 0 && y < 0)
// {
//     System.Console.WriteLine("Точка находится в третьей четверти");
// }
// else if(x > 0 && y < 0)
// {
//     System.Console.WriteLine("Точка находится в четвертой четверти");
// }
// else{
//     System.Console.WriteLine("Х и У должны не равняться нулю!");
// }


// Задача № __
// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

// System.Console.WriteLine("Введите номер четверти: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number == 1)
// {
//     System.Console.WriteLine("x > 0 && y > 0 (Первая четверть)");
// }
// else if(number == 2)
// {
//     System.Console.WriteLine("x < 0 && y >0 (Вторая четверть)");
// }
// else if(number == 3)
// {
//     System.Console.WriteLine("x < 0 && y < 0 (Третья четверть)");
// }
// else if(number == 4)
// {
//     System.Console.WriteLine("x > 0 && y < 0 (Четвертая четверть)");
// }
// else
// {
//     System.Console.WriteLine("Такой четверти не существует! ");
// }

//Задача 3. Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

// ((x1 - x2)^2 + (y1-y2)^2)^(1/2)

System.Console.Write("Введите коррдинату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)), 4);
System.Console.WriteLine($"Расстояние между двумя точками: {result}");


//Задача 4. Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.

System.Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= x; i++)
// {
// System.Console.WriteLine(Math.Pow(i, 2));
// }
int count = 1;
while(count <= x)
{
System.Console.Write(Math.Pow(count, 2)+" ");
count++;
}