// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];
    Random myRandom = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(-9, 200);
    }

    return array;
}

void ShowArray(int[] array)
{
    //Вывод с помощье foreach
    foreach (var elem in array)
    {
        Console.Write("{0} ", elem);
    }
}

int GetCountInRange(int[] array, int start, int finish)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= finish)
        {
            count++;
        }
    }
    return count;
}


Console.Write("Введите длину массива: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = GenerateArray(lenght);
ShowArray(array);
Console.WriteLine();

Console.Write("Введите начало интервала: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Введите начало интервала: ");
int finish = int.Parse(Console.ReadLine());

int countInRange = GetCountInRange(array, start, finish);
Console.WriteLine();
Console.WriteLine(countInRange);