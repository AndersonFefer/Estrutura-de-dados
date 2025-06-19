using System;
using System.Collections.Generic;

namespace SistemaClinicoHash
{
    public class Atendimento
    {
        private TabelaHash tabela = new TabelaHash();
        private Queue<Paciente> fila = new Queue<Paciente>();
        private Stack<Paciente> historico = new Stack<Paciente>();

        public void CadastrarPaciente()
        {
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            if (tabela.Buscar(cpf) != null)
            {
                Console.WriteLine("Paciente já cadastrado!");
                return;
            }

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Pressão: ");
            double pressao = double.Parse(Console.ReadLine());

            Console.Write("Temperatura: ");
            double temp = double.Parse(Console.ReadLine());

            Console.Write("Oxigenação: ");
            int o2 = int.Parse(Console.ReadLine());

            Paciente p = new Paciente(cpf, nome, pressao, temp, o2);

            if (tabela.Inserir(p))
            {
                fila.Enqueue(p);
                Console.WriteLine("Paciente cadastrado!");
                p.Mostrar();
            }
            else
            {
                Console.WriteLine("Erro ao inserir.");
            }
        }

        public void BuscarPaciente()
        {
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Paciente p = tabela.Buscar(cpf);
            if (p != null) p.Mostrar();
            else Console.WriteLine("Não encontrado.");
        }

        public void AtualizarPaciente()
        {
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Paciente p = tabela.Buscar(cpf);
            if (p != null)
            {
                Console.Write("Nova Pressão: ");
                double pressao = double.Parse(Console.ReadLine());

                Console.Write("Nova Temperatura: ");
                double temp = double.Parse(Console.ReadLine());

                Console.Write("Nova Oxigenação: ");
                int o2 = int.Parse(Console.ReadLine());

                p.AtualizarDados(pressao, temp, o2);
                Console.WriteLine("Atualizado!");
                p.Mostrar();
            }
            else Console.WriteLine("Não encontrado.");
        }

        public void RemoverPaciente()
        {
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            if (tabela.Remover(cpf)) Console.WriteLine("Removido!");
            else Console.WriteLine("Não encontrado.");
        }

        public void MostrarTabela() => tabela.MostrarTabela();

        public void AtenderPaciente()
        {
            if (fila.Count == 0)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }

            Paciente p = fila.Dequeue();
            historico.Push(p);
            Console.WriteLine("\nAtendendo paciente:");
            p.Mostrar();
        }

        public void MostrarHistorico()
        {
            Console.WriteLine("\n--- Histórico ---");
            foreach (var p in historico) p.Mostrar();
        }

        public void MostrarFila()
        {
            Console.WriteLine("\n--- Fila ---");
            foreach (var p in fila) p.Mostrar();
        }
    }
}
