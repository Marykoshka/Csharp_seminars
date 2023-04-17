// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];
    Random myRandom = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(-9, 10);
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

bool FindElementInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}


Console.Write("Введите длину массива: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = GenerateArray(lenght);
ShowArray(array);
Console.WriteLine();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());


bool isPresent = FindElementInArray(array, num);
Console.WriteLine();
Console.WriteLine(isPresent);
