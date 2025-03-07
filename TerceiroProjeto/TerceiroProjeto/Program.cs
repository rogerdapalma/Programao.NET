namespace TerceiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            double m;
            char c;
            string nome;

            Console.WriteLine("digite um numero ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("numero digitado foi : " + x);

            Console.WriteLine("digite um numero double ");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("numero doble " +m);

            Console.WriteLine("digite um char ");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine("char " + c);

            Console.WriteLine("digite um nome");
            nome= Console.ReadLine();
            Console.WriteLine("nome:" + nome);
        }
    }
}