using System; //Importando o System para termos algumas classes como Console;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();// Isto serve para previnir o programa de fechar após executar as instruções.
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("Cardápio");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine();

            Console.WriteLine("Selecione uma opção:");
            int itemMenuSelected = int.Parse(Console.ReadLine());

            switch(itemMenuSelected){
                case(1):{
                    Soma();
                    break;
                }
                case(2):{
                    Subtracao();
                    break;
                }
                case(3):{
                    Multiplicacao();
                    break;
                }
                case(4):{
                    Divisao();
                    break;
                }
                default: {
                    Console.WriteLine("O valor introduzido não é válido!");
                    break;
                }
            }


        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação entre {v1} x {v2} é {resultado}");

        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão {v1}/{v2} é {resultado}");
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
