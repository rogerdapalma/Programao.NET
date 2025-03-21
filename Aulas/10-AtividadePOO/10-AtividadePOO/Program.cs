namespace _10_AtividadePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            Console.WriteLine("digite o marca do carro");
            c.marca = Console.ReadLine();
            Console.WriteLine("digite o modelo do carro");
            c.modelo = Console.ReadLine();
            Console.WriteLine("digite o ano de fabricação do carro");
            c.anoFabrocacao = int.Parse(Console.ReadLine());

            Console.WriteLine("marca: "+c.marca);
            Console.WriteLine("modelo: "+c.modelo);
            Console.WriteLine("ano de Fabricacao: " +c.anoFabrocacao);

            Carro c1 = new Carro();
            Console.WriteLine("digite o marca do carro");
            c1.marca = Console.ReadLine();
            Console.WriteLine("digite o modelo do carro");
            c1.modelo = Console.ReadLine();
            Console.WriteLine("digite o ano de fabricação do carro");
            c1.anoFabrocacao = int.Parse(Console.ReadLine());

            Console.WriteLine("marca: " + c1.marca);
            Console.WriteLine("modelo: " + c1.modelo);
            Console.WriteLine("ano de Fabricacao: " + c1.anoFabrocacao);
        }
    }
}