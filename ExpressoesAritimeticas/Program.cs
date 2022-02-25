using System;

namespace ExpressoesAritimeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Somando duas variaveis;
            int v1 = 10;
            int v2 = 20;
            Console.WriteLine($"O valor da soma é: {v1 + v2}");

            //Subtraindo;
            Console.WriteLine($"O valor da subtração é: {v1 - v2}");

            //Multiplicando;
            Console.WriteLine($"O valor da multiplicação é: {v1 * v2}");

            //Dividindo;
            Console.WriteLine($"O valor da divisão é: {v1 / v2}");

            //Obtendo o Mod (resto) da divisão;
            Console.WriteLine($"O valor do resto da divisão (Mod) é: {v1 % v2}");

            Console.ReadLine();
        }
    }
}
