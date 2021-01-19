using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplul6
{
    class Cerc
    {
        private int raza;

        public int Raza
        {
            get 
            { 
                return raza; 
            }

            set 
            {
                // Daca valoarea este mai mica decat 0, atunci 
                // raza va fi 0, 
                if (value < 0) 
                    raza = 0;
                else
                    raza = value;
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Cerc cerc = new Cerc();
            cerc.Raza = -3;
            Console.WriteLine(cerc.Raza); // raza va fi 0

            cerc.Raza = 3;
            Console.WriteLine(cerc.Raza); // raza va fi 3
        }
    }
}
