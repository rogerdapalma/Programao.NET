namespace SextoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int num;
             Console.WriteLine("verefique se seu numero é divisivel por 2,3,4");
             num = int.Parse(Console.ReadLine());

            if (num % 2 == 0 && num % 3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("divisivel pelo 2,3,4");
            }
            else
            {
                Console.WriteLine("nao divisivel");
            }
            /*
             if(num % 2 ==0)
             {
                 Console.WriteLine("divisivel por 2! ");

             }
             if (num % 4 == 0)
             {
                 Console.WriteLine("divisivel por 4! ");
             }
             if (num % 8 == 0)
             {
                 Console.WriteLine("divisivel por 8! ");
             }
             else
             {
                 Console.WriteLine("nao divisivel por 8 ,4 ,2");
             } */

            
        }
    }
}