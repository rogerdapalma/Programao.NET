namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            Console.WriteLine("Atribuindo 3 notas para o aluno!");
            n1 = 7.5;
            Console.WriteLine("nota 1 = " + n1);
            n2 = 9.9;
            Console.WriteLine("nota 2 = " + n2);
            n3 = 0.7;
            Console.WriteLine("nota 3 = " + n3);

            Console.WriteLine("calculando media do aluno");
            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("Media do aluno " + media);

            Console.WriteLine("media correta: " + media.ToString("n2"));

            int i;
            i=0;
            Console.WriteLine("i = " + i);
            i = +1;
            Console.WriteLine("i = " + i);
            i++; // i+1 so de 1 em 1 
            Console.WriteLine("i = " + i);
            i += 1; //igual a i++ e igual a i+1
            Console.WriteLine("i = " + i);
            //quero add de dois mais dois
            i += 2;
            Console.WriteLine("i = " + i);
            i = i + 3;
            Console.WriteLine("i = " + i);

            Console.Write("mantendo tudo em uma linha \n\n");
            Console.WriteLine("quebrando linha");
            Console.WriteLine();
            Console.WriteLine("\n");

            Console.WriteLine("segundo projeto c#");
            Console.WriteLine("iniciando, manipulando string");
            string frase = "frase declarada com variavel string";
            String frase2 = "frase declarada com variavel String";
            // concatenando string
            Console.WriteLine("concatenando strings");
            Console.WriteLine("frase 1: "+frase);
            Console.WriteLine("frase 2: "+frase2);
            //interpolação de string
            Console.WriteLine("interpolando string");
            Console.WriteLine($"frase 1 = {frase}");
            Console.WriteLine($"frase 2 = {frase2}");
            Console.WriteLine($"numnero {n1}");

            string  maiuscula = frase.ToUpper();
            Console.WriteLine("frase 1 maiuscula " +maiuscula);
            string minuscula = maiuscula.ToLower();
            Console.WriteLine("frase 1 minuscula = " +minuscula);

            string fraseNova = frase.Replace("frase " , " string");
            Console.WriteLine("frase nova " +fraseNova);
            //concatenar strings
            string novaFrase;
            novaFrase = "estou unindo uma frase na outra\n" + fraseNova;
            Console.WriteLine(novaFrase);

            int numero;
            Console.WriteLine("Digite um valor: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("foi digitado: " + numero);

            double numero2;
            Console.WriteLine("valor com virgula: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digitado: "+numero2);

           
        }
    }
}