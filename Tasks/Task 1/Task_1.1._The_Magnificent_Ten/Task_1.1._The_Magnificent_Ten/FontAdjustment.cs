using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._1._The_Magnificent_Ten
{
    class FontAdjustment
    {
        public static void Font()
        {
            bool bold = false;
            bool italic = false;
            bool underline = false;

            string menu = FontMenu();

            while (true)
            {
                switch (menu)
                {
                    case "1":
                        {
                            if (bold)
                            {
                                bold = false;
                                FontActiveParam(bold, 1);
                            }
                            else
                            {
                                bold = true;
                                FontActiveParam(bold, 1);
                            }
                                
                            Console.WriteLine(" ");
                            menu = FontMenu();
                            break;
                        }
                    case "2":
                        {
                            if (italic) italic = false;
                            else italic = true;
                            Console.WriteLine(" ");
                            menu = FontMenu();
                            break;
                        }
                    case "3":
                        {
                            if (underline) underline = false;
                            else underline = true;
                            Console.WriteLine(" ");
                            menu = FontMenu();
                            break;
                        }
                    case "4":
                        {
                            string[] args = { "" }; //привет костыльное программирование))))))
                            Console.WriteLine(" ");
                            Program.Main(args);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неверный вариант!");
                            Console.WriteLine(" ");
                            menu = FontMenu();
                            break;
                        }

                }
            }

        }

        static string FontMenu()
        {
            Console.WriteLine("Введите:");
            Console.WriteLine("     1: bold");
            Console.WriteLine("     2: italic");
            Console.WriteLine("     3: underline");
            Console.WriteLine("     4: back to main menu");
            return Console.ReadLine();
        }

        static string FontActiveParam(bool addFont, int numFontt)
        {
            string formats = "";
            string b = "bold";
            string i = "italic";
            string u = "underline";
            string ch = "; ";

            switch (numFontt)
            {
                case 1:
                    {
                        if (addFont)
                        {
                            return formats += b + ch;
                        }
                        else return formats -= b;
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }

            }

            if (formats == "") formats = "none";
            return formats;
        }
    }
}
