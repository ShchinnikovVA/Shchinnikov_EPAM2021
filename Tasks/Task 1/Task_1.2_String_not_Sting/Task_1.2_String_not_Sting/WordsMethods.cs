using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2_String_not_Sting
{
    class WordsMethods
    {
        public static void Averages()
        {
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();
            char[] separators = new char[] { ' ', ',' , '.', '?', '!' };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            foreach (string word in words)
            {
                sum += word.Length;
            }

            Console.WriteLine("Среднее число букв в словах: " + sum/words.Length); // Округляется вниз до целого
        }

        public static void Doubler()
        {
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();
            Console.WriteLine("Введите символы, которые будут удваиваться");
            string str2 = Console.ReadLine();

            char[] chars = str.ToCharArray();
            char[] chars2 = str2.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars2.Length; j++)
                {
                    if (chars[i] == chars2[j])
                    {
                        InsertChar(ref chars, chars[i], i);
                        i++;
                        break;
                    }
                }
            }

            string finStr = new string(chars);
            Console.WriteLine(finStr);
        }

        static void InsertChar (ref char[] chars, char ch, int index)
        {
            char[] newArray = new char[chars.Length + 1];
            newArray[index] = ch;

            for (int i = 0; i < index; i++) newArray[i] = chars[i];
            for (int i =index; i < chars.Length; i++) newArray[i + 1] = chars[i];

            chars = newArray;
        }

        public static void LowerCase()
        {
            int n = 0;
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();

            char[] separators = new char[] { ' ', ',', '.', '?', '!' };
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (Char.IsLower(word, 0)) n++;
            }

            Console.WriteLine("Количество слов с маленькой буквы: " + n);
        }

        public static void Validator()
        {
            Console.WriteLine("Введите предложение: ");
            string str = Console.ReadLine();

            char[] separators = new char[] {' '};
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            str = "";
            int i = 0;
            foreach (string word in words)
            {
                char[] charWord = word.ToCharArray();

                

                if (i == 0)
                {
                    
                    if (Char.IsLower(charWord[0])) charWord[0] = Char.ToUpper(charWord[0]);
                    string thisWord = new string(charWord);
                    str = str + thisWord + " ";
                    i++;
                    
                }
                else
                {
                    str = str + word + " ";
                }
                if (charWord[^1] == '.' || charWord[^1] == '!' || charWord[^1] == '?') i = 0;


            }

            Console.WriteLine(str);
        }
    }
}
