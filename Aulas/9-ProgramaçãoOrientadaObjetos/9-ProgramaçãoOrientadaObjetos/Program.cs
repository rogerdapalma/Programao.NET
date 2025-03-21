namespace _9_ProgramaçãoOrientadaObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("testando classe pessoa: ");
            Pessoa p = new Pessoa();//instanciando objeto

            p.nome = "roger";
            p.email = "roger@gmail.com";
            p.idade = 24;
            Console.WriteLine("Nome: "+ p.nome);
            Console.WriteLine("Email: " + p.email);
            Console.WriteLine("Idade " + p.idade);
            Console.WriteLine("=================");
            Pessoa p2 = new Pessoa();
            p2.nome = "roberto";
            p2.email = "roberto@gmail.com";
            p2.idade = 20;
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Email: " + p2.email);
            Console.WriteLine("Idade " + p2.idade);
            Console.WriteLine("=================");
            Pessoa p3 = new Pessoa();
            Console.WriteLine("Registre os dados da pessoa");
            Console.WriteLine("");
            Console.WriteLine("Nome:" );
            p3.nome = Console.ReadLine();
            Console.WriteLine("Email: ");
            p3.email = Console.ReadLine();
            Console.WriteLine("Idade " );
            p3.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("=================");
            Console.WriteLine("Nome: " + p3.nome);
            Console.WriteLine("Email: " + p3.email);
            Console.WriteLine("Idade " + p3.idade);
            Console.WriteLine("=================");
        }
    }
}