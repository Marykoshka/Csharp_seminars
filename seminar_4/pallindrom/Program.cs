// See https://aka.ms/new-console-template for more information

bool IsPalindrome(int number)
{
    int revNumber = 0;
    int sourceNumber = number;

    while (sourceNumber!= 0)
    {
        int pop = sourceNumber % 10;
        sourceNumber = sourceNumber / 10;

        //Формируем число, обратное от исходного:
        revNumber = (revNumber * 10) + pop;
    }
    bool isResult = revNumber == number;
    return isResult;
}

bool result = IsPalindrome(1234391); 
Console.WriteLine(result);