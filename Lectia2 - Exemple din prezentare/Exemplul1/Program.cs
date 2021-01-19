using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplul1
{
    // Utilizarea constructorului implicit

    class Cerc
    {
        // Clasa cerc nu detine nici un constructor creat de noi.
        // La crearea obiectelor va fi utilizat constructorul implicit (new Cerc())

        public double raza;

        public double Diametru()
        {
            return raza * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cerc cerc = new Cerc();
        }
    }
}
