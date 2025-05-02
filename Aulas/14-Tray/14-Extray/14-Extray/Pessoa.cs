using System;

namespace _14_Extray
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("idade nao pode ser menor que 0");
                }
                _idade = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("nome nao pode ser vazio ou nulo");
                }
                _nome = value;
            }
        }
    }
}
