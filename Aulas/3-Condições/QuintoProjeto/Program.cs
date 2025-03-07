namespace QuintoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("positivo");
            }
            else if(num > 0){

                Console.WriteLine("negativo");
            }
            else
            {
                Console.WriteLine("número não-significativo");
            }
        }
    }
}