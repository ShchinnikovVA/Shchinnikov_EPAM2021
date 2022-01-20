using System;

namespace EpamClassLibrary
{
    public static class StringIsCharArray
    {
        public static bool Comparison(string str1, string str2)
        {
            bool equability = true;
            
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            int i = 0;

            while (i < ch1.Length)
            {
                if (ch1[i] == ch2[i]) i++;
                else
                {
                    equability = false;
                    break;
                }
            }

            return equability;
        }
    }
}
