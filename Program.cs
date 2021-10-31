using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

        }

        static void Menu()
        {

            // Inicio variável
            int opcao = 0;
            // Fim variável

            Console.Clear();
            Console.WriteLine("Bem vindo a calculadora 1.0");


            Console.WriteLine("*******************************");
            Console.WriteLine("Qual operação deseja realizar? ");
            Console.WriteLine("*******************************");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplição");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("----------------");
            Console.Write("Selecione uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;

                default:
                    Menu();
                    break;
            }


        }
        static void Soma()
        {
            // Inicio Variáveis
            float v1 = 0;
            float v2 = 0;
            float resultado = 0;
            // Fim Varáveis 

            Console.Clear();
            Console.Write("Primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Segundo Valor: ");
            v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            resultado = v1 + v2;

            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado é {resultado}");
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {

            // Inicio Variáveis
            float v1 = 0;
            float v2 = 0;
            float resultado = 0;
            // Fim Varáveis 

            Console.Clear();

            Console.Write("Primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Segundo valor: ");
            v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            resultado = v1 - v2;

            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Console.WriteLine("");
            Menu();

        }
        static void Divisao()
        {
            // Inicio variáveis 
            double v1 = 0;
            double v2 = 0;
            double resultado = 0;
            // Final variáveis

            Console.Clear();

            Console.Write("Primeiro valor: ");
            v1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Segundo valor: ");
            v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Console.WriteLine("");
            Menu();

        }
        static void Multiplicacao()
        {
            // Inicio variáveis 
            double v1 = 0;
            double v2 = 0;
            double resultado = 0;
            // Fim variáveis

            Console.Clear();

            Console.Write("Primeiro valor: ");
            v1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.Write("Segundo valor: ");
            v2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            resultado = v1 * v2;

            Console.Write($"O resultado da multiplicação é {resultado}");
            Console.WriteLine(" ");
            Console.ReadKey();
            Menu();
        }

    }

}
