// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа: Ex: 456 -> 6
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int res = num % 10;

Console.WriteLine(res);
