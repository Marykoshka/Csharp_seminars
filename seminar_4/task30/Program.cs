// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// int [] arr = new int[10];

// void FillArray (int [] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// void PrintArray(int [] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         if (position == count - 1)
//         {
//             Console.Write(col[position]);
//             break;
//         }
//         Console.Write($"{col[position]}, ");
//         position++;
//     }
// }

// FillArray(arr);
// PrintArray(arr);

//Бинарный поиск по отсортированному массиву

int getPositionArray(int num, int[] nums)
{
    int pos1 = 0;
    int pos2 = nums.Length-1;
    while (pos1 != pos2)
    {
        int midPos = (pos1 + pos2)/2;
        if (nums[midPos] == num)
        {
            return midPos;
        }
        if(nums[midPos] < num)
        {
            pos1 = midPos;
        }
        else
        {
            pos2 = midPos;
        }
    }

    return -1;
}

int[] nums = new int[8] {1,3,4,5,6,8,9,10};
Array.Sort(nums);
Console.Write("Введите число :");
int num = int.Parse(Console.ReadLine());
int position = getPositionArray(num, nums);
Console.WriteLine(position+1);