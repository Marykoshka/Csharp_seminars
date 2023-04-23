// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
Console.Write("Количество строк массива (m): ");
int countRow = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива (n): ");
int countColumn = int.Parse(Console.ReadLine());

int[,] array = new int[countRow, countColumn];

//Посмотреть номера получившегося массива
for (int i = 0; i < countRow; i++)
{
    for (int j = 0; j < countColumn; j++)
    {
        Console.Write(i + ";" + j + " ");
    }
    Console.WriteLine();
}
// Заполнить массив рандомными элементами:
for (int i = 0; i < countRow; i++)
{
    for (int j = 0; j < countColumn; j++)
    {
        array[i, j] = new Random().Next(1, 11);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(array.Length);