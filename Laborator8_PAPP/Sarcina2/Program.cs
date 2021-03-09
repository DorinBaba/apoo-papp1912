using System;

namespace Sarcina2
{
    class Punct
    {
        public double X { get; set; }
        public double Y { get; set; }   

        public static Punct operator +(Punct p1, Punct p2)
        {
            // p1 = (3, 10), p2 = (12, 5) => rezultat = (15, 15)
            return new Punct 
            { 
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
        }

        public static Punct operator -(Punct p1, Punct p2)
        {
            // p1 = (3, 10), p2 = (12, 5) => rezultat = (-9, 5)
            return new Punct
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
        }

        public static Punct operator *(Punct p1, Punct p2)
        {
            // p1 = (3, 10), p2 = (12, 5) => rezultat = (36, 50)
            return new Punct
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
        }

        public static Punct operator /(Punct p1, Punct p2)
        {
            // p1 = (3, 10), p2 = (12, 5) => rezultat = (0.25, 2)
            return new Punct
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
        }

        public static bool operator ==(Punct p1, Punct p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Punct p1, Punct p2)
        {
            return p1.X != p2.X && p1.Y != p2.Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Punct p1 = new Punct();
            p1.X = 3;
            p1.Y = 10;

            Punct p2 = new Punct();
            p2.X = 12;
            p2.Y = 5;

            Console.WriteLine($"{p1} + {p2} = {p1 + p2}"); 
            Console.WriteLine($"{p1} - {p2} = {p1 - p2}"); 
            Console.WriteLine($"{p1} * {p2} = {p1 * p2}"); 
            Console.WriteLine($"{p1} / {p2} = {p1 / p2}"); 
        }
    }
}
