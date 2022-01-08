using System;

namespace Task_1._1._The_Magnificent_Ten
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
                            Console.WriteLine("Площадь треугольника равна " + Rectangle.Rect());
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "2":
                        {
                            Triangle.Tria();
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "3":
                        {
                            break;
                        }
                    case "4":
                        {
                            break;
                        }
                    case "5":
                        {
                            break;
                        }
                    case "6":
                        {
                            break;
                        }
                    case "7":
                        {
                            break;
                        }
                    case "8":
                        {
                            break;
                        }
                    case "9":
                        {
                            break;
                        }
                    case "10":
                        {
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
                            break;
                        }
                        
                        
                }
            }
        }
        static string GetMenuStart()
        {
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine(" 1 - Rectangle");
            Console.WriteLine(" 2 - Triangle");
            Console.WriteLine(" 3 - Another triangle");
            Console.WriteLine(" 4 - X-mas tree");
            Console.WriteLine(" 5 - Sum of number");
            Console.WriteLine(" 6 - Font adjustment");
            Console.WriteLine(" 7 - Array processing");
            Console.WriteLine(" 8 - No positive");
            Console.WriteLine(" 9 - Non-negative sum");
            Console.WriteLine(" 10 - 2D anime array");
            Console.WriteLine(" 0 - Выход");

            return Console.ReadLine();
        }

        //static int Rectangle()
        //{
        //    string reader;
        //    int a, b;
        //    //проблемы с вводом строки вместо числа
        //    do
        //    {
        //        Console.WriteLine("Введите длину стороны A треугольника");
        //        reader = Console.ReadLine();
        //        if (Convert.ToInt32(reader) <= 0)
        //        {
        //            do
        //            {
        //                Console.WriteLine("Значение должно быть больше нуля!");
        //                reader = Console.ReadLine();
        //            }
        //            while (Convert.ToInt32(reader) <= 0);
        //        }

        //    }
        //    while (!int.TryParse(reader, out a));
        //    do
        //    {
        //        Console.WriteLine("Введите длину стороны B треугольника");
        //        reader = Console.ReadLine();
        //        if (Convert.ToInt32(reader) <= 0)
        //        {
        //            do
        //            {
        //                Console.WriteLine("Значение должно быть больше нуля!");
        //                reader = Console.ReadLine();
        //            }
        //            while (Convert.ToInt32(reader) <= 0);
        //        }
        //    }
        //    while (!int.TryParse(reader, out b));
        //    return a * b;
        //}
    }
}
