using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplul3
{

    class Cerc
    {
        public double raza;

        // Constructor EXPLICIT (Creat de noi)
        public Cerc(double r)
        {
            raza = r;
        }

        // Constructorul fara parametri (Implicit)
        public Cerc()
        {
            
        }

        public double Diametru()
        {
            return raza * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cerc cercImplicit = new Cerc(); // Raza va fi 0
            Cerc cercExplicit = new Cerc(420); // Raza va fi 420
        }
    }
}
