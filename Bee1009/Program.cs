using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bee1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, vendas, salarioComissionado;

            nome = Console.ReadLine();
            salarioFixo = Convert.ToDouble(Console.ReadLine());
            vendas = Convert.ToDouble(Console.ReadLine());
            salarioComissionado = salarioFixo + (vendas * 0.15);
            Console.WriteLine($"TOTAL = R$ {salarioComissionado:00.00}");
        }
    }
}
