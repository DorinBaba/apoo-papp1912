using System;

namespace Sarcina6
{
    class Program
    {
        // Coded by George - Cel mai tare programator de la Iisus incoace.
        class DirectorExecutiv
        {
            public string Nume { get; set; }
            public double SalariulFix { get; set; }
            public int AnulAngajarii { get; set; }
            public int Stagiu() => DateTime.Now.Year - AnulAngajarii;
            public double SalariulFinal() => SalariulFix;

            public void AfisareInformatii()
            {
                Console.WriteLine("Director Executiv");
                Console.WriteLine($"Nume: {Nume}");
                Console.WriteLine($"Salariul: {SalariulFinal()} Lei");
                Console.WriteLine($"Stagiu: {Stagiu()} Ani");
            }
        }

        class AgentVanzari
        {
            // Primeste bonus 0.3% la salariu pentru fiecare vanzare.
            public string Nume { get; set; }
            public double SalariulFix { get; set; }
            public int AnulAngajarii { get; set; }
            public int Stagiu() => DateTime.Now.Year - AnulAngajarii;
            public int NrVanzari { get; set; }
            public double SalariulFinal() => SalariulFix + (SalariulFix / 100 * 0.3 * NrVanzari);
            public void AfisareInformatii()
            {
                Console.WriteLine("Agent Vanzari");
                Console.WriteLine($"Nume: {Nume}");
                Console.WriteLine($"Salariul: {SalariulFinal()} Lei");
                Console.WriteLine($"Stagiu: {Stagiu()} Ani");
                Console.WriteLine($"Numar Vanzari: {NrVanzari}");
            }
        }

        class AgentResurseUmane
        {
            // Primeste bonus 0.6% la salariu pentru fiecare cv revizuit si 14% pentru fiecare persoana angajata. 
            public string Nume { get; set; }
            public double SalariulFix { get; set; }
            public int AnulAngajarii { get; set; }
            public int Stagiu() => DateTime.Now.Year - AnulAngajarii;
            public int NrAngajari { get; set; }
            public int NrCVuriRevizuite { get; set; }
            public double SalariulFinal()
            {
                double bonusCVuriRevizuite = SalariulFix / 100 * 0.6 * NrCVuriRevizuite;
                double bonusAngajari = SalariulFix / 100 * 14 * NrAngajari;
                return SalariulFix + bonusCVuriRevizuite + bonusAngajari;
            }
            public void AfisareInformatii()
            {
                Console.WriteLine("Agent Resurse Umane");
                Console.WriteLine($"Nume: {Nume}");
                Console.WriteLine($"Salariul: {SalariulFinal()} Lei");
                Console.WriteLine($"Stagiu: {Stagiu()} Ani");
                Console.WriteLine($"Numar Angajari: {NrAngajari}");
                Console.WriteLine($"Numar CVuriRevizuite: {NrCVuriRevizuite}");
            }
        }

        class Consultant
        {
            public string Nume { get; set; }
            public double SalariulFix { get; set; }
            public int AnulAngajarii { get; set; }
            public int Stagiu() => DateTime.Now.Year - AnulAngajarii;
            public string Departament { get; set; }
            public double SalariulFinal() => SalariulFix;
            public void AfisareInformatii()
            {
                Console.WriteLine("Consultant");
                Console.WriteLine($"Nume: {Nume}");
                Console.WriteLine($"Salariul: {SalariulFinal()} Lei");
                Console.WriteLine($"Stagiu: {Stagiu()} Ani");
                Console.WriteLine($"Departament: {Departament}");
            }
        }

        class Client
        {
            public string Nume { get; set; }
            public string NumarTelefon { get; set; }
            public string Adresa { get; set; }
            public DateTime DataUltimeiAchizitii { get; set; }
            public void AfisareInformatii()
            {
                Console.WriteLine("Client");
                Console.WriteLine($"Nume: {Nume}");
                Console.WriteLine($"Numar Telefon: {NumarTelefon} Lei");
                Console.WriteLine($"Adresa: {Adresa}");
                Console.WriteLine($"Data Ultimei Achizitii: {DataUltimeiAchizitii.ToString("dd/MM/yyyy")}");
            }
        }

        class AgentMarketing
        {
            // Va primit un adaos de 20% la salariu daca a a cheltuit sub 100 lei pentru a
            // atrage un client, 10% - sub 400 lei, 0% - mai mult de 400 de lei.
            public string Nume { get; set; }
            public double SalariulFix { get; set; }
            public int AnulAngajarii { get; set; }
            public int Stagiu() => DateTime.Now.Year - AnulAngajarii;
            public int SumaAlocataPentruPromovare { get; set; }
            public int NrClientiAtrasi { get; set; }
            public double SalariulFinal()
            {
                double sumaPerClient = SumaAlocataPentruPromovare / NrClientiAtrasi;
                double adaos = 0;
                if (sumaPerClient < 100)
                    adaos = SalariulFix / 100 * 20;
                else
                    if (sumaPerClient < 400)
                    adaos = SalariulFix / 100 * 10;

                return SalariulFix + adaos;
            }

            public void AfisareInformatii()
            {
                Console.WriteLine("AgentMarketing");
                Console.WriteLine($"Nume: {Nume}");
                Console.WriteLine($"Salariu: {SalariulFinal()} Lei");
                Console.WriteLine($"Stagiu: {Stagiu()} Lei");
                Console.WriteLine($"Suma Alocata Pentru Promovare: {SumaAlocataPentruPromovare} Lei");
                Console.WriteLine($"Clienti Atrasi: {NrClientiAtrasi}");
                Console.WriteLine($"Sporul: {(SumaAlocataPentruPromovare/ NrClientiAtrasi):f2} Lei per client");
            }
        }

        static void Main(string[] args)
        {
            // Nu avem permisiunea de a modifica codul metodei Main!
            DirectorExecutiv directorExecutiv = new DirectorExecutiv();
            directorExecutiv.Nume = "Vasile Versaci";
            directorExecutiv.AnulAngajarii = 1999;
            directorExecutiv.SalariulFix = 10000;
            directorExecutiv.AfisareInformatii();
            Console.WriteLine();

            AgentVanzari agentVanzari = new AgentVanzari();
            agentVanzari.Nume = "Andrei Versaci";
            agentVanzari.NrVanzari = 140;
            agentVanzari.SalariulFix = 5600;
            agentVanzari.AnulAngajarii = 2012;
            agentVanzari.AfisareInformatii();
            Console.WriteLine();

            AgentResurseUmane agentResurseUmane = new AgentResurseUmane();
            agentResurseUmane.Nume = "Valeriu Versaci";
            agentResurseUmane.AnulAngajarii = 2019;
            agentResurseUmane.NrCVuriRevizuite = 14;
            agentResurseUmane.NrAngajari = 2;
            agentResurseUmane.SalariulFix = 5000;
            agentResurseUmane.AfisareInformatii();
            Console.WriteLine();

            AgentMarketing agentMarketing = new AgentMarketing();
            agentMarketing.Nume = "Oleg Versaci";
            agentMarketing.SumaAlocataPentruPromovare = 10000;
            agentMarketing.NrClientiAtrasi = 80;
            agentMarketing.SalariulFix = 7000;
            agentMarketing.AnulAngajarii = 2010;
            agentMarketing.AfisareInformatii();
            Console.WriteLine();

            Consultant consultant = new Consultant();
            consultant.Nume = "Ion Versaci";
            consultant.Departament = "Vanzari";
            consultant.AnulAngajarii = 2006;
            consultant.SalariulFix = 4300;
            consultant.AfisareInformatii();
            Console.WriteLine();

            Client client = new Client();
            client.Nume = "Eliot Versaci";
            client.NumarTelefon = "+373 67 452 331";
            client.DataUltimeiAchizitii = DateTime.Now;
            client.Adresa = "Strada Trandafirilor Nr.33";
            client.AfisareInformatii();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
