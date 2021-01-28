using System;

namespace Sarcina_1
{
    class Triunghi
    {
        // Proprietatile clasei
        public double Latura1 { get; set; }
        public double Latura2 { get; set; }
        public double Latura3 { get; set; }

        // Metodele clasei
        public double Aria()
        {
            double p = (Latura1 + Latura2 + Latura3) / 2;
            return Math.Sqrt(p * (p - Latura1) * (p - Latura2) * (p - Latura3));
        }

        public double Perimetru()
        {
            return Latura1 + Latura2 + Latura3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cream un obiect de tip Triunghi
            Triunghi triunghi = new Triunghi();

            // Setam valori pentru proprietatile triunghiului
            triunghi.Latura1 = 3;
            triunghi.Latura2 = 4;
            triunghi.Latura3 = 5;

            // Afisam datele
            Console.WriteLine("Datele despre triunghi:");
            Console.WriteLine($"Latura 1: {triunghi.Latura1}");
            Console.WriteLine($"Latura 2: {triunghi.Latura2}");
            Console.WriteLine($"Latura 3: {triunghi.Latura3}");
            Console.WriteLine();
            Console.WriteLine($"Perimetrul: {triunghi.Perimetru()}");
            Console.WriteLine($"Aria: {triunghi.Aria()}");

            Console.ReadKey();
        }
    }
}
