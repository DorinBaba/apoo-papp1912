using System;
using System.Threading;

namespace Exemplul2
{
    class Telefon
    {
        public string Model { get; set; }
        public int Battery { get; set; } // 0 - ;(, 100 - full
        public void Charging()
        {
            while (Battery <= 100)
            {
                Battery += 1;
                Thread.Sleep(1000);
                Console.WriteLine("Nivel baterie: " + Battery + "%");
            }
        }
    }

    class GalaxyS4 : Telefon
    {
        public new void Charging()
        {
            while (Battery <= 100)
            {
                Battery += 3;
                Thread.Sleep(1000);
                Console.WriteLine("Nivel baterie: " + Battery + "%");
            }
        }
    }

    class GalaxyS21 : Telefon
    {
        public new void Charging()
        {
            while (Battery < 100)
            {
                Battery += 10;
                Thread.Sleep(500);
                Console.WriteLine("Nivel baterie: " + Battery + "%");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Incarcare galaxy s21:");
            GalaxyS21 galaxyS21 = new GalaxyS21();
            galaxyS21.Charging();

            Console.WriteLine("Incarcare galaxy s4:");
            GalaxyS4 galaxyS4 = new GalaxyS4();
            galaxyS4.Charging();

            int rezultat = 3 + 6;
        }
    }
}
