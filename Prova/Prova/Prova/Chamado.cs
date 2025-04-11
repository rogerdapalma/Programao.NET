using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_Heranca
{
    abstract class Chamado
    {
        public String Titulo;
        public String Descricao;
        public String Status;
       


        public void Status() // metodo concreto , pq tem movimentação
        {
          
          Console.WriteLine("Aberto");
            
        }
        public abstract void Executar(); // metodo abstrado

        public void Exibir() 
        {
            return Titulo;
            return Descricao;
        }

    }
}
