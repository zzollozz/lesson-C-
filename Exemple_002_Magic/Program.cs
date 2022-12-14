﻿Console.Clear(); // отчистка консоли

// Console.SetCursorPosition(10, 4); // расположение курсора в поле Терминала
// Console.WriteLine("+"); // Вывод какого то символа в указанной координате в поле терминала

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; // определение стартовой точки перед началом цикла

int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0, 3); // рандомно выбераем одну из сторон
    if (what == 0)
    {
        x = (x + xa) / 2;   
        y = (y + ya) / 2;  
    }

    if (what == 1)
    {
        x = (x + xb) / 2;   
        y = (y + yb) / 2;  
    }

    if (what == 2)
    {
        x = (x + xc) / 2;   
        y = (y + yc) / 2;   
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}


