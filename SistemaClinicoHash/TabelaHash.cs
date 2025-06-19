using System;
using System.Collections.Generic;

namespace SistemaClinicoHash
{
    public class TabelaHash
    {
        private readonly int tamanho;
        private readonly LinkedList<Paciente>[] buckets;

        public TabelaHash(int tamanho = 10)
        {
            this.tamanho = tamanho;
            buckets = new LinkedList<Paciente>[tamanho];
            for (int i = 0; i < tamanho; i++)
                buckets[i] = new LinkedList<Paciente>();
        }

        private int FuncaoHash(string cpf)
        {
            return Math.Abs(cpf.GetHashCode()) % tamanho;
        }

        public bool Inserir(Paciente paciente)
        {
            int pos = FuncaoHash(paciente.CPF);
            foreach (var p in buckets[pos])
            {
                if (p.CPF == paciente.CPF)
                    return false;
            }
            buckets[pos].AddLast(paciente);
            return true;
        }

        public Paciente Buscar(string cpf)
        {
            int pos = FuncaoHash(cpf);
            foreach (var p in buckets[pos])
            {
                if (p.CPF == cpf)
                    return p;
            }
            return null;
        }

        public bool Remover(string cpf)
        {
            int pos = FuncaoHash(cpf);
            var node = buckets[pos].First;
            while (node != null)
            {
                if (node.Value.CPF == cpf)
                {
                    buckets[pos].Remove(node);
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        public void MostrarTabela()
        {
            Console.WriteLine("\n--- Tabela Hash ---");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Bucket [{i}]: ");
                foreach (var p in buckets[i])
                {
                    Console.Write($"[{p.CPF}-{p.Nome}] -> ");
                }
                Console.WriteLine("null");
            }
        }
    }
}
