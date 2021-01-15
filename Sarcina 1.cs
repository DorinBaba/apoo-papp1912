using System;
using System.Collections.Generic;

namespace Sarcina1
{
    class Angajat
    {
        // Datele despre angajat (Caracteristici)
        public string nume;
        public string functia;
        public int anulAngajarii;
        public int oreLucrate;
        public double plataPerOra;

        // Metode (Comportament)
        public void Citire()
        {
            Console.Write("Numele angajatului: ");
            nume = Console.ReadLine();

            Console.Write("Functia angajatului: ");
            functia = Console.ReadLine();

            Console.Write("Anul angajarii: ");
            anulAngajarii = int.Parse(Console.ReadLine());

            Console.Write("Ore lucrate: ");
            oreLucrate = int.Parse(Console.ReadLine());

            Console.Write("Plata pe ora: ");
            plataPerOra = double.Parse(Console.ReadLine());
        }

        public void Afisare()
        {
            Console.WriteLine($"Numele: {nume}");
            Console.WriteLine($"Functia: {functia}");
            Console.WriteLine($"Anul angajarii: {anulAngajarii}");
            Console.WriteLine($"Ore lucrate: {oreLucrate}");
            Console.WriteLine($"Plata per ora: {plataPerOra}");
            Console.WriteLine($"Salariu calculat: {SalariuCalculat()}");
            Console.WriteLine($"Spor: {Spor()}");
            Console.WriteLine($"Salariu primit: {SalariuPrimit()}");
        }

        public int Stagiu() => DateTime.Now.Year - anulAngajarii;

        public double SalariuCalculat() => plataPerOra * oreLucrate;

        public double Spor() => SalariuCalculat() / 100 * 15;

        public double SalariuPrimit() => SalariuCalculat() + Spor();
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Angajat> angajati = new List<Angajat>();

            Console.Write("Numarul de angajati: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nDatele despre angajatul " + (i+1));
                Angajat angajat = new Angajat();
                angajat.Citire();
                angajati.Add(angajat);
            }


            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Angajatii inregistrati");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nDatele despre angajatul " + (i + 1));
                angajati[i].Afisare();
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Angajatii cu stagiul mai mare de 10 ani");
            for (int i = 0; i < n; i++)
            {
                if (angajati[i].Stagiu() > 10)
                    angajati[i].Afisare();
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Angajatii cu salariu mai mare decat 1000");
            for (int i = 0; i < n; i++)
            {
                if (angajati[i].SalariuPrimit() > 1000)
                    angajati[i].Afisare();
            }
        }
    }
}
