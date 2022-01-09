using System;

namespace Task_1._2_String_not_Sting
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
                            WordsMethods.Averages();
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "2":
                        {
                            WordsMethods.Doubler();
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "3":
                        {
                            WordsMethods.LowerCase();
                            Console.WriteLine(" ");
                            menu = GetMenuStart();
                            break;
                        }
                    case "4":
                        {
                            WordsMethods.Validator();
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
            Console.WriteLine(" 1 - Averages");
            Console.WriteLine(" 2 - Doubler");
            Console.WriteLine(" 3 - Lowercase");
            Console.WriteLine(" 4 - Validator");
            Console.WriteLine(" 0 - Выход");

            return Console.ReadLine();
        }
    }
}
