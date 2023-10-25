class Program
{
    private static void Main(string[] args)
    {
        int numero = 0, vezes = 0;
        string piscada;
        int[] loteria = new int[3];
        
        while (vezes != 3) {

            do {
                piscada = Console.ReadLine();
                if (piscada[0] == '*') numero += 4;
                if (piscada[1] == '*') numero += 2;
                if (piscada[2] == '*') numero++;

            } while (piscada.Equals("caw caw") == false);
            loteria[vezes] = numero;
            numero = 0;
            vezes++;
        }

        foreach (int i in loteria)
        { 
            Console.WriteLine(i);
        }
    }
}