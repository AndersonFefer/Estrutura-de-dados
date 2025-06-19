using System;
using System.Collections.Generic;

namespace MenuEstruturasDados.Estruturas
{
    public static class Vetores
    {
        static int[] vetor = new int[10];
        static int tamanho = 0;

        public static void Menu()
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Vetores ===");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Exibir vetor");
                Console.WriteLine("3. Buscar elemento");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Inserir();
                        break;
                    case "2":
                        Exibir();
                        break;
                    case "3":
                        Buscar();
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida."); Console.ReadKey();
                        break;
                }
            }
        }

        static void Inserir()
        {
            if (tamanho >= vetor.Length)
            {
                Console.WriteLine("Vetor cheio!");
            }
            else
            {
                Console.Write("Digite o número: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    vetor[tamanho++] = num;
                    Console.WriteLine("Inserido!");
                }
            }
            Console.ReadKey();
        }

        static void Exibir()
        {
            Console.WriteLine("Vetor:");
            for (int i = 0; i < tamanho; i++)
                Console.Write(vetor[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Buscar()
        {
            Console.Write("Número a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                bool achou = false;
                for (int i = 0; i < tamanho; i++)
                {
                    if (vetor[i] == num)
                    {
                        Console.WriteLine($"Encontrado na posição {i}.");
                        achou = true;
                        break;
                    }
                }
                if (!achou) Console.WriteLine("Não encontrado.");
            }
            Console.ReadKey();
        }
    }
}
