using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolyomH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja megy az első számot");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja megy a második számot");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine($"A {x} nagyobb mint {y}, {x - y - 1}");

            }
            else if (y > x)
            {
                Console.WriteLine($"A {y} nagyobb mint {x}, {y - x - 1}");

            }
            else
            { Console.WriteLine("Nem jó adatot adott meg"); }

            {
                int szam = 1;

                List<int> list = new List<int>();
                while (szam != 0)

                {
                    Console.WriteLine($"Adjon meg számot(0)");
                    szam = int.Parse(Console.ReadLine());
                    list.Add(szam);
                }
                var csoportok = (from i in list
                                group i by i into grp
                                orderby grp.Count() descending
                                select grp.Key).First();
                Console.WriteLine($"legtöbször megadott szám a {csoportok}");
                Console.WriteLine($"alma");
                Console.ReadLine();
            }
        }
    }
}

