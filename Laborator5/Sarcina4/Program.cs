using System;
using System.Collections.Generic;

namespace Sarcina4
{
    class Anunt
    {
        // Proprietatile comune pentru orice anunt
        public string Autor { get; set; }
        public double Pret { get; set; }
        public string NumarContact { get; set; }

        public void CitireDate()
        {
            Console.Write("Autorul anuntului: ");
            Autor = Console.ReadLine();
            Console.Write("Pretul: ");
            Pret = double.Parse(Console.ReadLine());
            Console.Write("Numar de contact: ");
            NumarContact = Console.ReadLine();
        }

        public void AfisareDate()
        {
            Console.WriteLine($"Autorul anuntului: {Autor}");
            Console.WriteLine($"Pretul: {Pret}");
            Console.WriteLine($"Numarul de contact: {NumarContact}");
        }
    }


    class AnuntApartament : Anunt
    {
        // Proprietatile specifice pentru un anunt de vanzare a unui
        // apartament
        public double MetriPatrati { get; set; }
        public string Regiune { get; set; }
        public int NrCamere { get; set; }

        public void CitireDate()
        {
            // Mai invai vom citi datele specifice unui apartament, dupa care
            // - pe cele specifice oricarui anunt
            Console.Write("Metri Patrati: ");
            MetriPatrati = double.Parse(Console.ReadLine());
            Console.Write("Regiunea: ");
            Regiune = Console.ReadLine();
            Console.Write("Numarul de camere: ");
            NrCamere = int.Parse(Console.ReadLine());

            // Iar de citire celorlalte proprietati (autor, pret, contact) se va 
            // ocupa clasa de baza
            base.CitireDate();
        }

        public void AfisareDate()
        {
            // Mai invai vom afisa datele specifice unui apartament, dupa care
            // - pe cele specifice oricarui anunt
            Console.WriteLine($"Metri Patrati: {MetriPatrati}");
            Console.WriteLine($"Regiunea: {Regiune}");
            Console.WriteLine($"Nr Camere: {NrCamere}");

            // Iar de afisarea celorlalte proprietati (autor, pret, contact) se va 
            // ocupa clasa de baza
            base.AfisareDate();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cream si citim datele despre n apartamente.
            Console.Write("Numarul de apartamente spre vanzare: ");
            int n = int.Parse(Console.ReadLine());
            List<AnuntApartament> anunturiApartamente = new List<AnuntApartament>();

            for (int i = 0; i < n; i++)
            {
                AnuntApartament anuntApartament = new AnuntApartament();
                anuntApartament.CitireDate();

                anunturiApartamente.Add(anuntApartament);
            }

            // Identificam care este cel mai scump apartament
            double pretMax = 0;
            AnuntApartament anuntApartamentPretMax = new AnuntApartament();
            
            // Parcurgem lista pentru a gasi care apartamentul cu pretul maxim
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Apartamentul Nr: {i+1}\n");
                if(pretMax < anunturiApartamente[i].Pret)
                {
                    pretMax = anunturiApartamente[i].Pret;
                    anuntApartamentPretMax = anunturiApartamente[i];
                }
            }

            Console.WriteLine("Cel mai scump apartament: ");
            anuntApartamentPretMax.AfisareDate();

            Console.ReadKey();
        }
    }
}
