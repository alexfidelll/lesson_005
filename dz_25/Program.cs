// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Pow(int firstValue, int secondValue)
{
     int result = firstValue;

    for (int i = 1; i < secondValue; i++)
    {
        result *= firstValue;
    }

     return result;
}

Console.WriteLine(Pow(3, 5));
