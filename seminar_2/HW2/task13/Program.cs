// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");

// ЛЕГКИЙ СПОСОБ ЧЕРЕЗ СТРОКИ:

// string num = int.Parse(Console.ReadLine()).ToString();

// if (num.Length >= 3)
// {
//     Console.Write($"Третья цифра числа: {num[2]}");
// }
// else
// {
//     Console.Write($"Третьей цифры нет или введен неверный формат числа");
// }


// ВТОРОЙ СПОСОБ:

int num = int.Parse(Console.ReadLine());
int temp = num;

int count = 0;
while (temp != 0)
{
    temp = temp / 10;
    count++;
}

if (count >= 3)
{
    Console.WriteLine($"Введено {count}-значное число, третья цифра - {(num / (int)Math.Pow(10, count - 3)) % 10}");
}
else
{
    Console.WriteLine($"Третьей цифры нет или введен неверный формат числа");
}
