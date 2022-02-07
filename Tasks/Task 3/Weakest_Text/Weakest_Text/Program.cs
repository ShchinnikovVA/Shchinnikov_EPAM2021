using System;
using System.Collections.Generic;
using EpamClassLibrary;

namespace Weakest_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = GetMenuStart();
            while (true)
            {
                switch (menu)
                {
                    case "1":
                        {
                            int n = Numbers.Read_Int("Введите N");
                            int dead_n = Numbers.Read_Int("Введите число, по счёту которого будут убивать людей");
                            WeakestLink.PeopleGame(n, dead_n);
                            Console.WriteLine();
                            menu = GetMenuStart();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите текст на английском, который мы будем проверять на повтор слов");
                            TextAnalysis.Journalist();
                            Console.WriteLine();
                            menu = GetMenuStart();
                            break;
                        }
                    case "0":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неверный вариант!");
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                }
                
            }
        }
        public static string GetMenuStart()
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine(" 1 - Убить человека в кругу");
            Console.WriteLine(" 2 - Редактор журнала");
            Console.WriteLine(" 0 - Выход");

            return Console.ReadLine();
        }

    }
}
