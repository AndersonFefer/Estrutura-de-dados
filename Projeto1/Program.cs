using System;
using MenuEstruturasDados.Estruturas;
using MenuEstruturasDados.Algoritmos;

namespace MenuEstruturasDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== Menu Estruturas de Dados ===");
                Console.WriteLine("1. Vetores");
                Console.WriteLine("2. Matrizes");
                Console.WriteLine("3. Lista");
                Console.WriteLine("4. Fila");
                Console.WriteLine("5. Pilha");
                Console.WriteLine("6. Algoritmos de Pesquisa");
                Console.WriteLine("0. Encerrar");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine()?.Trim();

                switch (opcao)
                {
                    case "1":
                        Vetores.Menu();
                        break;
                    case "2":
                        Matrizes.Menu();
                        break;
                    case "3":
                        Lista.Menu();
                        break;
                    case "4":
                        Fila.Menu();
                        break;
                    case "5":
                        Pilha.Menu();
                        break;
                    case "6":
                        Pesquisa.Menu();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("\nPrograma encerrado. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
