using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._1._The_Magnificent_Ten
{
    class Triangle
    {
        public static void Tria()
        {
            int a;

            do
            {
                a = Read_Int();
            }
            while (a <= 0);

            for (int i = 1; i < a+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine(" ");
            }
        }
        static int Read_Int()
        {
            string reader;
            int num;
            do
            {
                Console.WriteLine("Введите число, получите треугольник)))");
                reader = Console.ReadLine();
            }
            while (!int.TryParse(reader, out num));

            if (num <= 0)
            {
                Console.WriteLine("Значение не должно быть меньше или равно нулю!");
                return 0;

            }
            else return num;

        }
    }
}
