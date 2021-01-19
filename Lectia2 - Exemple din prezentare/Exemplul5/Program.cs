using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplul5
{
    // Utilizarea destructorului
    class Cerc
    {
        public int raza;

        public int Raza { get; set; }



    }

    class Program
    {
        static void Main(string[] args)
        {
            // Cream obiectul cerc1
            Cerc cerc1 = new Cerc();
            cerc1.raza = 30;

            // Obiectul va fi distrus ia iesirea din metoda Main.
            // CTRL + F5 Pentru a va convinge ;) 
        }
    }
}
