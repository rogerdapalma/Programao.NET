namespace Atividade21._03._2025
{
    class Program
    {
        static void Main()
        {
            // 1 - Leitura do Jogo
            var jogo = new Jogo();
            Console.WriteLine("Digite o título do jogo:");
            jogo.Titulo = Console.ReadLine();
            Console.WriteLine("Digite o gênero do jogo:");
            jogo.Genero = Console.ReadLine();
            Console.WriteLine("Digite a plataforma (PC, Xbox, PlayStation):");
            jogo.Plataforma = Console.ReadLine();
            Console.WriteLine("Digite o ano de lançamento:");
            jogo.AnoLancamento = int.Parse(Console.ReadLine());
            Console.WriteLine("===================");
            Console.WriteLine("jogo:");
            Console.WriteLine();
            Console.WriteLine(jogo.Titulo);
            Console.WriteLine();
            Console.WriteLine(jogo.Genero);
            Console.WriteLine();
            Console.WriteLine(jogo.Plataforma);
            Console.WriteLine();
            Console.WriteLine(jogo.AnoLancamento);
            Console.WriteLine("===================");

            // 2 - Leitura do Estúdio
            var estudio = new Estudio();
            Console.WriteLine("Digite o nome do estúdio:");
            estudio.Nome = Console.ReadLine();
            Console.WriteLine("Digite o ano de fundação:");
            estudio.AnoFundacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o país de origem:");
            estudio.PaisOrigem = Console.ReadLine();
            Console.WriteLine("Digite o número de jogos produzidos:");
            estudio.NumeroJogosProduzidos = int.Parse(Console.ReadLine());
            Console.WriteLine("Estudio : {0}, {1}, {2},{3}", estudio.Nome, estudio.AnoFundacao, estudio.PaisOrigem,estudio.NumeroJogosProduzidos);
            // 3 - Leitura de 2 Carros
            var carro1 = new Carro();
            Console.WriteLine("Digite a marca do primeiro carro:");
            carro1.Marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do primeiro carro:");
            carro1.Modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação do primeiro carro:");
            carro1.AnoFabricacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Carro 1: {0}, {1}, {2}", carro1.Marca, carro1.Modelo, carro1.AnoFabricacao);

            var carro2 = new Carro();
            Console.WriteLine("Digite a marca do segundo carro:");
            carro2.Marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do segundo carro:");
            carro2.Modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação do segundo carro:");
            carro2.AnoFabricacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Carro 2: {0}, {1}, {2}", carro2.Marca, carro2.Modelo, carro2.AnoFabricacao);

            // 4 - Instanciando 3 Livros
            Livro[] livros = new Livro[3];
            for (int i = 0; i < 3; i++)
            {
                livros[i] = new Livro();
                Console.WriteLine($"Digite o título do livro {i + 1}:");
                livros[i].Titulo = Console.ReadLine();
                Console.WriteLine($"Digite o autor do livro {i + 1}:");
                livros[i].Autor = Console.ReadLine();
                Console.WriteLine($"Digite o ano de publicação do livro {i + 1}:");
                livros[i].AnoPublicacao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informações dos livros:");
            foreach (var livro in livros)
            {
                Console.WriteLine("Título: {0}, Autor: {1}, Ano: {2}", livro.Titulo, livro.Autor, livro.AnoPublicacao);
            }
        }
    }
}
