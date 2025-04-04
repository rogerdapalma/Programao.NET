using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Heranca
{
    internal class Gato : Animal
    {
        public String Raca;

        public  void emitirRonrono()
        {
            Console.WriteLine("o gato esta ronronando");
        }

        public override void emitirSom()
        {
            Console.WriteLine("Mial Mial");
        }
    }
}
