//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// 3 7 22 2 78] -> 76

void GenerateArray(double[] array)
{
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * 100, 2);
    }
}

void PrintArrayToConsole(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}

void MaxMinDifference(double [] collection)
{
    double max = collection[0];
    double min = collection[0];
    for (int i = 1; i < collection.Length; i++)
    {
        if (collection[i] > max) max = collection[i];
        if (collection[i] < min) min = collection[i];
    }
    Console.Write($"Разница между минимальным и максимальным значениями - ");
    Console.Write(Math.Round(max - min, 2));
}

//----------------------------------------------
Console.Write("Введите длину массива: ");
int lenght = int.Parse(Console.ReadLine());
double[] array = new double[lenght];
GenerateArray(array);
PrintArrayToConsole(array);
MaxMinDifference(array);
// Console.WriteLine(GetSumOfNumbersInOddIndexes(array));