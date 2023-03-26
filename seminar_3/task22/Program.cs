// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел  от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("введите число: ");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    if (i == x)
    {
    Console.Write(i * i);
    }
    else
    Console.Write(i * i + $", ");
}