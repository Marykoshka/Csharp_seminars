// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int CountSumInNumber (int number)
{
    int inputNum = number;
    int sum = 0;
    int cuttedNum = 0;

    for (int i = 0; inputNum != 0; i++)
    {
        cuttedNum = inputNum % 10;
        sum = sum + cuttedNum;
        inputNum = inputNum / 10;
    }

    return sum;
}

int result = CountSumInNumber(number);
Console.WriteLine($"Сумма цифр введенного числа равна {result}");