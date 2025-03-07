using System.Linq.Expressions;

namespace QuartoProjeto
{
    using System;
    using System.Globalization;
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double n1, n2;
      
            Console.WriteLine("selecione o numero 1");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("selecione o numero 2");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("resultados da soma: ");
            Console.WriteLine(n1+n2);
            Console.WriteLine("resultados da subtração: ");
            Console.WriteLine(n1 - n2);
            Console.WriteLine("resultados da divisão: ");
            Console.WriteLine(n1 / n2);
            Console.WriteLine("resultados da multiplicação: ");
            Console.WriteLine(n1 * n2);
            /*
            double n1, n2;

            Console.WriteLine("Selecione uma das operações: ");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");

            // Lê a operação escolhida pelo usuário
            string operacao = Console.ReadLine();

            // Verifica se a operação é válida
            if (operacao == "+" || operacao == "-" || operacao == "*" || operacao == "/")
            {
                Console.WriteLine("Selecione o número 1:");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Selecione o número 2:");
                n2 = double.Parse(Console.ReadLine());

                // Agora, usamos o switch para realizar a operação
                switch (operacao)
                {
                    case "+":
                        Console.WriteLine("Resultado da soma: ");
                        Console.WriteLine(n1 + n2);
                        break;
                    case "-":
                        Console.WriteLine("Resultado da subtração: ");
                        Console.WriteLine(n1 - n2);
                        break;
                    case "*":
                        Console.WriteLine("Resultado da multiplicação: ");
                        Console.WriteLine(n1 * n2);
                        break;
                    case "/":
                        if (n2 != 0)
                        {
                            Console.WriteLine("Resultado da divisão: ");
                            Console.WriteLine(n1 / n2);
                        }
                        else
                        {
                            Console.WriteLine("Erro: divisão por zero!");
                        }
                        break;
                    default:
                        Console.WriteLine("Operação desconhecida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Operação inválida! Por favor, escolha uma operação válida.");
            }*/
        }
    }
}