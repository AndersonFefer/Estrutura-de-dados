using System;
using System.Collections.Generic;

// Classe Paciente
class Paciente
{
    public string Nome { get; private set; }
    public double Pressao { get; private set; }
    public double Temperatura { get; private set; }
    public int Oxigenacao { get; private set; }
    public string Prioridade { get; private set; }

    public Paciente(string nome, double pressao, double temperatura, int oxigenacao)
    {
        Nome = nome;
        Pressao = pressao;
        Temperatura = temperatura;
        Oxigenacao = oxigenacao;
        DefinirPrioridade();
    }

    private void DefinirPrioridade()
    {
        if (Pressao > 18 || Temperatura > 39 || Oxigenacao < 90)
            Prioridade = "Vermelha";
        else if (Pressao > 14 || Temperatura > 37.5 || Oxigenacao < 95)
            Prioridade = "Amarela";
        else
            Prioridade = "Verde";
    }

    public void Mostrar()
    {
        Console.WriteLine($"{Nome} - Prioridade: {Prioridade} (PA: {Pressao}, Temp: {Temperatura}, O2: {Oxigenacao}%)");
    }
}

// Classe responsável pela fila e operações
class Atendimento
{
    private List<Paciente> fila = new List<Paciente>();
    private Stack<Paciente> historico = new Stack<Paciente>();

    public void CadastrarPaciente()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Pressão: ");
        double pressao = Convert.ToDouble(Console.ReadLine());

        Console.Write("Temperatura: ");
        double temperatura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Oxigenação: ");
        int oxi = Convert.ToInt32(Console.ReadLine());

        Paciente p = new Paciente(nome, pressao, temperatura, oxi);
        fila.Add(p);

        Console.WriteLine("Paciente cadastrado com prioridade: " + p.Prioridade);
    }

    public void ListarFila()
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("Fila vazia.");
            return;
        }

        Console.WriteLine("\n--- Fila de Pacientes ---");

        foreach (string prioridade in new[] { "Vermelha", "Amarela", "Verde" })
        {
            foreach (Paciente p in fila)
            {
                if (p.Prioridade == prioridade)
                    p.Mostrar();
            }
        }
    }

    public void AtenderPaciente()
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("Nenhum paciente na fila.");
            return;
        }

        Paciente prioridadeAlta = fila[0];
        foreach (Paciente p in fila)
        {
            if (CompararPrioridade(p.Prioridade, prioridadeAlta.Prioridade) < 0)
                prioridadeAlta = p;
        }

        fila.Remove(prioridadeAlta);
        historico.Push(prioridadeAlta);

        Console.WriteLine("\nAtendendo paciente:");
        prioridadeAlta.Mostrar();
    }

    public void MostrarHistorico()
    {
        Console.WriteLine("\n--- Histórico de Atendimentos ---");
        foreach (Paciente p in historico)
        {
            p.Mostrar();
        }
    }

    private int CompararPrioridade(string p1, string p2)
    {
        Dictionary<string, int> ordem = new Dictionary<string, int>
        {
            { "Vermelha", 1 },
            { "Amarela", 2 },
            { "Verde", 3 }
        };

        return ordem[p1].CompareTo(ordem[p2]);
    }
}

// Classe principal
class Program
{
    static void Main()
    {
        Atendimento atendimento = new Atendimento();
        string opcao;

        do
        {
            Console.WriteLine("\n=== Sistema de Atendimento ===");
            Console.WriteLine("1. Cadastrar Paciente");
            Console.WriteLine("2. Ver Fila");
            Console.WriteLine("3. Atender Paciente");
            Console.WriteLine("4. Ver Histórico");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    atendimento.CadastrarPaciente();
                    break;
                case "2":
                    atendimento.ListarFila();
                    break;
                case "3":
                    atendimento.AtenderPaciente();
                    break;
                case "4":
                    atendimento.MostrarHistorico();
                    break;
                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != "5");
    }
}
