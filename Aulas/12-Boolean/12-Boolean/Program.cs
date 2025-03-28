using System.Security.Cryptography.X509Certificates;

namespace _12_Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lampada l = new lampada(120,"rosa");

            Console.WriteLine("POTENCIA: "+l.potencia+ " " + "COR: " +l.cor);

            l.ligar();
            l.ligar();
            l.ligar();
            l.desligar();
            l.desligar();
            l.desligar();
            l.desligar();

            bool retorno = l.estaligada();
            Console.WriteLine(retorno);
        }
    }
}
