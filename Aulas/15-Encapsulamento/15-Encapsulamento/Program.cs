namespace _15_Encapsulamento
{
    // Program.cs
    public class Program
    {
        public static void Main()
        {
            // Teste da classe Carro
            Carro carro = new Carro("Toyota", "Corolla", 2020);
            Console.WriteLine($"Carro: {carro.Marca} {carro.Modelo}, Ano: {carro.Ano}");

            // Teste da classe ContaBancaria
            ContaBancaria conta = new ContaBancaria("12345", "João", 500);
            conta.Depositar(200);
            conta.Sacar(100);
            conta.ExibirSaldo();

            // Teste da classe Pessoa
            Pessoa pessoa = new Pessoa { Nome = "Maria", Idade = 35 };
            Console.WriteLine($"Pessoa: {pessoa.Nome}, Idade: {pessoa.Idade}");

            // Teste da classe Retangulo
            Retangulo ret = new Retangulo { Largura = 5, Altura = 10 };
            Console.WriteLine($"Área do Retângulo: {ret.Area}");

            // Teste da classe Estudante
            Estudante estudante = new Estudante("Carlos", 82);
            Console.WriteLine($"Estudante: {estudante.Nome}, Resultado: {estudante.GetNotaFinal()}");
        }
    }
}