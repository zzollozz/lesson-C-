// Это первое занятие. Знакомство с языком

Console.Write("Введите Имя: "); // вывод Данных
string username = Console.ReadLine(); // ввод Данных
Console.Write("Привет, ");
Console.WriteLine(username);

// string - для текста (от 4 байт до 2 гб)
// int - для целых чисел, 32-разрядное целое число
// double - для вещественных чисел, 64-разрядное целое число
// bool - True and False

Console.WriteLine("деление случайного первого числа  на 3");
double numberA = new Random().Next(1, 21); // рандомные числа
double numberB = 3;
Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.Write("Ответ: ");
Console.WriteLine(numberA / numberB);

// Ветвление




