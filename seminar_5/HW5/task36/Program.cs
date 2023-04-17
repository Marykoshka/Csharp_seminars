//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }

    return array;
}

void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}

int GetSumOfNumbersInOddIndexes(int [] collection)
{
    int sum = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (i % 2 != 0) sum = sum + collection[i];
    }
    return sum;
}

//----------------------------------------------
Console.Write("Введите длину массива: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = GenerateArray(lenght);
PrintArrayToConsole(array);
Console.WriteLine();
Console.WriteLine(GetSumOfNumbersInOddIndexes(array));