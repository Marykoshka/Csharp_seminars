// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Получить суммы чисел в диапазоне
int GetSumRange(int startNumber, int endNumber)
{
    int sum = 0;
    for (int i = startNumber; i <= endNumber; i++)
    {
        sum = sum + i;
    }
    
    return sum;
}

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());

int sum = GetSumRange(1, a);
Console.WriteLine(sum);