using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._1._The_Magnificent_Ten
{
    class SumOfNumbers
    {
        public static int Sum()
        {
            int a = Program.Read_Int("Введите целое число (например 1000)");
            int sum = 0;
            for (int i = 0; i< a; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static void MaxMinArray(bool max)
        {
            int[] arr = CreateOneDimensionalArray();
            int count = arr[0];

            Console.WriteLine("Представлен массив случайных чисел:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i] );
                if (max)
                {
                    if (count < arr[i]) count = arr[i];
                }
                else
                {
                    if (count > arr[i]) count = arr[i];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.Write("Отсортированный массив: ");
            Console.WriteLine(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }

            Console.WriteLine(" ");
            if (max) Console.WriteLine("Максимальное значение массива = " + count);
            else Console.WriteLine("Минимальное значение массива = " + count);
        }

        static int[] CreateOneDimensionalArray()
        {
            Random r = new Random();
            int n = Program.Read_Int("Введите количество элементов массива");
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-100, 100);
            }
            return arr;
        }

        public static void ThreeDimensionalArray()
        {
            Random r = new Random();
            Console.WriteLine("Настройте размер трёхмерного массива: ");
            int x = Program.Read_Int("Введите значение длины массива");
            int y = Program.Read_Int("Введите значение ширины массива");
            int z = Program.Read_Int("Введите значение высоты массива");
            int[,,] arr = new int[x, y, z];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int q = 0; q < z; q++)
                    {
                        arr[i,j,q] = r.Next(-100, 100);
                    }
                }
            }

            Array3D_toConsole(arr);
            Console.WriteLine("Обнулить все положительные числа?");
            Console.WriteLine("y - Выполнить; Любая другая клавиша для выхода");
            string str = Console.ReadLine();
            if (str == "y")
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        for (int q = 0; q < z; q++)
                        {
                            if(arr[i,j,q] > 0) arr[i, j, q] = 0;
                        }
                    }
                }
                Array3D_toConsole(arr);
            }
            

        }

        static void Array3D_toConsole(int[,,] arr)
        {
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("Лист №" + (i + 1));
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int q = 0; q < arr.GetLength(2); q++)
                    {
                        Console.Write("[{0}] ", arr[i, j, q]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine("========");
            }
        }
       
        public static void NonNegativeSum()
        {
            int[] arr = CreateOneDimensionalArray();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
                if (arr[i] > 0) sum += arr[i];
            }

            Console.WriteLine("Сумма положительных чисел массива равна: " + sum);
        }

        public static void AnimeArray()
        {
            Random r = new Random();
            Console.WriteLine("Настройте размер Двумерного массива: ");
            int x = Program.Read_Int("Введите значение длины массива");
            int y = Program.Read_Int("Введите значение ширины массива");
            int[,] arr = new int[x, y];
            int sum = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = r.Next(-100, 100);
                    if ((i + j) % 2 == 0) sum += arr[i, j];
                }
            }

            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("[{0}] ", arr[i, j]);
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Сумма всех элементов, стоящих на чётных позициях равна: " + sum);
        }

    }
}
