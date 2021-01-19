using System;

namespace Sarcina1
{
    class Putere
    {
        // Proprietatile
        public double N1 { get; set; }

        private double n2;
        public double N2
        {
            get { return n2; }
            set 
            {
                if (value == 0)
                    throw new Exception();
                else
                    n2 = value;
            }
        } 

        // Constructorul fara parametru
        public Putere()
        {

        }

        // Constructorul cu parametru
        public Putere(double numar1, double numar2)
        {
            N1 = numar1;
            N2 = numar2;
        }

        // Constructorul de copiere
        public Putere(Putere aux)
        {
            N1 = aux.N1;
            N2 = aux.N2;
        }

        // Metoda de citire
        public void Citire()
        {
            Console.Write("N1: ");
            N1 = double.Parse(Console.ReadLine());

            Console.Write("N2: ");
            N2 = double.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");
        }

        public void Afisare()
        {
            Console.WriteLine("N1: " + N1);
            Console.WriteLine("N2: " + N2);
            Console.WriteLine("N1^N2: " + Power());
            Console.WriteLine("---------------------");
        }

        public double Power()
        {
            return Math.Pow(N1, N2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Utilizam constructorul fara parametri
            Putere putere1 = new Putere();
            putere1.Citire();
            Console.WriteLine("Putere 1:");
            putere1.Afisare();

            // Utilizam constructorul cu parametri
            Putere putere2 = new Putere(4,2);
            Console.WriteLine("Putere 2: Am utilizat constructorul cu 2 parametri: 4 si 2");
            putere2.Afisare();

            // Utilizam constructorul de copiere
            Putere putere3 = new Putere(putere2);
            Console.WriteLine("Putere 3: Am utilizat constructorul de copiere. Am clonat obiectul Putere2");
            putere3.Afisare();
        }
    }
}
