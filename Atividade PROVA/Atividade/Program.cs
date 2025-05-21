using System;
using System.Collections.Generic;

namespace MenuEstruturasDados
{
    class Program
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
                Console.WriteLine("3. Trabalhar com Lista");
                Console.WriteLine("4. Trabalhar com Fila");
                Console.WriteLine("5. Trabalhar com Pilha");
                Console.WriteLine("6. Algoritmos de Pesquisa");
                Console.WriteLine("0. Encerrar");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

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
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    public class Vetores
    {
        static int[] vetor = new int[10];
        static int contador = 0;

        public static void Menu()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu Vetores ===");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover último");
                Console.WriteLine("3. Exibir elementos");
                Console.WriteLine("4. Buscar elemento");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Inserir(); break;
                    case "2": Remover(); break;
                    case "3": Exibir(); break;
                    case "4": Buscar(); break;
                }
            } while (opcao != "0");
        }

        static void Inserir()
        {
            if (contador < vetor.Length)
            {
                Console.Write("Digite um número: ");
                vetor[contador] = int.Parse(Console.ReadLine());
                contador++;
            }
            else Console.WriteLine("Vetor cheio!");
            Console.ReadKey();
        }

        static void Remover()
        {
            if (contador > 0)
            {
                contador--;
                Console.WriteLine("Elemento removido.");
            }
            else Console.WriteLine("Vetor vazio!");
            Console.ReadKey();
        }

        static void Exibir()
        {
            Console.WriteLine("Elementos:");
            for (int i = 0; i < contador; i++)
                Console.WriteLine(vetor[i]);
            Console.ReadKey();
        }

        static void Buscar()
        {
            Console.Write("Valor a buscar: ");
            int busca = int.Parse(Console.ReadLine());
            bool achou = false;
            for (int i = 0; i < contador; i++)
            {
                if (vetor[i] == busca)
                {
                    Console.WriteLine($"Encontrado na posição {i}");
                    achou = true;
                    break;
                }
            }
            if (!achou) Console.WriteLine("Não encontrado.");
            Console.ReadKey();
        }
    }

    public class Matrizes
    {
        static int[,] matriz = new int[3, 3];

        public static void Menu()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu Matrizes ===");
                Console.WriteLine("1. Preencher matriz");
                Console.WriteLine("2. Exibir matriz");
                Console.WriteLine("3. Buscar valor");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Preencher(); break;
                    case "2": Exibir(); break;
                    case "3": Buscar(); break;
                }
            } while (opcao != "0");
        }

        static void Preencher()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Valor para posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            Console.ReadKey();
        }

        static void Exibir()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(matriz[i, j] + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Buscar()
        {
            Console.Write("Valor a buscar: ");
            int valor = int.Parse(Console.ReadLine());
            bool achou = false;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (matriz[i, j] == valor)
                    {
                        Console.WriteLine($"Encontrado na posição [{i},{j}]");
                        achou = true;
                    }
            if (!achou) Console.WriteLine("Não encontrado.");
            Console.ReadKey();
        }
    }

    public class Lista
    {
        static List<int> lista = new List<int>();

        public static void Menu()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu Lista ===");
                Console.WriteLine("1. Inserir");
                Console.WriteLine("2. Remover");
                Console.WriteLine("3. Exibir");
                Console.WriteLine("4. Buscar");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Número: ");
                        lista.Add(int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        Console.Write("Índice: ");
                        int idx = int.Parse(Console.ReadLine());
                        if (idx >= 0 && idx < lista.Count)
                            lista.RemoveAt(idx);
                        else
                            Console.WriteLine("Índice inválido.");
                        break;
                    case "3":
                        lista.ForEach(x => Console.WriteLine(x));
                        break;
                    case "4":
                        Console.Write("Valor: ");
                        Console.WriteLine(lista.Contains(int.Parse(Console.ReadLine())) ? "Encontrado" : "Não encontrado");
                        break;
                }
                Console.ReadKey();
            } while (opcao != "0");
        }
    }

    public class Fila
    {
        static Queue<int> fila = new Queue<int>();

        public static void Menu()
        {
            string opcao;
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
                        fila.Enqueue(int.Parse(Console.ReadLine()));
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

    public class Pilha
    {
        static Stack<int> pilha = new Stack<int>();

        public static void Menu()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu Pilha ===");
                Console.WriteLine("1. Empilhar");
                Console.WriteLine("2. Desempilhar");
                Console.WriteLine("3. Exibir Pilha");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Número: ");
                        pilha.Push(int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        if (pilha.Count > 0)
                            Console.WriteLine($"Removido: {pilha.Pop()}");
                        else
                            Console.WriteLine("Pilha vazia");
                        break;
                    case "3":
                        foreach (var item in pilha)
                            Console.WriteLine(item);
                        break;
                }
                Console.ReadKey();
            } while (opcao != "0");
        }
    }

    public class Pesquisa
    {
        static int[] dados = { 10, 20, 30, 40, 50 };

        public static void Menu()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== Menu Pesquisa ===");
                Console.WriteLine("1. Busca Linear");
                Console.WriteLine("2. Busca Binária");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": BuscaLinear(); break;
                    case "2": BuscaBinaria(); break;
                }
                Console.ReadKey();
            } while (opcao != "0");
        }

        static void BuscaLinear()
        {
            Console.Write("Valor a buscar: ");
            int valor = int.Parse(Console.ReadLine());
            for (int i = 0; i < dados.Length; i++)
            {
                if (dados[i] == valor)
                {
                    Console.WriteLine($"Encontrado na posição {i}");
                    return;
                }
            }
            Console.WriteLine("Não encontrado.");
        }

        static void BuscaBinaria()
        {
            Console.Write("Valor a buscar: ");
            int valor = int.Parse(Console.ReadLine());
            int inicio = 0, fim = dados.Length - 1;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                if (dados[meio] == valor)
                {
                    Console.WriteLine($"Encontrado na posição {meio}");
                    return;
                }
                else if (valor < dados[meio]) fim = meio - 1;
                else inicio = meio + 1;
            }
            Console.WriteLine("Não encontrado.");
        }
    }
}
