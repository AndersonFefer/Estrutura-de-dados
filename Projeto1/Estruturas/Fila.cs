using System;
using System.Collections.Generic;

namespace MenuEstruturasDados.Estruturas
{
    public static class Fila
    {
        static Queue<int> fila = new Queue<int>();

        public static void Menu()
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Fila ===");
                Console.WriteLine("1. Enfileirar");
                Console.WriteLine("2. Desenfileirar");
                Console.WriteLine("3. Exibir fila");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Enfileirar();
                        break;
                    case "2":
                        Desenfileirar();
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

        static void Enfileirar()
        {
            Console.Write("Número: ");
            fila.Enqueue(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enfileirado!");
            Console.ReadKey();
        }

        static void Desenfileirar()
        {
            if (fila.Count > 0)
                Console.WriteLine("Desenfileirado: " + fila.Dequeue());
            else
                Console.WriteLine("Fila vazia!");
            Console.ReadKey();
        }

        static void Exibir()
        {
            Console.WriteLine("Fila:");
            foreach (var item in fila)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
