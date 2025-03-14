namespace SetimoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 ,n2, resultado;
            char op;
            Console.WriteLine("digite o numero 1");
            n1= double.Parse(Console.ReadLine());
            Console.WriteLine("digite o numero2");
            n2= double.Parse(Console.ReadLine());
            Console.WriteLine("operação solicitada ");
            Console.WriteLine("+ para\n- para subtrair");
            Console.WriteLine("x para multiplicar\n/ para dividir");
            op = char.Parse(Console.ReadLine());
            if(op == '+' ) 
            { 
            resultado = n1 + n2;
                Console.WriteLine(n1 + "+" + n2 + "=" + resultado);
            }
            else if (op == '-')
            {
                resultado = n1 - n2;
                Console.WriteLine(n1 + "+" + n2 + "=" + resultado);
            }
            else if (op == 'x')
            {
                resultado = n1 * n2;
                Console.WriteLine(n1 + "+" + n2 + "=" + resultado);
            }
            else if (op == '/')
            {
                resultado = n1 / n2;
                Console.WriteLine(n1 + "+" + n2 + "=" + resultado);
            }
            else
            {
                Console.WriteLine("operação invalida");
            }
        }
    }
}