using System;
using System.Globalization;

namespace SaidadeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para imprimir um conteudo na tela do console;
            Console.WriteLine("Hello World!");

            //Exemplo de como imprimir um numero usando o ponto ao inves da virgula;
            /*Neste caso, usamos a biblioteca using System.Globalization;*/

            double exemplo = 10.0265;
            Console.WriteLine(exemplo);
            Console.WriteLine(exemplo.ToString("F2"), CultureInfo.InvariantCulture);
            /*Digitando "F2" siguinifica que este numero será exibido com duas casas decimais apos o ponto*/

            Console.ReadKey();
        }
    }
}
