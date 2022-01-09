using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2_String_not_Sting
{
    class Averages
    {
        public static void AverageNumber()
        {
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();
            char[] separators = new char[] { ' ', ',' , '.', '?', '!' };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int i = 0;
            int sum = 0;

            foreach (string word in words)
            {
                sum += word.Length;
                i++;
            }

            Console.WriteLine("Среднее число букв в словах: " + sum/words.Length); // Округляется вниз до целого
        }

        
    }
}
