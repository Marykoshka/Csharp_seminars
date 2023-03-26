// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(string word)
{
    var array = word.ToArray();
    var reverseArray = array.Reverse().ToArray();
    string reverseWord = new string (reverseArray);

    if (word == reverseWord)
    {
        Console.WriteLine($"{word} является палиндромом {reverseWord}");
    }
    else
    {
        Console.WriteLine($"{word} не является палиндромом {reverseWord}");
    }
}

Console.Write("Проверка на палиндромность. Введите пятизначное число: ");
int digit = int.Parse(Console.ReadLine());
string str = digit.ToString()!;

Palindrom(str);


// МЕТОД ИЗ ГУГЛА БУЛЕВЫ ЗНАЧЕНИЯ TRUE/FALSE 
// static bool IsPalindrom(string word, bool ignoreCase = true)
// {
//     var inputArray = word.ToArray();
//     var reversedArray = inputArray.Reverse().ToArray();

//     return inputArray.SequenceEqual(reversedArray);
// }

// Console.WriteLine("Проверка на палиндромность. Введите пятизначное число: ");
// int digit = int.Parse(Console.ReadLine());
// string str = digit.ToString()!;

// bool res = IsPalindrom(str);
// Console.WriteLine(res);