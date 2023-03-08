using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

namespace ConsoleTeste
{

    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("---------- CALCULADORA ----------\n");

            Console.Write("Escreva um valor: ");
            int valor = int.Parse(Console.ReadLine().ToString());
            
            Console.Write("Escreva o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine($"\nO primeiro valor é {valor}.\nO segundo valor é {valor2}.");
            
            Console.WriteLine("\n---------- Informe a operação a ser executada ----------\n");

            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");

            Console.Write("\nOperação: ");

            int operacao = int.Parse(Console.ReadLine().ToString());

            double resultadoDaOperacao = 0;

            switch(operacao)
            {
                case 1:
                    resultadoDaOperacao = soma(valor, valor2);
                    break;
                case 2:
                    resultadoDaOperacao = subtracao(valor, valor2);
                    break;
                case 3:
                    resultadoDaOperacao = multiplicacao(valor, valor2);
                    break;
                case 4:
                    resultadoDaOperacao = divisao(valor,valor2);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"\nO resultado da operação é: {resultadoDaOperacao}");
        }

        //Funções com Arrow Function "=>"
        private static double soma(int numero1, int numero2) => numero1 + numero2;

        private static double subtracao(int numero1, int numero2) => numero1 - numero2;

        private static double multiplicacao(int numero1, int numero2) => numero1 * numero2;

        private static double divisao(int numero1, int numero2) => numero1 / numero2;
    }
}