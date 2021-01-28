using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarcina7
{
    class Automobil
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public double Pret { get; set; }
    }

    class DealerAuto
    {
        public string Adresa { get; set; }
        public List<Automobil> Automobile { get; set; }

        public void Citire()
        {
            Console.WriteLine("Citirea datelor despre dealer-ul auto:\n");

            Console.Write("Adresa dealer-ului: ");
            Adresa = Console.ReadLine();

            Console.Write("Numarul de automobile: ");
            int n = int.Parse(Console.ReadLine());

            Automobile = new List<Automobil>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nAutomobilul " + (i+1));
                
                // Cream un obiect de tip Automobil si citim datele
                Automobil automobil = new Automobil();
                Console.Write("Marca: ");
                automobil.Marca = Console.ReadLine();

                Console.Write("Model: ");
                automobil.Model = Console.ReadLine();

                Console.Write("Pret: ");
                automobil.Pret = double.Parse(Console.ReadLine());

                // Introducem obiectul citit in lista de automobile
                Automobile.Add(automobil);
                Console.WriteLine("Datele au fost citite cu succes!");
            }
        }

        public void Afisare()
        {
            // Afisam datele despre dealer-ul auto
            Console.WriteLine("\n------------------------< Detaliile despre Dealer-ul auto >----------------------");
            Console.WriteLine("Adresa: " + Adresa);
            Console.WriteLine("\nAutomobilel detinute:");

            Automobile.ForEach(q =>
            {
                Console.WriteLine("\nMarca Model: " + q.Marca + " " + q.Model);
                Console.WriteLine("Pret: " + q.Pret);
            });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new DealerAuto();

            dealer.Citire();
            dealer.Afisare();

            Console.ReadKey();
        }
    }
}
