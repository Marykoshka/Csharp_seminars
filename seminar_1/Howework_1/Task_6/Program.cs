﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

int res = num % 2;

if(res == 0)
{
    Console.WriteLine($"Число {num} - чётное.");
}
else
{
    Console.WriteLine($"Число {num} - нечётное.");
}
