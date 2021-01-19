using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplul2
{
    // Utilizarea constructorului explicit

    class Cerc
    {
        public double raza;

        // Constructorul EXPLICIT (Creat de noi)
        public Cerc(double r)
        {
            raza = r;
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
            Cerc cerc = new Cerc(420); // Raza va fi 420
        }
    }
}
