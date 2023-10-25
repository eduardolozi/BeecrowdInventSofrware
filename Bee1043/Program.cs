using System;
using System.Globalization;

namespace Bee1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string line = Console.ReadLine();
            var numeros = line.Split(' ');

            a = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            b = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            c = double.Parse(numeros[2], CultureInfo.InvariantCulture);

            if(a + b > c && a + c > b && c + b > a)
            {
                double perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
            } else
            {
                double area = ((a + b) * c) / 2;
                Console.WriteLine($"Area = {area.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            
        }
    }
}