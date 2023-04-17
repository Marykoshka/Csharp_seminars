// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int GetCountDigit(int number)
{
    int count = 0;
    int numberA = number;
    while (numberA != 0)
    {
        numberA = numberA / 10;
        count++;
    }

    return count;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.Write($"Количество цифр {GetCountDigit(a)}");