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
            do a = Program.Read_Int("Введите число, получите треугольник)))");
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
            do a = Program.Read_Int("Введите число, получите треугольник)))");
            while (a <= 0);

            List<string> str = Stars(a);
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(str[i]);
            }
        }

        public static void XMasTree() //не работает как надо
        {
            int a;
            do a = Program.Read_Int("Введите число, получите треугольник)))");
            while (a <= 0);

            for (int i = 1; i < a + 1; i++)
            {
                //if (i % 2 == 0)
                //{
                //    //a++;
                //    i += 2;
                //}
                List<string> str = Stars(i);
                for (int j = 0; j < i; j++)
                {
                    for (int q = 0; q < a - i; q++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(str[j]);
                }
            }
        }

        static List<string> Stars(int a) // должен возвращать массив строк
        {
            List<string> starStr = new List<string>();

            for (int i = 1; i < a + 1; i++)
            {
                List<char> starChar = new List<char>();
                if (i % 2 == 0)
                {
                    a++;
                    i++;
                }

                for (int q = 0; q < a - i; q++)
                {
                    starChar.Add(' ');
                }
                
                for (int j = 0; j < i; j++)
                {
                    starChar.Add('*');
                }
                string str = new string(starChar.ToArray());
                starStr.Add(str);
            }

            return starStr;
        }
        
    }
}
