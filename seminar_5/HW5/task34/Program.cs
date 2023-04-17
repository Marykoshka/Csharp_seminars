//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int GetCountOfEvenNumbers(int [] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0) count++;
    }
    return count;
}

//----------------------------------------------
Console.Write("Введите длину массива: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = GenerateArray(lenght);
PrintArrayToConsole(array);
Console.WriteLine();
Console.WriteLine(GetCountOfEvenNumbers(array));