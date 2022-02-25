using System;
using System.Globalization;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da sintaxe de uma vatiavel;
            //<TIPO> <NOME> = <VALOR INICIAL>;

            string nome = "Seu Nome"; //Exemplo de uma variavel que armazena texto;
            int numero = 10; //Exemplo de uma variavel que armazena numeros inteiros;
            float numeroFlutuande = 1.85f; //Exemplo de uma variavel que armazena numeros de ponto flutuante;
            /*Obs.: variaveis do tipo float precisão ser sinalizadas com a letra f no final da atribuição*/
            double numeroComPonto = 0.1; //Variaveis que armazena numeros com casas decimais;
            char letra = 'L'; //Variaveis que armazena um caracter;

            Console.WriteLine(nome);
            Console.WriteLine(numero);
            Console.WriteLine(numeroFlutuande);
            Console.WriteLine(numeroComPonto);
            Console.WriteLine(letra);

            Console.ReadKey();
        }
    }
}
