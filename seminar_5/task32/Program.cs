// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

Console.Write("Введите однозначное число: ");
int num = int.Parse(Console.ReadLine());
int[] array = GenerateArray(num);
ShowArray(array);
Console.WriteLine("");
ChangeArray(array);
ShowArray(array);
