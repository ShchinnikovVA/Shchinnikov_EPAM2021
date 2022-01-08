using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._1._The_Magnificent_Ten
{
    public static class Rectangle
    {
        public static int Rect()
        {
            int a, b;

            do
            {
                a = Read_Int(" A ");
            }
            while (a <=0);

            do
            {
                b = Read_Int(" B ");
            }
            while (b <= 0);

            return a * b;
        }
        
        static int Read_Int(string name)
        {
            string reader;
            int num;
            do
            {
                Console.WriteLine("Введите длину стороны" + name + "треугольника");
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
