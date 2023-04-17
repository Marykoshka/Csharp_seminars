// адача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

//Получить сумму положительных элементов:
int GetSumPositiveElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] > 0)
         {
            sum += array[i];
         }
    }

    return sum;
}

//Получить сумму отрицательных элементов:
int GetSumNegativeElements(int[] array)
{
    int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                sum += array[i];
            }
        }

    return sum;
}

//Вывод массива в консоль
void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}

//----------------------------------------------
int[] myArray = new int[12]; 
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(-9, 10);
}
PrintArrayToConsole(myArray);

int sumPosElements = GetSumPositiveElements(myArray);
int sumNegElements = GetSumNegativeElements(myArray);

Console.WriteLine($"Сумма положительных элементов: {sumPosElements}, сумма отрицательны элементов: {sumNegElements}");

