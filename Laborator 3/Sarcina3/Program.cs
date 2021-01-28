using System;

class Fractie
{
    public double Numarator { get; set; }
    public double Numitor { get; set; }

    // Constructorul fara parametri
    public Fractie()
    {

    }

    // Constructorul cu parametri
    public Fractie(double numarator, double numitor)
    {
        this.Numarator = numarator;
        this.Numitor = numitor;
    }

    // Constructorul de copiere
    public Fractie(Fractie altaFractie)
    {
        this.Numarator = altaFractie.Numarator;
        this.Numitor = altaFractie.Numitor;
    }

    public double RezultatFractie()
    {
        return Numarator / Numitor;
    }

    public void Afisare()
    {
        Console.WriteLine($"{Numarator} / {Numitor} = {RezultatFractie():f2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prima fractie - utilizam constructorul fara parametri
        Fractie fractie1 = new Fractie();
        fractie1.Numarator = 10;
        fractie1.Numitor = 2;

        // Afisam datele despre prima fractie
        Console.WriteLine("Datele despre fractia 1: ");
        fractie1.Afisare();

        // A doua fractie - utilizam constructorul cu parametri
        Fractie fractie2 = new Fractie(100, 50);

        // Afisam datele despre a 2-a fractie
        Console.WriteLine("\nDatele despre fractia 2:");
        fractie2.Afisare();

        // A 3-a fractie - utilizam constructorul de copiere, vom copia prima fractie
        Fractie fractie3 = new Fractie(fractie1);

        // Afisam datele despre a 2-a fractie
        Console.WriteLine("\nDatele despre fractia 3:");
        fractie3.Afisare();

        Console.ReadKey();
    }
}
