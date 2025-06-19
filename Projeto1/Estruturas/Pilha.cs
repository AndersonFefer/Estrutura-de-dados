using System;
using System.Collections.Generic;

namespace MenuEstruturasDados.Estruturas
{
    public static class Pilha
    {
        static Stack<int> pilha = new Stack<int>();

        public static void Menu()
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Pilha ===");
                Console.WriteLine("1. Empilhar");
                Console.WriteLine("2. Desempilhar");
                Console.WriteLine("3. Exibir pilha");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Empilhar();
                        break;
                    case "2":
                        Desempilhar();
                        break;
                    case "3":
                        Exibir();
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

        static void Empilhar()
        {
            Console.Write("Número: ");
            pilha.Push(int.Parse(Console.ReadLine()));
            Console.WriteLine("Empilhado!");
            Console.ReadKey();
        }

        static void Desempilhar()
        {
            if (pilha.Count > 0)
                Console.WriteLine("Desempilhado: " + pilha.Pop());
            else
                Console.WriteLine("Pilha vazia!");
            Console.ReadKey();
        }

        static void Exibir()
        {
            Console.WriteLine("Pilha:");
            foreach (var item in pilha)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
