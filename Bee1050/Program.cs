using System.Collections.Generic;
using System;

class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> estados = new Dictionary<int, string>();

        estados.Add(61, "Brasilia");
        estados.Add(71, "Salvador");
        estados.Add(11, "Sao Paulo");
        estados.Add(21, "Rio de Janeiro");
        estados.Add(32, "Juiz de Fora");
        estados.Add(19, "Campinas");
        estados.Add(27, "Vitoria");
        estados.Add(31, "Belo Horizonte");

        int ddd = Convert.ToInt32(Console.ReadLine());
        if (estados.ContainsKey(ddd))
        {
            Console.WriteLine(estados.GetValueOrDefault(ddd));
        }
        else Console.WriteLine("DDD nao cadastrado");

    }
}