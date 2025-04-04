using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Heranca
{
    internal class Peixe : Animal
    {
        internal string raca;

        public override void emitirSom()
        {
            Console.WriteLine("*Som de Fritando*");
        }
        public virtual void movimentar()
        {
            Console.WriteLine("peixe esta nadando");
        }
    }
}
