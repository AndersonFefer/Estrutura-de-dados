using System;

namespace SistemaClinicoHash
{
    public class Paciente
    {
        public string CPF { get; private set; }
        public string Nome { get; private set; }
        public double Pressao { get; private set; }
        public double Temperatura { get; private set; }
        public int Oxigenacao { get; private set; }
        public string Prioridade { get; private set; }

        public Paciente(string cpf, string nome, double pressao, double temperatura, int oxigenacao)
        {
            CPF = cpf;
            Nome = nome;
            Pressao = pressao;
            Temperatura = temperatura;
            Oxigenacao = oxigenacao;
            DefinirPrioridade();
        }

        public void AtualizarDados(double pressao, double temperatura, int oxigenacao)
        {
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
            if (Prioridade == "Vermelha")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (Prioridade == "Amarela")
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine($"{CPF} | {Nome} | PA: {Pressao}, Temp: {Temperatura}, O2: {Oxigenacao}% | Prioridade: {Prioridade}");
            Console.ResetColor();
        }
    }
}
