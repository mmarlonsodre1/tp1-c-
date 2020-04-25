using System;

namespace TP1.ConsoleApp.Divisao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dividir(args[0], args[1]);
        }

        public static void Dividir(string x, string y)
        {
            int numeroX = int.Parse(x);
            int numeroY = int.Parse(y);

            try
            {
                int divisao = numeroX / numeroY;
                Console.WriteLine("A divisão é: " + divisao);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não pode dividir por zero");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
