using System;

namespace Exemple
{
    class Program
    {
        private static double Varsta(DateTime dataNasterii)
        {
            return (double)((DateTime.Now - dataNasterii).Days / 365);
        }

        private static double Varsta(string dataNasterii)
        {
            // dataNasterii = "03/03/2010"
            return (double)(Varsta(DateTime.Parse(dataNasterii)));
        }

        private static double Varsta(int anulNasterii)
        {
            return (double)(DateTime.Now.Year - anulNasterii);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Varsta(DateTime.Parse("03/05/2000")));
            Console.WriteLine(Varsta("03/05/2000"));
            Console.WriteLine(Varsta(2000));

            Console.ReadKey();
        }
    }
}
