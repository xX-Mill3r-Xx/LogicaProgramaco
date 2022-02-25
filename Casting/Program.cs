using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double z = 0.1;

            x = 5;
            y = 10;
            z = x + y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // para fazer uma variavel double receber uma variavel int;
            y = (int)z;
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
