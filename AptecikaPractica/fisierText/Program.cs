using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace fisierText
{
    //    Creați clasa Elev cu umătoarele:
    //•	Date: Nume, Prenume, Grupa, Anul de studii, Media generală
    //Creați o listă în care veți însera cel puțin 2 elevi.
    //Înscrieți lista rezultată în fișierul date.out

    class Elev
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int AnulDeStudii { get; set; }
        public double MediaGenerala { get; set; }

        public override string ToString()
        {
            return $"Date despre elev:\n" +
                $"Nume: {Nume},\n" +
                $"Prenume: {Prenume}, \n" +
                $"Anul de studii: {AnulDeStudii},\n" +
                $"MediaGenerala: {MediaGenerala}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Elev> elevi = new List<Elev>();
            elevi.Add(new Elev
            {
                Nume = "Musk",
                Prenume = "Elon",
                AnulDeStudii = 3,
                MediaGenerala = 9.12
            });

            elevi.Add(new Elev
            {
                Nume = "Buffet",
                Prenume = "Waren",
                AnulDeStudii = 2,
                MediaGenerala = 10
            });

            StreamWriter sw = new StreamWriter("date.out");
            foreach(var elev in elevi)
            {
                sw.WriteLine(elev);
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
