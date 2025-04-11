using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Heranca
{
    internal class ChamadoHardware : Chamado
    {
       
        public override void Executar()
        {
            Console.WriteLine("Em Andamento");
            Console.WriteLine("============");
            Console.WriteLine("Analisando Componentes de hardware...");
        }
    }
}
