namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("i vale : " + i);
                if (i == 7) break; 
            }
            Console.WriteLine("-----------------------------------------------");
            for (i = 10; i > 0; i--)
            
                if (i == 5)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("i vale : " + i);
                }
            }


        }
    }
