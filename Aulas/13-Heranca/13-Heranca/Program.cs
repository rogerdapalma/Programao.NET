namespace _13_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando classe abstrata");
            //Animal animal = new Animal(); nao pod eestanciar sendo abstrata
            Cachorro c = new Cachorro();
            c.Nome = "Roberto";
            c.Raca = "Bordeline";
            Console.WriteLine("Cachorro: "+c.Nome);
            Console.WriteLine("Raça: " + c.Raca);
            c.emitirSom();
            c.movimentar();
            Console.WriteLine("================");
            Gato g = new Gato();
            g.Nome = "Juantio";
            g.Raca = "Siames";
            Console.WriteLine("Gato: " + g.Nome);
            Console.WriteLine("Raça: " + g.Raca);
            g.emitirSom();
            g.emitirRonrono();
            g.movimentar();
            Console.WriteLine("================");
            Peixe p = new Peixe();
            p.Nome = "kasa";
            p.raca = "dorado";
            Console.WriteLine("Peixe: " + p.Nome);
            Console.WriteLine("Raça: " + p.raca);
            p.emitirSom();
            p.movimentar();
            Console.WriteLine("================");
        }
    }
}
