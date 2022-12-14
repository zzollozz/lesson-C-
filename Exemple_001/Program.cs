// Это первое занятие. Знакомство с языком
Console.WriteLine("Это первое занятие. Знакомство с языком");
Console.Write("Введите Имя: "); // вывод Данных
string username = Console.ReadLine(); // ввод Данных

// Console.WriteLine("это сторка конкатенация =>" + username);


// string - для текста (от 4 байт до 2 гб)
// int - для целых чисел, 32-разрядное целое число
// double - для вещественных чисел, 64-разрядное целое число
// bool - True and False

Console.WriteLine("Выполнения деления случайного первого числа  на 3");
double numberA = new Random().Next(1, 21); // рандомные числа
double numberB = 3;
Console.WriteLine(numberA + " / " + numberB);
// Console.WriteLine(numberB);
Console.Write("Ответ: ");
Console.WriteLine(numberA / numberB);

// Ветвление

if(username.ToLower() == "bob") // работа со строкой перевели в малый индекс
{
    Console.WriteLine("Приветствую тебя Начальник!");
}
else
{
    Console.Write("Привет, " + username);
}

// Цикл => While

int count = 0;
while(count < 10)
{
    Console.WriteLine("цикл while выполнился " + count + " раз");
    count ++;
}