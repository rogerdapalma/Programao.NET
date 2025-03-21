namespace _11_AtividadePOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro l = new Livro();
            Console.WriteLine("====================================");
            Console.WriteLine("digite o titulo");
            l.titulo = Console.ReadLine();
            Console.WriteLine("digite o autor");
            l.autor = Console.ReadLine();
            Console.WriteLine("ano de fabricação");
            l.anoPuclibado = int.Parse(Console.ReadLine());

            Console.WriteLine("titulo:"+l.titulo);
            Console.WriteLine("autor:" + l.autor);
            Console.WriteLine("ano de fabricação:" + l.anoPuclibado);
            Console.WriteLine("====================================");
            Livro l2 = new Livro();

            Console.WriteLine("digite o titulo");
            l2.titulo = Console.ReadLine();
            Console.WriteLine("digite o autor");
            l2.autor = Console.ReadLine();
            Console.WriteLine("ano de fabricação");
            l2.anoPuclibado = int.Parse(Console.ReadLine());

            Console.WriteLine("titulo:" + l2.titulo);
            Console.WriteLine("autor:" + l2.autor);
            Console.WriteLine("ano de fabricação:" + l2.anoPuclibado);
            Console.WriteLine("====================================");
            Livro l3 = new Livro();

            Console.WriteLine("digite o titulo");
            l3.titulo = Console.ReadLine();
            Console.WriteLine("digite o autor");
            l3.autor = Console.ReadLine();
            Console.WriteLine("ano de fabricação");
            l3.anoPuclibado = int.Parse(Console.ReadLine());

            Console.WriteLine("titulo:" + l3.titulo);
            Console.WriteLine("autor:" + l3.autor);
            Console.WriteLine("ano de fabricação:" + l3.anoPuclibado);
            Console.WriteLine("====================================");
        }   
    }
}