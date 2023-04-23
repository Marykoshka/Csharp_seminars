// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());

int[,] arrayInt = new int[m, n];

for (int i = 0; i < arrayInt.GetLength(0); i++)
{
    for (int j = 0; j < arrayInt.GetLength(1); j++)
    {
        arrayInt[i, j] = new Random().Next(1, 11);
        Console.Write(arrayInt[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

void PrintArray(int[,] pArray)
{
    for (int i = 0; i < pArray.GetLength(0); i++)
    {
        for (int j = 0; j < pArray.GetLength(1); j++)
        {
            Console.Write(pArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();

//ВОЗВОДИМ В КВАДРАТ ЧЕТНЫЕ ЭЛЕМЕНТЫ
for (int i = 0; i < arrayInt.GetLength(0); i += 2)
{
    for (int j = 0; j < arrayInt.GetLength(1); j += 2)
    {
        arrayInt[i, j] *= arrayInt[i, j];
    }
}
PrintArray(arrayInt);