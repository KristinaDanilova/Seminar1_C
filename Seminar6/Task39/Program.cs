﻿// Программа перевернет одномерный массив

int[] ReverseArray(int[] array)
{
    int size = array.Length;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[size - 1 - i];
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }

    return res;
}

int[] myArray = GetArray(10, 0, 10);
Console.Write(String.Join(" ", myArray));
Console.WriteLine();
Console.Write(String.Join(" ", ReverseArray(myArray)));