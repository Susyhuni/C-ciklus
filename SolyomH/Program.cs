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

                    {
                        string szo = "";
                        int hosszabbSzavakSzama = 0;

                        Console.WriteLine("Írj be szavakat! Ha beírod azt, hogy 'vége', a program leáll.");

                        while (szo != "vége")
                        {
                            Console.Write("Add meg a szót: ");
                            szo = Console.ReadLine();

                            if (szo == "vége")
                            {
                                break;
                            }

                            if (szo.Length > 5)
                            {
                                hosszabbSzavakSzama++;
                            }
                        }

                        Console.WriteLine($"Összesen {hosszabbSzavakSzama} darab 5 karakternél hosszabb szót adtál meg.");


                        int jegy = 0;
                        int osszeg = 0;
                        int db = 0;

                        int egyes = 0;
                        int kettes = 0;
                        int harmas = 0;
                        int negyes = 0;
                        int otos = 0;

                        Console.WriteLine("Adj meg osztályzatokat (1–5). Kilépéshez írd be: -1");

                        while (true)
                        {
                            Console.Write("Osztályzat: ");
                            bool jo = int.TryParse(Console.ReadLine(), out jegy);

                            if (!jo)
                            {
                                Console.WriteLine("Érvénytelen szám, próbáld újra!");
                                continue;
                            }

                            if (jegy == -1)
                                break;

                            if (jegy < 1 || jegy > 5)
                            {
                                Console.WriteLine("Csak 1 és 5 közötti számokat adj meg!");
                                continue;
                            }

                            // Összeg és darabszám az átlaghoz
                            osszeg += jegy;
                            db++;

                            // Jegyek számlálása
                            switch (jegy)
                            {
                                case 1: egyes++; break;
                                case 2: kettes++; break;
                                case 3: harmas++; break;
                                case 4: negyes++; break;
                                case 5: otos++; break;
                            }
                        }

                        if (db == 0)
                        {
                            Console.WriteLine("Nem adtál meg jegyet.");
                        }
                        else
                        {
                            double atlag = (double)osszeg / db;
                            Console.WriteLine($"\nÁtlag: {atlag:F2}");
                            Console.WriteLine($"1-esek száma: {egyes}");
                            Console.WriteLine($"2-esek száma: {kettes}");
                            Console.WriteLine($"3-asok száma: {harmas}");
                            Console.WriteLine($"4-esek száma: {negyes}");
                            Console.WriteLine($"5-ösök száma: {otos}");
                            Console.WriteLine("Nyomj meg egy gombot a kilépéshez...");
                            Console.ReadKey();
                        }

                    }
                }
            }
        }
    }
}

