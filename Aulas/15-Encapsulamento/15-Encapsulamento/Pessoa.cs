using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Encapsulamento
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nome não pode ser nulo ou vazio.");
                nome = value;
            }
        }

        public int Idade
        {
            get => idade;
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException("Idade deve estar entre 0 e 120.");
                idade = value;
            }
        }
    }
}