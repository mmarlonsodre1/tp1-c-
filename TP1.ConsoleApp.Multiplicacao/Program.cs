using System;

namespace TP1.ConsoleApp.Multiplicacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Multiplicar(args[0], args[1]);
        }

        public static void Multiplicar(string x, string y)
        {
            int numeroX = int.Parse(x);
            int numeroY = int.Parse(y);

            int multiplicacao = numeroX + numeroY;

            Console.WriteLine("A multiplicação é: " + multiplicacao);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
