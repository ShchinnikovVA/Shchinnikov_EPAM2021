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

    }
}
