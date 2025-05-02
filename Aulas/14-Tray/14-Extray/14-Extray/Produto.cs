using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Extray
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private double _imposto;
       

        public string Nome //somente leitura
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public Double Preco//escrita
        {
            get { return _preco; }
            set { _preco = value; }
        }
        public double Imposto
        {
            get { return _imposto; }
            set { _imposto = value; }
        }
        public double precofinal
        {
            get { return Preco + Imposto; }
        }
    }
}
