using System.Globalization;
using System;

namespace Bee1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, raiz1, raiz2;
            string line;

            line = Console.ReadLine();
            var numeros = line.Split(' ');

            a = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            b = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            c = double.Parse(numeros[2], CultureInfo.InvariantCulture);

            delta = (b * b) - (4 * a * c);
            if (delta < 0 || a == 0) Console.WriteLine("Impossivel calcular");
            else
            {
                raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"R1 = {raiz1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {raiz2.ToString("F5", CultureInfo.InvariantCulture)}");

            }
        }
    }
}