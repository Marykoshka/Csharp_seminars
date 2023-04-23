// // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
//Посмотреть номера получившегося массива

// double [,] GenerateArray(int countRow, int countColumn)
// {
//     double [,] array = new double[countRow, countColumn];
//     Random rand = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Math.Round(rand.NextDouble() * 10, 2);
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] pArray)
// {
//     for (int i = 0; i < pArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < pArray.GetLength(1); j++)
//         {
//             Console.Write(pArray[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine();

// Console.Write("Количество строк массива (m): ");
// int countRow = int.Parse(Console.ReadLine());

// Console.Write("Количество столбцов массива (n): ");
// int countColumn = int.Parse(Console.ReadLine());

// double [,] resultArray = GenerateArray(countRow, countColumn);
// PrintArray(resultArray);


// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GenerateArray(int m, int n)
{
    int[,] arrayInt = new int[m, n];
    for (int i = 0; i < arrayInt.GetLength(0); i++)
    {
        for (int j = 0; j < arrayInt.GetLength(1); j++)
        {
            arrayInt[i, j] = new Random().Next(1, 10);
        }
    }
    return arrayInt;
}

void PrintArray(int[,] pArray)
{
    for (int i = 0; i < pArray.GetLength(0); i++)
    {
        for (int j = 0; j < pArray.GetLength(1); j++)
        {
            Console.Write(pArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetElementByPosition(int[,] pArray, int inputedM, int inputedN)
{
    int i = pArray.GetLength(0);
    int j = pArray.GetLength(1);
    if (inputedM < i && inputedN < j)
    {
        Console.WriteLine($"В координатах [{inputedM}, {inputedN}] лежит значение {pArray[inputedM, inputedN]}");
    }
    else
    {
        Console.WriteLine($"В координатах [{inputedM}, {inputedN}] значение не существует");
    }
}

int [,] resArray = GenerateArray(3, 5);
PrintArray(resArray);
Console.WriteLine();

Console.Write("Введите искомую координату m: ");
int inputedM = int.Parse(Console.ReadLine());

Console.Write("Введите искомую координату n: ");
int inputedN = int.Parse(Console.ReadLine());
Console.WriteLine();

GetElementByPosition(resArray, inputedM, inputedN);
Console.WriteLine();

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void GetAverageInColumn(int[,] pArray)
{
    for (int j = 0; j < pArray.GetLength(1); j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < pArray.GetLength(0); i++)
        {
            sum = sum + pArray[i, j];
        }
        average = Math.Round(sum / pArray.GetLength(0), 1);
        Console.Write($"Среднее арифметическое столбца {j + 1} равно сумма {sum} деленная на {pArray.GetLength(0)} равна {average}");
        Console.WriteLine();
    }

}

GetAverageInColumn(resArray);