using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_Heranca
{
    abstract class Animal
    {
        public String Nome;
        public abstract void emitirSom(); // metodo abstrado


        public void movimentar() // metodo concreto , pq tem movimentação
        {
            Console.WriteLine("Animal moviemntando...");
        }
        
    }
}
