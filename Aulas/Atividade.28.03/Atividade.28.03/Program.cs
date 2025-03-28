namespace Atividade._28._03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa p = new Pessoa();

            Console.WriteLine("Registro:");
            Console.WriteLine("");
            Console.WriteLine("Digite seu nome:");
            p.nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF:");
            p.cpf = Console.ReadLine();
            Console.WriteLine("Digite sua data de nascimento");
            p.datanascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("===================");
            Console.WriteLine("RESULTADO:");
            Console.WriteLine();
            Console.WriteLine(p.nome);
            Console.WriteLine();
            Console.WriteLine(p.cpf);
            Console.WriteLine();
            Console.WriteLine(p.datanascimento);
            Console.WriteLine("===================");
             
        }
    }
}
