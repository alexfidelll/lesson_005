// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number)
{
    bool real = true;

    int result = 0;

    if (number < 0)
    {
        number = -number;
    }
    while (real)
    {
        if (number > 9)
        {
            result += number % 10;
            number = number / 10;
        }
        else if (number < 10)
        {
            result += number;
            real = false;
        }
    }
    return result;
}

Console.WriteLine(Sum(452));