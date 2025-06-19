using System;
using System.Collections.Generic;

namespace MenuEstruturasDados.Estruturas
{
    public static class Lista
    {
        static List<int> lista = new List<int>();

        public static void Menu()
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Lista ===");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir lista");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Inserir();
                        break;
                    case "2":
                        Remover();
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

        static void Inserir()
        {
            Console.Write("Digite o número: ");
            lista.Add(int.Parse(Console.ReadLine()));
            Console.WriteLine("Inserido!");
            Console.ReadKey();
        }

        static void Remover()
        {
            Console.Write("Número a remover: ");
            int num = int.Parse(Console.ReadLine());
            if (lista.Remove(num))
                Console.WriteLine("Removido!");
            else
                Console.WriteLine("Não encontrado.");
            Console.ReadKey();
        }

        static void Exibir()
        {
            Console.WriteLine("Lista:");
            foreach (var item in lista)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
