using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._1._The_Magnificent_Ten
{
    class Triangle
    {
        public static void Tria() //task 1.1.2
        {
            int a;
            do  a = Read_Int();
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

        public static void AnotherTria() //task 1.1.3
        {
            int a;
            do a = Read_Int();
            while (a <= 0);

            Stars(a, false, a);
        }

        public static void XMasTree() //не работает как надо
        {
            int a;
            do a = Read_Int();
            while (a <= 0);

            for (int i = 1; i < a + 1; i++)
            {
                Stars(i, true, a);
            }
        }

        static void Stars(int a, bool spaces, int max)
        {
            for (int i = 1; i < a + 1; i++)
            {
                if (i % 2 == 0)
                {
                    a++;
                    i++;
                }

                //if (spaces) // проблемы с выставлением пробелов
                //{
                //    for (int r = i; r > 0; r--)
                //    {
                //        Console.Write(" ");

                //    }
                //}

                for (int q = 0; q < a - i; q++)
                {
                    Console.Write(" ");
                }
                

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
