using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Boolean
{
    internal class lampada
    {
        public bool ligada;
        public double potencia;
        public string cor;

        public lampada(double p,string c)
        {
            potencia = p;
            cor = c;


        }


        public void ligar()
        {
            if (ligada != true)
            {
                ligada = true;
                Console.WriteLine("ligando");
            }
           
        }
        public void desligar()
        {


            if (ligada != false)
            {
                ligada = false;
                Console.WriteLine("desligado");
                
            }
        }

        public bool estaligada()
        {
            return ligada;
        }
    }
}
