using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Heranca
{
    internal class Cachorro : Animal
    {
        public String Raca;
        public override void emitirSom()
        {
            Console.WriteLine("rauf rauf");
        }
    }
}
