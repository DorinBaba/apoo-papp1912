using System;
using System.Collections.Generic;

namespace ListeGenerice
{
    class Elev
    {
        public string Nume { get; set; }
        public double Media { get; set; }

        public Elev(string nume, double media)
        {
            Nume = nume;
            Media = media;
        }

        public override string ToString()
        {
            return $"{Nume}, {Media}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Lista generica de tip elev:
            List<Elev> elevi = new List<Elev>();

            elevi.Add(new Elev("Lil", 3.52));
            elevi.Add(new Elev("Lil", 3.52));
            elevi.Add(new Elev("Lil", 3.52));
            elevi.Add(new Elev("Lil", 3.52));
            elevi.Add(new Elev("Lil", 3.52));

            foreach (var item in elevi)
            {
                Console.WriteLine(item.Nume);
            }
        }
    }
}
