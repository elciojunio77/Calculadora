using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair ");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Raiz:
                        Raiz();
                        break;
                   case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }      
                
                Console.Clear();

            }

                      
        }

        static void Soma()
        {
            Console.WriteLine("Soma: ");
            Console.WriteLine("Digite o número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a + b;
            Console.WriteLine($"O resultado é:  {resultado}");
            Console.WriteLine("Aperte ENTER para retornar ao menu");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração: ");
            Console.WriteLine("Digite o número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a - b;
            Console.WriteLine($"O resultado é:  {resultado}");
            Console.WriteLine("Aperte ENTER para retornar ao menu");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação: ");
            Console.WriteLine("Digite o número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a * b;
            Console.WriteLine($"O resultado é:  {resultado}");
            Console.WriteLine("Aperte ENTER para retornar ao menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão: ");
            Console.WriteLine("Digite o número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número: ");
            double b = double.Parse(Console.ReadLine());
            double resultado = a / b;
            Console.WriteLine($"O resultado é:  {resultado}");
            Console.WriteLine("Aperte ENTER para retornar ao menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência: ");
            Console.WriteLine("Digite a base: ");
            double baseNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            double expo = double.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é:  {resultado}");
            Console.WriteLine("Aperte ENTER para retornar ao menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz: ");
            Console.WriteLine("Digite o número: ");
            double a = double.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é:  {resultado}");
            Console.WriteLine("Aperte ENTER para retornar ao menu");
            Console.ReadLine();
        }
    }
}
