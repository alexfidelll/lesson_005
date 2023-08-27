// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] AddArray(int[] array)
{
    int[] myArray = new int[8];

    Random random = new Random();

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = random.Next(10);
    }

    return myArray;

}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] array = new int[2];
array  = AddArray(array);
Print(array);
