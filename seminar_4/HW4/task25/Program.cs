// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int pow = int.Parse(Console.ReadLine());

int GetPow (int number, int pow)
{
    int result = number;

    for (int i = 1; i != pow; i++)
    {
        result = result * number;
    }

    return result;
}

int res = GetPow(number, pow);
Console.WriteLine($"{number} в степени {pow} равно {res}");