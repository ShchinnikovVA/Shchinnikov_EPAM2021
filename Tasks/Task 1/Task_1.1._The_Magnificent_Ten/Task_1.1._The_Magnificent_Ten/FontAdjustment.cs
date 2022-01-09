using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._1._The_Magnificent_Ten
{
    class FontAdjustment
    {
        public static void Font()
        {
            bool[] fonts = { false, false, false }; 
            //fonts[0] bold;
            //fonts[1] italic;
            //fonts[2] underline;

            string menu = FontMenu();

            while (true)
            {
                switch (menu)
                {
                    case "0":
                        {
                            if (fonts[0]) fonts[0] = false;
                            else fonts[0] = true;

                            Console.WriteLine(FontActiveParam(fonts));
                            menu = FontMenu();
                            break;
                        }
                    case "1":
                        {
                            if (fonts[1])  fonts[1] = false; 
                            else fonts[1] = true;
                            
                            Console.WriteLine(FontActiveParam(fonts));
                            menu = FontMenu();
                            break;
                        }
                    case "2":
                        {
                            if (fonts[2]) fonts[2] = false; 
                            else fonts[2] = true;

                            Console.WriteLine(FontActiveParam(fonts));
                            menu = FontMenu();
                            break;
                        }
                    case "3":
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
            Console.WriteLine("     0: bold");
            Console.WriteLine("     1: italic");
            Console.WriteLine("     2: underline");
            Console.WriteLine("     3: back to main menu");
            return Console.ReadLine();
        }

        static string FontActiveParam(bool[] fonts)
        {
            string b = "bold";
            string i = "italic";
            string u = "underline";
            string ch = "; ";

            string formats = "";

            if (fonts[0]) formats += b + ch;
            if (fonts[1]) formats += i + ch;
            if (fonts[2]) formats += u + ch;

            if (formats == "") formats = "none";
            return formats;
        }
    }
}
