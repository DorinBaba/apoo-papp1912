using System;

namespace Sarcina1
{
    // Binar - clasa de baza
    class Binar
    {
        public double A { get; set; }
        public double B { get; set; }

        // Constructorul cu parametri
        public Binar(double a, double b)
        {
            A = a;
            B = b;
        }
    }

    // Clasa derivata - Putere
    class Putere : Binar
    {
        // Constructorul cu parametri - vom primi 2 parametri, baza si exponentul,
        // care vor fi redirectionate catre constructorul clasei de baza (Binar), deoarece
        // el se ocupa de setarea valorilor pentru proprietatile A si B
        public Putere(double baza, double exponent) : base(baza, exponent)
        {
            // Proprietatile A si B vor fi setate de catre clasa Binar    
        }

        public double Calculeaza()
        {
            // A este baza, B este exponentul, returnam A ^ B,
            return Math.Pow(A, B);
        }

        public void Afisare()
        {
            Console.WriteLine($"Baza: {A}");
            Console.WriteLine($"Exponentul: {B}");
            Console.WriteLine($"{A} ^ {B} = {Calculeaza():f2}");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Putere putere = new Putere(8, 2);
            putere.Afisare();

            Console.ReadLine();
        }
    }
}
