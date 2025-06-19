using System;

namespace MenuEstruturasDados.Estruturas
{
    public static class Matrizes
    {
        static int[,] matrizA = new int[2, 2];
        static int[,] matrizB = new int[2, 2];
        static int[,] resultado = new int[2, 2];

        public static void Menu()
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("=== Matrizes ===");
                Console.WriteLine("1. Preencher matrizes");
                Console.WriteLine("2. Somar matrizes");
                Console.WriteLine("3. Exibir matrizes");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Preencher();
                        break;
                    case "2":
                        Somar();
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

        static void Preencher()
        {
            Console.WriteLine("Matriz A:");
            PreencherMatriz(matrizA);
            Console.WriteLine("Matriz B:");
            PreencherMatriz(matrizB);
        }

        static void PreencherMatriz(int[,] matriz)
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static void Somar()
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    resultado[i, j] = matrizA[i, j] + matrizB[i, j];
            Console.WriteLine("Soma concluída!");
            Console.ReadKey();
        }

        static void Exibir()
        {
            Console.WriteLine("Matriz A:");
            ExibirMatriz(matrizA);
            Console.WriteLine("Matriz B:");
            ExibirMatriz(matrizB);
            Console.WriteLine("Resultado (A+B):");
            ExibirMatriz(resultado);
            Console.ReadKey();
        }

        static void ExibirMatriz(int[,] matriz)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(matriz[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
