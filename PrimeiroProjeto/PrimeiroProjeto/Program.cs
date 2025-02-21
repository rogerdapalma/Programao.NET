namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             Console.WriteLine("Olá, Mundo");
             int n1,n2,resultado; //variavel

             n1 = 5;
             n2 = 10;

             resultado = n1 + n2;

             Console.WriteLine("N1 + N2 é igual a: "+(n1+n2));
             Console.WriteLine(resultado);
             Console.WriteLine(n1+"+"+n2+"="+(n1+n2));

            Console.WriteLine();

            var dt = new DateTime();
            Console.WriteLine(dt);

            Console.WriteLine("Dia = "+dt.Day);
            Console.WriteLine("Mes = "+dt.Month);
            Console.WriteLine("Ano = "+dt.Year);
            Console.WriteLine("Hora = "+dt.Hour);
            Console.WriteLine("Minutos = "+dt.Minute);
            Console.WriteLine("oque o datatime ta pegando agora");

            Console.WriteLine();

            dt = DateTime.Now;

            Console.WriteLine(dt);
            Console.WriteLine("Dia = " + dt.Day);
            Console.WriteLine("Mes = " + dt.Month);
            Console.WriteLine("Ano = " + dt.Year);
            Console.WriteLine("Hora = " + dt.Hour);
            Console.WriteLine("Minutos = " + dt.Minute);

            Console.WriteLine();


        }
    }
}