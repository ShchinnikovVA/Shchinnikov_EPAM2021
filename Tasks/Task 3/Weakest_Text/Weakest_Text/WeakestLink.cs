using System;
using System.Collections.Generic;
using System.Text;

namespace Weakest_Text
{
    public static class WeakestLink
    {
        public static void PeopleGame(int n, int dn)
        {
            int round = 0; // номер хода
            int every_n = 0; // счётчик каждого N-ного
            List<string> people = new List<string>();
            for (int i = 0; i < n; i++)
            {
                people.Add("man");
            }

            while (people.Count >= dn)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (every_n > dn) every_n = 0; // обнулить счётчик, если он вышел за нужное число
                    else every_n++;
                    if (i % dn == 0 || every_n == dn)
                    {
                        round++;
                        people.RemoveAt(i);
                        Console.WriteLine("Раунд {0}. Убит человек. Осталось {1}", round, people.Count);
                    }

                }
            }
        }
    }
}
