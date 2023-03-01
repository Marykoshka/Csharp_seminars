// 

Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В: ");
int numberB = int.Parse(Console.ReadLine());

int numsqr = numberA * numberA;

if(numsqr == numberB)
{
        Console.WriteLine("Число В - это квадрат числа А");
}
else
{
    Console.WriteLine("Число В - это не квадрат числа А");
}