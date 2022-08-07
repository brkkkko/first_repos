﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while(i < length)
    {
        collection[i] = new Random().Next(1,10);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int i = 0;
    int position = -1;
    while(i < count)
    {
        if(collection[i] == find)
        {
            position = i;
            break;
        }
        i++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 3;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);