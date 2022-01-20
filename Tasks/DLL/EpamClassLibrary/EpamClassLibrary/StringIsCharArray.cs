using System;
using System.Text;

namespace EpamClassLibrary
{
    public static class StringIsCharArray
    {
        public static bool Comparison(string str1, string str2) // Принимает 2 строки
        {
            bool equability = true; // Изначально булевая тру
            
            char[] ch1 = str1.ToCharArray(); // Создаём 2 массива символов
            char[] ch2 = str2.ToCharArray();
            int i = 0;

            while (i < ch1.Length)
            {
                if (ch1[i] == ch2[i]) i++; // Сравниваем символы в массивах
                else
                {
                    equability = false; // Если не равны то меняем булевую 
                    break;
                }
            }

            return equability;
        }

        public static string Concatenation(string str1, string str2)
        {
            StringBuilder sb = new StringBuilder(str1); // создаём стрингбилдет с первй строкой
            sb.Append(str2); // добавляем вторую
            return sb.ToString();
        }
    }
}
