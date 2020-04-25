using System;

namespace TP1.ConsoleApp.Subtracao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Subtrair(args[0], args[1]);
        }

        public static void Subtrair(string x, string y)
        {
            int numeroX = int.Parse(x);
            int numeroY = int.Parse(y);

            int subtracao = numeroX - numeroY;

            Console.WriteLine("A subtração é: " + subtracao);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
