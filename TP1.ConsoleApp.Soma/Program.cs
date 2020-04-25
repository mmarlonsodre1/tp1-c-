using System;

namespace TP1.ConsoleApp.Soma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Somar(args[0], args[1]);
        }

        public static void Somar(string x, string y)
        {
            int numeroX = int.Parse(x);
            int numeroY = int.Parse(y);

            int soma = numeroX + numeroY;

            Console.WriteLine("A soma é: " + soma);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
