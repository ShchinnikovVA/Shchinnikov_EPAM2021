using System;
using System.Collections.Generic;
using System.Text;

namespace EpamClassLibrary
{
    public static class Numbers
    {
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
