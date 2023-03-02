//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число В: ");
int numberB = int.Parse(Console.ReadLine());


if(numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}
else if(numberA < numberB)
{
    Console.WriteLine($"max = {numberB}");
}
else if(numberA == numberB)
{
    Console.WriteLine("Число A равно числу B");
}
// Хотела вывести ошибку, не получилось, потому что при введении с клавиатуры любой буквы или 
// символа формат по идее строковый, как решить - не знаю.
else
{
    Console.WriteLine("Введено не число"); 
}