using System;
using System.Globalization;

namespace EentradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Voce digitou {nome}");

            Console.Write("Digite um numero inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Voce digitou {n1}");

            Console.Write("Digite um numero com casas decimais: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Voce digitou {n2.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite um caracter: ");
            char caractere = char.Parse(Console.ReadLine());
            Console.WriteLine($"Voce digitou {caractere}");

            Console.WriteLine();

            string[] vet = Console.ReadLine().Split(' ');
            nome = vet[0];
            n1 = int.Parse(vet[1]);
            n2 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            caractere = char.Parse(vet[3]);

            Console.WriteLine();

            Console.WriteLine(nome);
            Console.WriteLine(n1);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(caractere);

            Console.ReadLine();
        }
    }
}
