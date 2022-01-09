using System;

namespace Task_1._1._The_Magnificent_Ten
{
    class Program
    {
        
        public static void Main(string[] args)
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
                            Triangle.AnotherTria();
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "4":
                        {
                            Triangle.XMasTree();
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine(SumOfNumbers.Sum());
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "6":
                        {
                            FontAdjustment.Font();
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("Есть массив случайных чисел.");
                            Console.WriteLine(" Искать MAX - 1; Искать MIN - 2");
                            Console.WriteLine("Введите любое другое значение для выхода");
                            var str = Console.ReadLine();
                            switch (str)
                            {
                                case "1":
                                    {
                                        SumOfNumbers.MaxMinArray(true);
                                        break;
                                    }
                                case "2":
                                    {
                                        SumOfNumbers.MaxMinArray(false);
                                        break;
                                    }
                                default: break;
                            }

                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "8":
                        {
                            
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "9":
                        {
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "10":
                        {
                            Console.WriteLine(" ");
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

        public static int Read_Int(string message)
        {
            string reader;
            int num;
            do
            {
                Console.WriteLine(message);
                reader = Console.ReadLine();
            }
            while (!int.TryParse(reader, out num));

            if (num <= 0)
            {
                Console.WriteLine("Значение не должно быть меньше или равно нулю!");
                return 0;

            }
            else return num;

        }
    }
}
