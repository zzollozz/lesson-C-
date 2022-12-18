// М А С С И В

int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}

// Ф У Н К Ц И Я или М Е Т О Д
//    - не возращяющие ( без ретурна )

int[] array = new int[10]; // создание пустого масива для чисел длинной 10 символов

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// запуск методотов
FillArray(array);
// array[1] = 4;
PrintArray(array);

// возращающие ( с ретурном )

int IndexOf(int[] collection, int find)
{
    int lenIndex = collection.Length;
    int count = 0;

    int position = -1;

    while (count < lenIndex)
    {

        if (collection[count] == find)
        {
            position = count;
            break;
        }
        count++;
    }

    return position;
}


// запуск методотов

Console.WriteLine("- = - = - = - = - = - = - = - = -");

int pos = IndexOf(array, 4);

Console.WriteLine(pos);
