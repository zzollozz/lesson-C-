
// Написать программу, которая на вход принимает число и возвращает в квадрат
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

// математический метод
int sqr = number * number;

// библиотеки
int aqr1 = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine("Математический метод  " + sqr + "  библиотеки"   + aqr1);

Console.WriteLine($"Число {number} в квабрате равно: Математический метод {sqr} библиотеки {aqr1}");




/* Задача 2: Напишите программу, которая на вход принимает одно число (N), 
 а на выходе показывает все целые числа в промежутке от -N до N. */
Console.Clear();
Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine()!);

int num1 = -num;

while(num1 <= num){
    Console.Write($"{num1} ");
    num1++;
}

/* Задачи семинара:
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго. */
Console.Clear();
Console.WriteLine("Введите первое число: ");
int numb_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numb_2 = int.Parse(Console.ReadLine()!);
int result = numb_2 * numb_2;

 if(numb_1 == result){
    Console.WriteLine($"число {numb_1} является квадратом {numb_2}");
 }
 else{
    Console.WriteLine($"число {numb_1} НЕ является квадратом {numb_2}");
 };


/* 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.*/
Console.Clear();
Console.WriteLine("Укажите номер дня недели: ");
int day_num = int.Parse(Console.ReadLine()!);

if(day_num == 1){
    Console.WriteLine("Понедельник");
};
if(day_num == 2){
    Console.WriteLine("Вторник");
};
if(day_num == 3){
    Console.WriteLine("Среда");
};
if(day_num == 4){
    Console.WriteLine("Четверг");
};
if(day_num == 5){
    Console.WriteLine("Пятница");
};
if(day_num == 6){
    Console.WriteLine("Суббота");
};
if(day_num == 7){
    Console.WriteLine("Воскресенье");
};

/* 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. */
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine()!);
int res = n % 10;
Console.WriteLine(res);