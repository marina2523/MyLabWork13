// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность матрицы: ");
        int n = int.Parse(Console.ReadLine());
        int p, q;
        do
        {
            Console.Write("Введите число p: ");
            p = int.Parse(Console.ReadLine());
            if (p > n)
            {
                Console.WriteLine("Такой строки нет, введите другой номер строки");
            }
        } while (p > n);
        do
        {
            Console.Write("Введите число q: ");
            q = int.Parse(Console.ReadLine());
            if (q > n)
            {
                Console.WriteLine("Такой строки нет, введите другой номер строки");
            }
        } while (q > n);
        int[,] mas = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("mas[{0},{1}]: ", i + 1, j + 1);
                mas[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int[] ints = new int[n];
        if (p > q)
        {
            for (int j = 0; j < n; j++)
            {
                ints[j] = mas[p - 1, j];
            }
            for (int j = 0; j < n; j++)
            {
                mas[p - 1, j] = mas[q - 1, j];
            }
            for (int j = 0; j < n; j++)
            {
                mas[q - 1, j] = ints[j];
            }
        }
        Console.WriteLine("\nМатрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j != n - 1)
                {
                    Console.Write("{0} ", mas[i, j]);
                }
                else
                {
                    Console.WriteLine("{0}", mas[i, j]);
                }
            }

        }
    }
}
