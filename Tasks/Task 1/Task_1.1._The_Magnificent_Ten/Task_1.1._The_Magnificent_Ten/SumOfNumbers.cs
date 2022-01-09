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
            Random r = new Random();
            int n = Program.Read_Int("Введите число элементов массива");
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1000);
            }

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

            Console.WriteLine(" ");
            if (max) Console.WriteLine("Максимальное значение массива = " + count);
            else Console.WriteLine("Минимальное значение массива = " + count);


        }

    }
}
