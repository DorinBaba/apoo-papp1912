using System;

namespace Exemplul3
{
    class Fractie
    {
        public int Numarator { get; set; }
        public int Numitor { get; set; }

        public static Fractie operator +(Fractie f1, Fractie f2)
        {
            Fractie rezultat = new Fractie();
            rezultat.Numarator = f1.Numarator * f2.Numitor + f2.Numarator * f1.Numitor;
            rezultat.Numitor = f1.Numitor * f2.Numitor;

            return rezultat;
        }

        public static Fractie operator -(Fractie f1, Fractie f2)
        {
            Fractie rezultat = new Fractie();
            rezultat.Numarator = f1.Numarator * f2.Numitor - f2.Numarator * f1.Numitor;
            rezultat.Numitor = f1.Numitor * f2.Numitor;

            return rezultat;
        }

        public static Fractie operator *(Fractie f1, Fractie f2)
        {
            Fractie rezultat = new Fractie();
            rezultat.Numarator = f1.Numarator * f2.Numarator;
            rezultat.Numitor = f1.Numitor * f2.Numitor;

            return rezultat;
        }

        public static Fractie operator /(Fractie f1, Fractie f2)
        {
            return f1 * (new Fractie { Numarator = f2.Numitor, Numitor = f2.Numarator });
        }

        public static Fractie operator ++(Fractie f1)
        {
            return new Fractie
            {
                Numarator = f1.Numarator + f1.Numitor,
                Numitor = f1.Numitor
            };
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Fractie fractie1 = new Fractie
            {
                Numarator = 2,
                Numitor = 3
            };

            Fractie fractie2 = new Fractie
            {
                Numarator = 7,
                Numitor = 9
            };


            Console.WriteLine("Adunare");
            Fractie rezultatAdunare = fractie1 + fractie2;
            Console.WriteLine(rezultatAdunare.Numarator + "/"+ rezultatAdunare.Numitor);
            
            Console.WriteLine("Scadere");
            Fractie rezultatScadere = fractie1 - fractie2;
            Console.WriteLine(rezultatScadere.Numarator + "/"+ rezultatScadere.Numitor);

            Console.WriteLine("Inmultire");
            Fractie rezultatInmultire = fractie1 * fractie2;
            Console.WriteLine(rezultatInmultire.Numarator + "/" + rezultatInmultire.Numitor);

            Console.WriteLine("Impartire");
            Fractie rezultatImpartire = fractie1 / fractie2;
            Console.WriteLine(rezultatImpartire.ToString());

            Console.WriteLine("Incrementare");
            Fractie rezultatIncrementare = ++ fractie1;
            Console.WriteLine(rezultatIncrementare.Numarator + "/" + rezultatIncrementare.Numitor);
        }
    }
}
