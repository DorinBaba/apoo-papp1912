using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucrul_individual_3___Sarcina_2
{
    class Persoana
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public void Citire()
        {
            Console.Write("Numele: ");
            Nume = Console.ReadLine();

            Console.Write("Prenume: ");
            Prenume = Console.ReadLine();
        }
        public void Afisare()
        {
            Console.WriteLine("Numele: " + Nume);
            Console.WriteLine("Prenumele: " + Prenume);
        }
    }
    class Elev : Persoana
    {
        public string Grupa { get; set; }
        public int AnulDeStudii { get; set; }
        public double NotaMedie { get; set; }
        public new void Citire()
        {
            base.Citire();

            Console.Write("Grupa: ");
            Grupa = Console.ReadLine();

            Console.Write("Anul de studii ( 1, 2, 3, 4 ): ");
            AnulDeStudii = int.Parse(Console.ReadLine());

            Console.Write("Nota medie: ");
            NotaMedie = double.Parse(Console.ReadLine());
        }
    }
    class Profesor : Persoana
    {
        public List<string> DisciplinelePredate { get; set; }
        public int AnulAngajarii { get; set; }

        public Profesor()
        {
            DisciplinelePredate = new List<string>();
        }
        public new void Citire()
        {
            base.Citire();

            Console.Write("Anul angajarii: ");
            AnulAngajarii = int.Parse(Console.ReadLine());

            Console.Write("Numarul de discipline predate: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                Console.Write("Numele disciplinei cu numarul " + (j+1) + ": ");
                string disciplina = Console.ReadLine();

                DisciplinelePredate.Add(disciplina);
            }
        }
        public int Stagiu()
        {
            return DateTime.Now.Year - AnulAngajarii;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Persoana> persoane = new List<Persoana>();

            Console.Write("Introdu numarul de elevi: ");
            int nrElevi = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < nrElevi; i++)
            {
                Elev elev = new Elev();
                Console.WriteLine("\nIntrodu datele despre elevul cu numarul " + (i+1) + ": ");
                elev.Citire();

                persoane.Add(elev);
            }

            Console.Write("Introdu numarul de profesori: ");
            int nrProfesori = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < nrProfesori; i++)
            {
                Profesor profesor = new Profesor();
                Console.WriteLine("\nIntrodu datele despre profesorul cu numarul " + (i+1) + ": ");
                profesor.Citire();

                persoane.Add(profesor);
            }

            foreach (Persoana pers in persoane)
            {
                Console.WriteLine();
                Console.WriteLine(pers.Nume);
                Console.WriteLine(pers.Prenume);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}