using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2._1_OOP_okay_okay_Programming
{
    class StringForThisTask
    {
        public static void GoFindChar(string str1, string str2)
        {
            char[] ch1 = str1.ToCharArray(); // Создаём 2 массива символов
            char[] ch2 = str2.ToCharArray();

            for (int i = 0; i < ch2.Length; i++)
            {
                int amount = 0;
                for (int j = 0; j < ch1.Length; j++)
                {
                    if (ch2[i] == ch1[j])
                    {
                        amount++;
                    }
                }
                if (amount > 0)
                    Console.WriteLine("Количество символов '{0}': {1}", ch2[i], amount);
                else
                    Console.WriteLine("Символа '{0}' не найдено!", ch2[i]);

            }
        }

        public static string ThatSaidVladimir()
        {
            Console.WriteLine("Это почти как мой говорящий Томас");
            Console.WriteLine("Введите предложение, которое скажет Владимир:");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            str.Append(" - Сказал Владимир.");
            return str.ToString();

        }
    }
}
