using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, n;
            Console.WriteLine("Введите размерность матрицы:");
            n = int.Parse(Console.ReadLine());
            int[] Matrix = new int[n];
            int[] Matrix1 = new int[n];
            int[] Matrix2 = new int[n];
            Console.WriteLine("Введите исходную матрицу:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Элемент [" + (i + 1) + "]: ");
                Matrix[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
                Console.Write(Matrix[i] + " ");
            Console.Write("\n");
            for (int i = 0; i < n; i++)
                if (Matrix[i] >= 0)
                {
                    Matrix1[a] = Matrix[i];
                    Matrix2[a] = i;
                    a++;
                }
            Console.WriteLine("Неотрицательные элементы:");
            for (int i = 0; i < a; i++)
                Console.Write(Matrix1[i] + " ");
            Console.Write("\n");
            Console.WriteLine("Индесы неотрицательных элементов:");
            for (int i = 0; i < a; i++)
                Console.Write(Matrix2[i] + " ");
            Console.ReadKey();
        }
    }
}