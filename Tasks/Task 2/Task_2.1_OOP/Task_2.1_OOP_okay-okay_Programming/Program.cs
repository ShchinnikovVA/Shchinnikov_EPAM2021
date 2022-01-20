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
                    case "1": // Работа со строками
                        {
                            var strMenu = StringMenu();
                            switch (strMenu)
                            {
                                case "1": // Сравнение
                                    {
                                        Console.WriteLine("Введите первую строку");
                                        string str1 = Console.ReadLine();
                                        Console.WriteLine("Введите строку для сравнение");
                                        string str2 = Console.ReadLine();

                                        if (StringIsCharArray.Comparison(str1, str2))
                                            Console.WriteLine("Строки равны!");
                                        else
                                            Console.WriteLine("Строки не равны!");

                                        break;
                                    }
                                case "2": // Конкатенация
                                    {
                                        Console.WriteLine("Введите первую строку");
                                        string str1 = Console.ReadLine();
                                        Console.WriteLine("Введите вторую строку");
                                        string str2 = Console.ReadLine();
                                        Console.WriteLine("Результат: ");
                                        Console.WriteLine(StringIsCharArray.Concatenation(str1, str2));
                                        break;
                                    }
                                case "3": //  Поиск символов
                                    {
                                        break;
                                    }
                                case "4": // Конвертация массива символов
                                    {
                                        break;
                                    }
                                case "5": //
                                    {
                                        break;
                                    }
                                case "6": //
                                    {
                                        break;
                                    }
                                case "0": // Назад
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
                    case "2": // Работа с фигурами
                        {
                            var figMenu = FigureMenu();
                            switch (figMenu)
                            {
                                case "1": // Добавить фигуру
                                    {
                                        Console.WriteLine();
                                        figMenu = FigureMenu();
                                        break;
                                    }
                                case "2": // Показать все фигуры
                                    {
                                        Console.WriteLine();
                                        figMenu = FigureMenu();
                                        break;
                                    }
                                case "3": // Удалить все фигуры
                                    {
                                        Console.WriteLine();
                                        figMenu = FigureMenu();
                                        break;
                                    }
                                case "0": // Назад
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Неверный вариант!");
                                        Console.WriteLine();
                                        figMenu = FigureMenu();
                                        break;
                                    }
                            }

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
            Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine("Выберите действие с фигурами: ");
            Console.WriteLine(" 1 - Добавить фигуру");
            Console.WriteLine(" 2 - Показать все фигуры");
            Console.WriteLine(" 3 - Удалить все фигуры");
            Console.WriteLine(" 0 - Назад");
            return Console.ReadLine();
        }
    }
}
