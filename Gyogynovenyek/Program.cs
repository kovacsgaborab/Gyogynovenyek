using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Gyogynovenyek
{
    
    class Program
    {
        static List<Gyogynovenykek> Novenyek = new List<Gyogynovenykek>();

        static Dictionary<string, int> reszek = new Dictionary<string, int>();

        static void Beolvas()
        {
            StreamReader sr = new StreamReader("noveny.csv");

            while (!sr.EndOfStream)
            {
                Novenyek.Add(new Gyogynovenykek(sr.ReadLine()));
            }
        }

        static void Elso()
        {
            int a = Novenyek.Count;

            Console.WriteLine("A növények száma: {0}", a);
        }

        static void Masodik()
        {
            Console.WriteLine("\n2. Feladat: Gyűjthető részek: ");

            foreach (var n in Novenyek)
            {
                if (!reszek.ContainsKey(n.Resz))
                {
                    reszek.Add(n.Resz, 0);
                }
            }

            foreach (var n in Novenyek)
            {
                reszek[n.Resz]++;
            }

            foreach (var r in reszek)
            {
                Console.WriteLine($"{r.Key}: {r.Value}");
            }
        }

        static void Harmadik()
        {
            int max = 0;

            foreach (var n in Novenyek)
            {
                if (n.Idotartam > max)
                {
                    max = n.Idotartam;
                }
            }

            foreach (var n in Novenyek)
            {
                if (n.Idotartam==max)
                {
                    Console.WriteLine("\n{0} : {1}", n.Nev, max);
                }
            }

        }

        static void Negyedik()
        {
            double szum = 0;
            double atlag = 0;

            foreach (var n in Novenyek)
            {
                szum = szum + n.Idotartam;
            }

            atlag = szum / Novenyek.Count;

            Console.WriteLine("Az Időtartam átlaga: {0}", atlag);
        }

        static void Main(string[] args)
        {
            Beolvas();
            Elso();
            Masodik();
            Harmadik();
            Negyedik();

            /*foreach (var n in Novenyek)
            {
                Console.WriteLine($"{n.Nev} - {n.Resz} - {n.Kezd} - {n.Veg} - {n.Idotartam}");
            }*/

            Console.ReadLine();
        }

    }
}
