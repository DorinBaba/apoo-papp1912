using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarcina5
{
    class Angajat
    {
        // Proprietatile clasei
        public string Nume { get; set; }
        private string IDNP { get; set; }
        private double OreLucrate { get; set; }
        private double PlataPerOra { get; set; }

        // Constructorul fara parametri
        public Angajat()
        {

        }

        // Constructorul cu parametri
        public Angajat(string nume, string idnp, double oreLucrate, double plataPerOra)
        {
            this.Nume = nume;
            this.IDNP = idnp;
            this.OreLucrate = oreLucrate;
            this.PlataPerOra = plataPerOra;
        }

        public void Citire()
        {
            Console.WriteLine($"Nume: ");
            Nume = Console.ReadLine();

            Console.WriteLine($"IDNP: ");
            IDNP = Console.ReadLine();

            Console.WriteLine($"Ore Lucrate: ");
            OreLucrate = double.Parse(Console.ReadLine());

            Console.WriteLine($"Plata per ora: ");
            PlataPerOra = double.Parse(Console.ReadLine());

            Console.WriteLine("Datele au fost citite cu succes!");
        }

        public void Afisare()
        {
            Console.WriteLine($"Nume: {Nume}");
            Console.WriteLine($"Salariu: {SalariulTotal():f2}");
        }

        // Metoda de calculare a salariului total
        private double SalariulTotal() => OreLucrate * PlataPerOra;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cream un obiect utilizat constructorul cu parametri
            var angajat = new Angajat("Michael Rosen", "200123988441", 400, 75);

            angajat.Afisare();

            Console.ReadKey();
        }
    }
}
