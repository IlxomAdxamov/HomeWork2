// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        // Задайте значения M и N
        int M = 1;
        int N = 10;

        // Вызов функции для вывода чисел в заданном промежутке
        PrintNumbersInRange(M, N);
    }

    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbersInRange(m + 1, n);
        }
    }
}
