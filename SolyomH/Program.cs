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

                {
                    int parosDb = 0;
                    int paratDb = 0;

                    Console.WriteLine("Adj meg 10 számot:");

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($"Szám {i}: ");
                        int szam3 = int.Parse(Console.ReadLine());

                        if (szam3 % 2 == 0)
                            parosDb++;
                        else
                            paratDb++;
                    }

                    Console.WriteLine($"Páros számok száma: {parosDb}");
                    Console.WriteLine($"Páratlan számok száma: {paratDb}");
                    Console.WriteLine("Nyomj meg egy gombot a kilépéshez...");
                    Console.ReadKey();

                }
            }
        }
    }
}

