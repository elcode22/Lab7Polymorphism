using System;

namespace Lab7Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            double heigth;
            double length;
            double majorRadius;
            double minorRadius;

            Console.WriteLine("Skriv in fyra första bokstäverna på den \n" + 
                "form du vill räkna ut arean på \n" + 
                "(rektangel, kvadrat, cirkel, parallellogram, ellips):");
            string shape = Console.ReadLine();

            switch (shape)
            {
                case "rekt":
                    Console.WriteLine("Skriv in rektangelns längd:");
                    length = double.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv in rektangelns höjd:");
                    heigth = double.Parse(Console.ReadLine());

                    Rektangel rekt = new Rektangel(length, heigth);

                    Console.WriteLine(rekt.Area() + " l.e^2");
                    break;
                case "kvad":
                    Console.WriteLine("Skriv in måttet rektangelns sida:");
                    double side = double.Parse(Console.ReadLine());

                    Kvadrat kvad = new Kvadrat(side);

                    Console.WriteLine(kvad.Area() + " l.e^2");
                    break;
                case "cirk":
                    Console.WriteLine("Skriv in cirkelns radie:");
                    double radius = double.Parse(Console.ReadLine());

                    Cirkel cirk = new Cirkel(radius);

                    Console.WriteLine(cirk.Area() + " l.e^2");
                    break;
                case "para":
                    Console.WriteLine("Skriv in parallellogramets höjd:");
                    heigth = double.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv in parallellogramets längd:");
                    length = double.Parse(Console.ReadLine());

                    Parallellogram para = new Parallellogram(heigth, length);

                    Console.WriteLine(para.Area() + " l.e^2");
                    break;
                case "elli":
                    Console.WriteLine("Skriv in ellipsens större radie:");
                    majorRadius = double.Parse(Console.ReadLine());

                    Console.WriteLine("Skriv in ellipsens mindre radie:");
                    minorRadius = double.Parse(Console.ReadLine());

                    Ellips elli = new Ellips(majorRadius, minorRadius);

                    Console.WriteLine(Math.Round(elli.Area(), 2) + " l.e^2");
                    break;
            }
        }
    }
}
