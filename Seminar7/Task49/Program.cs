﻿// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные
// и замените эти элементы на их квадраты.

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArrayEvenInPower (int[,] collection2)
{
    for (int rows = 0; rows < collection2.GetLength(0); rows+=2)
    {
        for (int cols = 0; cols < collection2.GetLength(1); cols+=2)
        {
            {
                int value = collection2[rows,cols];
                collection2[rows,cols] = value * value;
            }
        }
    }
}        

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n);
PrintArray(myArray);
ArrayEvenInPower(myArray);
PrintArray(myArray);