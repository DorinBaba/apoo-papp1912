using System;
using System.Collections.Generic;

namespace UpCasting
{
    class Persoana
    {
        public string Nume { get; set; }
        public virtual void Info() => Console.WriteLine(Nume);
    }

    class Angajat : Persoana
    {
        public double Salariu { get; set; }
        public override void Info()
        {
            base.Info();
            Console.WriteLine(Salariu);
        }
    }

    class Client : Persoana
    {
        public int NumarAchizitii { get; set; }
        public override void Info()
        {
            base.Info();
            Console.WriteLine(NumarAchizitii);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Persoana> persone = new List<Persoana>();
            persone.Add(new Angajat { Nume = "Angajat1", Salariu = 300 });
            persone.Add(new Client { Nume = "Client1", NumarAchizitii = 1 });

            foreach (var item in persone)
            {
                item.Info();
            }
        }
    }
}
