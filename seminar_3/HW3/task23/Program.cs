// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число: ");
int x = int.Parse(Console.ReadLine());

void Cube (int x)
{
    for (int i = 1; i <= x; i++)
    {
        if (i == x)
        {
        Console.Write(Math.Pow(x, 3));
        break;
        }
        else
        Console.Write(i * i + $", ");
    }
}

Cube(x);