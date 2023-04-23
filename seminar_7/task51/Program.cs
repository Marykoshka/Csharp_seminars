// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Введите m: ");
// int m = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите n: ");
// int n = int.Parse(Console.ReadLine());

// int[,] arrayInt = new int[m, n];

// for (int i = 0; i < arrayInt.GetLength(0); i++)
// {
//     for (int j = 0; j < arrayInt.GetLength(1); j++)
//     {
//         arrayInt[i, j] = new Random().Next(1, 11);
//         Console.Write(arrayInt[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// void PrintArray(int[,] pArray)
// {
//     for (int i = 0; i < pArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < pArray.GetLength(1); j++)
//         {
//             Console.Write(pArray[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine();

// //Находим сумму элементов на главной диагонали
// int GetSum(int[,] pArray)
// {
//     int sum = 0;
//     for (int i = 0; i < arrayInt.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayInt.GetLength(1); j++)
//         {
//             if (i == j) sum = sum + arrayInt[i, j];
//         }
//     }
//     return sum;
// }

// Console.WriteLine($"Сумма элементов на главной диагонали равна {GetSum(arrayInt)}");


// Задача с Литкода:

void GetTwoSums(int[] array, int target)
{
    for (int i = 0; i <  array.Length; i++)
    {
        for (int j = i + 1; j <  array.Length; j++)
        {
            if (target == array[i] + array[j])
            {
                Console.WriteLine($"[{i}, {j}]");
                break;
            }
        }
    }
}

int[] array = new int[] {9, 7, 2, 15};
int target = 9;
GetTwoSums(array, target);