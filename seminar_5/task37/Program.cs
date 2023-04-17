// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];
    Random myRandom = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(0, 10);
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

void ShowDualSum(int[] array)
{
    int lenght = array.Length;
    if (lenght % 2 == 0)
    {
        for (int i = 0; i < lenght / 2; i++)
        {
            int sum = array[i] * array[lenght - i - 1];
            Console.Write($"{sum} ");
        }

    }
    else
    {
        for (int i = 0; i < lenght / 2; i++)
        {
            int sum = array[i] * array[lenght - i - 1];
            Console.Write($"{sum} ");
        }
        Console.Write($"{array[lenght / 2]} ");

    }
}


Console.Write("Введите длину массива: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = GenerateArray(lenght);
ShowArray(array);
Console.WriteLine();

ShowDualSum(array);