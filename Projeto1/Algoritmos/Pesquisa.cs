using System;

namespace MenuEstruturasDados.Algoritmos
{
    public static class Pesquisa
    {
        static int[] vetor = { 10, 5, 8, 2, 9, 1 };

        public static void Menu()
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Algoritmos de Pesquisa ===");
                Console.WriteLine("1. Exibir vetor");
                Console.WriteLine("2. Pesquisa Linear");
                Console.WriteLine("3. Pesquisa Binária");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Exibir();
                        break;
                    case "2":
                        Linear();
                        break;
                    case "3":
                        Binaria();
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

        static void Exibir()
        {
            Console.WriteLine("Vetor:");
            foreach (var item in vetor)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Linear()
        {
            Console.Write("Número a buscar: ");
            int num = int.Parse(Console.ReadLine());
            bool achou = false;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == num)
                {
                    Console.WriteLine($"Encontrado na posição {i}");
                    achou = true;
                    break;
                }
            }
            if (!achou) Console.WriteLine("Não encontrado.");
            Console.ReadKey();
        }

        static void Binaria()
        {
            Array.Sort(vetor);
            Console.Write("Número a buscar: ");
            int num = int.Parse(Console.ReadLine());
            int pos = Array.BinarySearch(vetor, num);
            if (pos >= 0)
                Console.WriteLine($"Encontrado na posição {pos}");
            else
                Console.WriteLine("Não encontrado.");
            Console.ReadKey();
        }
    }
}
