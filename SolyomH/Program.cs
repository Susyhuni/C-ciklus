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

                            osszeg += jegy;
                            db++;

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

                        }
                        {
                            Console.Write("Adj meg egy számot (1–10): ");
                            int szor = int.Parse(Console.ReadLine());

                            if (szor < 1 || szor > 10)
                            {
                                Console.WriteLine("A számnak 1 és 10 között kell lennie.");
                                return;
                            }

                            Console.WriteLine($"{szor} szorzótáblája (csak a 3-mal osztható eredmények):");

                            for (int i = 1; i <= 10; i++)
                            {
                                int eredmeny = szor * i;
                                if (eredmeny % 3 == 0)
                                {
                                    Console.WriteLine($"{szor} x {i} = {eredmeny}");
                                }
                            }

                        }
                        Console.WriteLine("Adj meg 10 számot:");

                        for (int b = 1; b <= 10; b++)
                        {
                            Console.Write($"Szám {b}: ");
                            int szám = int.Parse(Console.ReadLine());

                            string jelleg = szám >= 0 ? "pozitív" : "negatív";

                            string parosParatlan = szám % 2 == 0 ? "páros" : "páratlan";

                            string oszt3 = szám % 3 == 0 ? "osztható 3-mal" : "nem osztható 3-mal";

                            Console.WriteLine($"{szám}: {jelleg}, {parosParatlan}, {oszt3}");

                        }
                        string jelszo1, jelszo2;

                        do
                        {
                            Console.Write("Adj meg egy jelszót: ");
                            jelszo1 = Console.ReadLine();

                            Console.Write("Erősítsd meg a jelszót: ");
                            jelszo2 = Console.ReadLine();

                            if (jelszo1 != jelszo2)
                            {
                                Console.WriteLine("A jelszavak nem egyeznek. Próbáld újra.\n");
                            }

                        } while (jelszo1 != jelszo2);

                        Console.WriteLine("A jelszó megerősítve!");

                        Console.Write("Adj meg egy tetszőleges szöveget: ");
                        string szoveg = Console.ReadLine();

                        char[] tomb = szoveg.ToCharArray();
                        Array.Reverse(tomb);
                        string visszafele = new string(tomb);

                        Console.WriteLine("A megadott szöveg visszafelé:");
                        Console.WriteLine(visszafele);


                        Console.Write("Adj meg egy számot: ");
                        int n = int.Parse(Console.ReadLine());

                        int primSzamokSzama = 0;

                        for (int pam = 2; pam <= n; pam++)
                        {
                            bool prim = true;

                            for (int oszto = 2; oszto < pam; oszto++)
                            {
                                if (pam % oszto == 0)
                                {
                                    prim = false;
                                    break;
                                }
                            }

                            if (prim)
                                primSzamokSzama++;
                        }

                        Console.WriteLine($"1 és {n} között {primSzamokSzama} prímszám van.");

                        string[] valasztasok = { "kő", "papír", "olló" };
                        int felhasznaloPont = 0;
                        int gepPont = 0;
                        Random rnd = new Random();

                        Console.WriteLine("Kő-Papír-Olló játék (5 kör)");

                        for (int kor = 1; kor <= 5; kor++)
                        {
                            Console.WriteLine($"\n{kor}. kör:");

                            string felhasznaloValasztas;
                            while (true)
                            {
                                Console.Write("Válassz (kő, papír, olló): ");
                                felhasznaloValasztas = Console.ReadLine().ToLower();

                                if (Array.Exists(valasztasok, elem => elem == felhasznaloValasztas))
                                    break;
                                else
                                    Console.WriteLine("Érvénytelen választás, próbáld újra!");
                            }

                            string gepValasztas = valasztasok[rnd.Next(0, 3)];
                            Console.WriteLine($"A gép választása: {gepValasztas}");

                            if (felhasznaloValasztas == gepValasztas)
                            {
                                Console.WriteLine("Döntetlen!");
                            }
                            else if (
                                (felhasznaloValasztas == "kő" && gepValasztas == "olló") ||
                                (felhasznaloValasztas == "papír" && gepValasztas == "kő") ||
                                (felhasznaloValasztas == "olló" && gepValasztas == "papír")
                            )
                            {
                                Console.WriteLine("Te nyertél ezt a kört!");
                                felhasznaloPont++;
                            }
                            else
                            {
                                Console.WriteLine("A gép nyert ezt a kört!");
                                gepPont++;
                            }
                        }

                        Console.WriteLine("\nJáték vége!");

                        Console.WriteLine($"Te nyertél: {felhasznaloPont} kör");
                        Console.WriteLine($"A gép nyert: {gepPont} kör");

                        if (felhasznaloPont > gepPont)
                            Console.WriteLine("Gratulálok, te nyertél!");
                        else if (gepPont > felhasznaloPont)
                            Console.WriteLine("Sajnos a gép nyert!");
                        else
                            Console.WriteLine("Döntetlen lett!");

                        Console.WriteLine("\nNyomj meg egy gombot a kilépéshez...");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}

