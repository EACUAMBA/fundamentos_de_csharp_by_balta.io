using System; //Importando o System para termos algumas classes como Console;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Subtracao();
        }
        static void Subtracao(){
            Console.Clear();
            
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = v1-v2;
            Console.WriteLine($"O resultado da subtração entre {v1} e {v2} é {resultado}");
            Console.ReadKey();// Isto serve para previnir o programa de fechar após executar as instruções.
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma de {v1} e {v2} é {resultado}");// Esta abordagem é chamada de interpolação de Strings, iniciamos uma cadeia de caracteres com o $ (cifrão) e depois podemos utilizar {} (entre chavetas o nome da variável ou uma instrução completa).

        }
    }

}
