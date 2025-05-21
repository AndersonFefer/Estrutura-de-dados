using System;
using System.Collections.Generic;

namespace MenuEstruturasDados
{
    public class Fila
    {
        static Queue<int> fila = new Queue<int>();

        public static void Menu()
        {
            string? opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu Fila ===");
                Console.WriteLine("1. Enfileirar");
                Console.WriteLine("2. Desenfileirar");
                Console.WriteLine("3. Exibir Fila");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Número: ");
                        fila.Enqueue(int.Parse(Console.ReadLine() ?? "0"));
                        break;
                    case "2":
                        if (fila.Count > 0)
                            Console.WriteLine($"Removido: {fila.Dequeue()}");
                        else
                            Console.WriteLine("Fila vazia");
                        break;
                    case "3":
                        foreach (var item in fila)
                            Console.WriteLine(item);
                        break;
                }
                Console.ReadKey();
            } while (opcao != "0");
        }
    }
}
