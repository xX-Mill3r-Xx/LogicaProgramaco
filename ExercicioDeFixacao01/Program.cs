using System;
using System.Globalization;

namespace ExercicioDeFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem em sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha):");

            string[] dados = Console.ReadLine().Split(' ');
            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
