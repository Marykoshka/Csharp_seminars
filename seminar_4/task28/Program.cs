// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int GetMultiple(int startNumber, int endNumber)
{
    int mlt = 1;
    for (int i = startNumber; i <= endNumber; i++)
    {
        mlt = mlt * i;
    }
    
    return mlt;
}

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Произведение чисел от 1 до {a} равна {GetMultiple(1, a)}");