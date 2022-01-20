using System;
using EpamClassLibrary;

namespace Task_2._1_OOP_okay_okay_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = MainMenu();
            while (true)
            {
                switch (menu)
                {
                    case "1":
                        {
                            var strMenu = StringMenu();
                            switch (strMenu)
                            {
                                case "1":
                                    {
                                        Console.WriteLine();
                                        strMenu = StringMenu();
                                        break;
                                    }
                                case "0":
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Неверный вариант!");
                                        Console.WriteLine();
                                        strMenu = StringMenu();
                                        break;
                                    }
                            }

                            Console.WriteLine();
                            menu = MainMenu();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine();
                            menu = MainMenu();
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
                            Console.WriteLine();
                            menu = MainMenu();
                            break;
                        }
                }
            }
        }

        static string MainMenu()
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine(" 1 - Работа со строками");
            Console.WriteLine(" 2 - Работа с фигурами");
            Console.WriteLine(" 0 - Выход");
            return Console.ReadLine();
        }

        static string StringMenu()
        {
            Console.WriteLine("Выберите действие со строками: ");
            Console.WriteLine(" 1 - Сравнение");
            Console.WriteLine(" 2 - Конкатенация");
            Console.WriteLine(" 3 - Поиск Символов");
            Console.WriteLine(" 4 - Конвертация массива символов");
            Console.WriteLine(" 5 - ");
            Console.WriteLine(" 6 - ");
            Console.WriteLine(" 0 - Назад");
            return Console.ReadLine();
        }

        static string FigureMenu()
        {
            return Console.ReadLine();
        }
    }
}
