using System.Globalization;

/* 
 Neste codigo temos exemplos de:
    - COMO LER NUMEROS DECIMAIS COM PONTO E NAO DAR ERRO NO WINDOWS
    - COMO PRINTAR NUMEROS COM 3 CASAS DECIMAIS USANDO O PADRAO DE SEPARADOR POR PONTO
    - COMO LER MAIS DE UM NUMERO NA MESMA LINHA E DIVIDIR ESSA LINHA USANDO SPLIT
    - COMO FAZER O PARSE DE STRINGS PARA NUMEROS

*/
namespace Bee1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            double a, b, c;
            double areaTri, areaCir, areaTrap, areaQuad, AreaRet;

            line = Console.ReadLine();
            var numeros = line.Split(' ');

            a = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            b = double.Parse(numeros[1], CultureInfo.InvariantCulture);
            c = double.Parse(numeros[2], CultureInfo.InvariantCulture);

            areaTri = (a * c) / 2;
            areaCir = 3.14159 * (c * c);
            areaTrap = ((a + b) * c) / 2;
            areaQuad = b * b;
            AreaRet = a * b;

            Console.WriteLine($"TRIANGULO: {areaTri.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCir.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrap.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQuad.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {AreaRet.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}