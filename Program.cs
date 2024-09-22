using System;
using System.Numerics;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("---------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - DIVISÃO");
            Console.WriteLine("4 - MULTIPLICAÇÃO");
            Console.WriteLine("5 - SAIR");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado de {v1} + {v2} = {resultado}");
            Console.WriteLine("");
            Console.WriteLine($"Obrigado pela utilização: {resultado * 2}");
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 - v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado de {v1} - {v2} é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 / v2;
            float resultado2 = v1 % v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado da divisão {v1} : {v2} é {resultado}");
            Console.WriteLine($"O resto de {v1} % {v2} é {resultado2}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.WriteLine("");
            Console.WriteLine($"O resultado de {v1} x {v2} é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
