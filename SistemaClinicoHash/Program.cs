using System;

namespace SistemaClinicoHash
{
    class Program
    {
        static void Main()
        {
            Atendimento atendimento = new Atendimento();
            string opcao;

            do
            {
                Console.WriteLine("\n=== Sistema Clínico ===");
                Console.WriteLine("1. Cadastrar Paciente");
                Console.WriteLine("2. Buscar Paciente");
                Console.WriteLine("3. Atualizar Paciente");
                Console.WriteLine("4. Remover Paciente");
                Console.WriteLine("5. Exibir Tabela Hash");
                Console.WriteLine("6. Ver Fila");
                Console.WriteLine("7. Atender Paciente");
                Console.WriteLine("8. Ver Histórico");
                Console.WriteLine("9. Sair");
                Console.Write("Escolha: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": atendimento.CadastrarPaciente(); break;
                    case "2": atendimento.BuscarPaciente(); break;
                    case "3": atendimento.AtualizarPaciente(); break;
                    case "4": atendimento.RemoverPaciente(); break;
                    case "5": atendimento.MostrarTabela(); break;
                    case "6": atendimento.MostrarFila(); break;
                    case "7": atendimento.AtenderPaciente(); break;
                    case "8": atendimento.MostrarHistorico(); break;
                    case "9": Console.WriteLine("Saindo..."); break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }

            } while (opcao != "9");
        }
    }
}
