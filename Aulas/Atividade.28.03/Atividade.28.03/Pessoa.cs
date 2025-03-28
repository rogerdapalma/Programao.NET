using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade._28._03
{
    internal class Pessoa
    {
        public string nome;
        public string cpf;
        public DateTime datanascimento;
        
        public Pessoa()
        {
        }

        public Pessoa(string nome, string cpf, DateTime datanascimento)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.datanascimento = datanascimento;
        }

        // Método para cadastro (exemplo simples)
        public void Cadastro()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Data de Nascimento: " + datanascimento);
        }
    }
}