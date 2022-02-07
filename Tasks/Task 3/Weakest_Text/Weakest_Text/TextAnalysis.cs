using System;
using System.Collections.Generic;
using System.Text;

namespace Weakest_Text
{
    public static class TextAnalysis
    {
        public static void Journalist()
        {
            
            string str = Console.ReadLine();

            char[] separators = new char[] { ' ', ',', '.', '?', '!', ';', ':' }; // игнорируемые символы
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries); // массив слов без символов
            List<string> wordsList = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                char[] charWord = words[i].ToCharArray();
                if (Char.IsLower(charWord[0])) charWord[0] = Char.ToUpper(charWord[0]); 
                words[i] = new string(charWord); // каждое слово сделали с заглавной буквы
                wordsList.Add(words[i]);
            }
            wordsList.Sort();
            for (int i = 0; i < wordsList.Count; i++)
            {
                int num = 0;
                if (i+1 < wordsList.Count)
                {
                    while (wordsList[i] == wordsList[i + 1])
                    {
                        num++;
                        wordsList.RemoveAt(i + 1);
                    }
                }
                string end = "";
                if (num >= 5)  end = " --- слишком много!";
                Console.WriteLine(" {1} раз используется слово {0}{2}", wordsList[i], num +1, end);

            }
        }

    }
}
