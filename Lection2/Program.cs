// Задача №1. Найдем максимальное из 9 чисел.
// Решение 1:
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 3900;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 2300;
int c3 = 313;
/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
*/
/*
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);
*/

// Решение с массивом:
/*
int[] array = {11,211,31,41,15,61,17,18,19};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max = Max(
    Max(array[0],array[1],array[2]), 
    Max(array[3],array[4],array[5]), 
    Max(array[6],array[7],array[8]));

Console.WriteLine(max);
*/

// Задача №2. Имеется одномерный массив array из n элементов, требуется найти элемент массива, 
// равный find.
/*
int[] array = { 1, 2, 31, 4, 15, 16, 4, 18 };

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
*/
/*
Console.Clear();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 20);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(" " + coll[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[15];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/

Console.Clear();

int find = 15;

void FillArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        array[index] = new Random().Next(1, 21);
        index++;
    }
}

void PrintArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        Console.Write(" " + array[index]);
        index++;
    }
}

int IndexFind(int[] array, int find)
{
    int size = array.Length;
    int index = 0;
    int position = -1;

    while (index < size)
    {
        if (array[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int result = IndexFind(array,find);
Console.WriteLine(result);

Console.ReadLine();