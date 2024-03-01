// See https://aka.ms/new-console-template for more information

using System;

namespace ValorCorreto
    {
        class Program
        {
            static void Main (string[] args)
            {
                Console.WriteLine("Digite um valor entre os números 10 e 20:");
                int numero1 = int.Parse(Console.ReadLine());

                if (numero1 > 20) 
                {
                    Console.WriteLine("Número inválido!");
                    Console.WriteLine("Seu número é maior que 20.");
                }

                else if (numero1 < 10) 
                {
                    Console.WriteLine("Número inválido!");
                    Console.WriteLine("Seu número é menor que 10!");
                }

                else
                {
                    Console.WriteLine($"{numero1} é um número válido!");
                }
            }
        }
    }
