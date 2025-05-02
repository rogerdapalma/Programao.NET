using System;

namespace _14_Extray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Produto produto = new Produto();

            produto.Nome = "produto 1";
            produto.Preco = 10.50;
            produto.Imposto = 0.7;
            Console.WriteLine("Produto: "+produto.Nome);
            Console.WriteLine("preco: "+produto.Preco);
            Console.WriteLine("precofinal: "+produto.precofinal);


            /*try
            {
                p.Nome = ""; // chamando o setter da propriedade
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção lançada: " + ex.Message);
            }

            // chamando o getter da propriedade
            Console.WriteLine("Nome da pessoa: " + p.Nome);

            try
            {
                p.Idade = -1; // chamando o setter da propriedade
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção lançada: " + ex.Message);
            }

            Console.WriteLine("Idade: " + p.Idade);
            */
            
        }
    }
}
