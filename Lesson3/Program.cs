// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        // Произвольный массив
        int[] myArray = { 1, 2, 3, 4, 5 };

        // Вызов функции для вывода элементов массива с конца
        PrintArrayReversed(myArray, myArray.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReversed(array, index - 1);
        }
    }
}
