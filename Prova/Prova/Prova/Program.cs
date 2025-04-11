namespace _13_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste Prova");
            ChamadoHardware hardware = new ChamadoHardware();
            ChamadoSoftware software = new ChamadoSoftware();
            Chamado c = new Chamado();
            Console.WriteLine("Digite o titulo");
            c.Titulo = Console.ReadLine();
            Console.WriteLine("Digite a Descrição");
            c.Descricao = Console.ReadLine();

            char op;
            Console.WriteLine("A - Hardware ou   B - Software?");
            op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case 'a':
                    hardware.Executar();
                    Console.WriteLine("Status: " + c.Status);
                    break;
                case 'b':
                    software.Executar();
                    Console.WriteLine("Status: " + c.Status);
                    break;
                default:
                    Console.WriteLine("operação invalida");
                    c.Exibir();
                    break;

            }
        }
    }
}
