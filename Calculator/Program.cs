using System;
using Strategy;
namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();// Isto serve para previnir o programa de fechar após executar as instruções.
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Cardápio");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();

            Console.WriteLine("Selecione uma opção:");
            int itemMenuSelected = int.Parse(Console.ReadLine()!);
            OperationContext oc = new OperationContext();

            switch (itemMenuSelected)
            {
                case (1):
                    {
                        oc.Operation = new SumStrategy();
                        break;
                    }
                case (2):
                    {
                        oc.Operation = new SubstractionStrategy();
                        break;
                    }
                case (3):
                    {
                        oc.Operation = new MultiplicationStrategy();
                        break;
                    }
                case (4):
                    {
                       oc.Operation = new DivisionStrategy();
                        break;
                    }
                case (5):
                    {
                        System.Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("O valor introduzido não é válido!");
                        break;
                    }
            }

            Console.WriteLine("Primeiro valor:");
            double v1 = Convert.ToDouble(Console.ReadLine()!);

            Console.WriteLine("Segundo valor:");
            double v2 = double.Parse(Console.ReadLine()!);

            double? result = oc.PerformCalc(v1, v2);

            Console.WriteLine($"O resultado da multiplicação entre {v1} x {v2} é {result}");

            Console.WriteLine("Ir para o menu?");
            Console.ReadLine();
            Menu();
        }
    }

}
