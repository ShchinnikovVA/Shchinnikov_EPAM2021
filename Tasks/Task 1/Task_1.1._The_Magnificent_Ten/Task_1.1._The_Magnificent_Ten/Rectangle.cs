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
                a = Program.Read_Int("Введите длину стороны A треугольника");
            }
            while (a <=0);

            do
            {
                b = Program.Read_Int("Введите длину стороны B треугольника");
            }
            while (b <= 0);

            return a * b;
        }
        
    }
}
