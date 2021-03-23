using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1: Polimorfismul: Static si dinamic
            // 2.1: Supraincarcarea metodelor:
            //      - Atunci cand exista mai multe metode cu acelasi nume, dar
            //      - numar si/sau tip diferit de parametri, 
            // exemplu: Suma(int a, int b),
            //          Suma(int a, int b, int c)

            // 2.2: Supraincarcarea operatorilor:
            //      - Efectuarea operatiilor asupra tipurilor definite de utilizator
            //      - public static Fratie operator [ ](Fractie f1, Fractie f2) 
            //      - Accepta doar operatori binari (+, -, *, /)

            //      - public static Fratie operator [ ](Fractie f1) 
            //      - Accepta doar operatori unari (++, --)

            //      - Semnatura corecta pentru operatorul ==

            //      - private operator == (Fractie f1 fractie f2)
            //      - public operator == (Fractie f1 fractie f2)
            //      - public static Fractie operator == (Fractie f1 fractie f2)
            //      - Corect - public static bool operator == (Fractie f1, Fractie f2)
            //      - public static bool operator == (Fractie f1)

            // 2.3: Supradefinirea metodelor:
            //      - Clasa derivata ofera implementare noua pentru o metoda ce a fost
            //      - deja definita in clasa de baza
            //      - Exemplu: Clasa persoana -> Afiseaza() *Afiseaza numele si prenumele
            //      - Clasa angajat : persoana -> Afiseaza() * Afiseaza nume, prenume, salariu

            // 3.   Listele generice (Liste de obiecte)
            //      - La fel cum putem crea liste de tip string, int, double... 
            //      asa putem crea si liste de tipuri definite de utilizator.
            //      - exemplu - Avand clasa elev, putem crea o lista de elevi

            // 3.2  Upcasting
            //      - Ne permite sa stocam intr-o lista obiecte de tipuri diferite

        }
    }
}
