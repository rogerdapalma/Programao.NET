using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Encapsulamento
{
    public class Estudante
    {
        public string Nome { get; set; }
        private double notaFinal;

        public Estudante(string nome, double notaFinal)
        {
            Nome = nome;
            this.notaFinal = notaFinal;
        }

        public string GetNotaFinal()
        {
            return notaFinal >= 70 ? "Aprovado" : "Reprovado";
        }
    }
}