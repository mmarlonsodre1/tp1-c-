using System;

namespace TP1.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            Console.WriteLine("Selecione uma operação:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");

            char operacao = Console.ReadLine().ToCharArray()[0];
            string[] args = new string[2];

            switch (operacao)
            {
                case '1':
                    Numeros(args);
                    TP1.ConsoleApp.Soma.Program.Main(args);
                    MenuPrincipal();
                    break;
                case '2':
                    Numeros(args);
                    TP1.ConsoleApp.Subtracao.Program.Main(args);
                    MenuPrincipal();
                    break;
                case '3':
                    Numeros(args);
                    TP1.ConsoleApp.Multiplicacao.Program.Main(args);
                    MenuPrincipal();
                    break;
                case '4':
                    Numeros(args);
                    TP1.ConsoleApp.Divisao.Program.Main(args);
                    MenuPrincipal();
                    break;
                case '5':
                    Console.WriteLine("Bye");
                    break;
                default:
                    Console.WriteLine("Digite algo válido");
                    MenuPrincipal();
                    break;
            }
        }
        static void Numeros(string[] args)
        {
            Console.WriteLine("Entre com o primeiro número:");
            args[0] = Console.ReadLine();

            Console.WriteLine("Entre com o segundo número:");
            args[1] = Console.ReadLine();

            Console.Clear();
        }

    }
}