﻿// SЗадача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());

int[,] arrayInt = new int[m, n];

for (int i = 0; i < arrayInt.GetLength(0); i++)
{
    for (int j = 0; j < arrayInt.GetLength(1); j++)
    {
        arrayInt[i, j] = i + j;
        Console.Write(arrayInt[i, j] + " ");
    }
    Console.WriteLine();
}
