using System;
using System.Collections.Generic;
using System.IO;

namespace fisierTextCitire
{
    class Elev
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Grupa { get; set; }
        public int AnulDeStudii { get; set; }
        public double MediaGenerala { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("date.in");
            List<Elev> elevi = new List<Elev>();
            for (int i = 0; i < 5; i++)
            {
                string[] date = sr.ReadLine().Split("@@@");
                elevi.Add(new Elev
                {
                    Nume = date[0],
                    Prenume = date[1],
                    Grupa = date[2],
                    AnulDeStudii = int.Parse(date[3]),
                    MediaGenerala = double.Parse(date[4])
                });
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(elevi[i].Prenume);
            }
        }
    }
}
