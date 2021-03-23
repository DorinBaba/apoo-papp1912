using System;

namespace Supradefinire
{
    class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }

        public void Afiseaza()
        {
            Console.WriteLine(Nume);
            Console.WriteLine(Prenume);
        }
    }

    class Angajat : Persoana
    {
        public double Salariu { get; set; }

        public new void Afiseaza()
        {
            base.Afiseaza();
            Console.WriteLine(Salariu);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Persoana p = new Persoana
            {
                Nume = "Vasile",
                Prenume = "Ciolak"
            };

            Angajat a = new Angajat
            {
                Nume = "Johnson",
                Prenume = "Statham",
                Salariu = 2400
            };

            Console.WriteLine("Afisare persoana:");
            p.Afiseaza();

            Console.WriteLine("Afisare angajat: ");
            a.Afiseaza();
        }
    }
}
