using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplul4
{
    class Cerc
    {
        public double raza;

        // Constructor de copiere (Va crea obiectul prin copierea datelor din obiectul
        // transmis ca parametru de intrare.
        public Cerc(Cerc altCerc)
        {
            raza = altCerc.raza;
        }

        // Constructorul implicit.
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
            Cerc cerc1 = new Cerc();
            cerc1.raza = 30;

            Cerc cercCopie = new Cerc(cerc1);
            // raza lui cercCopie va fi 30
        }
    }
}
