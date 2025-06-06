using SiteCarros.Models;

namespace SiteCarros.Services
{
    public class VeiculoService
    {
        private readonly string _caminhoArquivo;
        private readonly string _pastaUploads;

        public VeiculoService(IWebHostEnvironment env)
        {
            var pastaAppData = Path.Combine(env.ContentRootPath, "App_Data");
            Directory.CreateDirectory(pastaAppData);

            _caminhoArquivo = Path.Combine(pastaAppData, "veiculos.txt");
            _pastaUploads = Path.Combine(env.WebRootPath, "uploads");
            Directory.CreateDirectory(_pastaUploads);
        }

        public List<Veiculo> ListarTodos()
        {
            if (!File.Exists(_caminhoArquivo)) return new();

            return File.ReadAllLines(_caminhoArquivo)
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(l => l.Split(';'))
                .Where(p => p.Length >= 6)
                .Select(p => new Veiculo
                {
                    Nome = p[0],
                    Modelo = p[1],
                    Marca = p[2],
                    Renavam = p[3],
                    AnoFabricacao = int.Parse(p[4]),
                    AnoModelo = int.Parse(p[5]),
                    Foto = p.Length > 6 ? p[6] : null
                }).ToList();
        }

        public Veiculo? ObterPorRenavam(string renavam) => ListarTodos().FirstOrDefault(v => v.Renavam == renavam);
        // Adiciona novo veículo ao arquivo
        public void Salvar(Veiculo v) // erro salvando apenas um carro, procurar saber mais 
        {
            if (ObterPorRenavam(v.Renavam) != null) return;
            var linha = FormatarLinha(v);
            File.AppendAllText(_caminhoArquivo, linha + Environment.NewLine);
        }

        public void Editar(Veiculo v)
        {
            var todos = ListarTodos();
            var index = todos.FindIndex(x => x.Renavam == v.Renavam);
            if (index == -1) return;

            todos[index] = v;
            File.WriteAllLines(_caminhoArquivo, todos.Select(FormatarLinha));
        }
        // Remove um veículo do arquivo
        //public void Excluir(string renavam)
        //{
        //    var todos = ListarTodos().Where(x => x.Renavam != renavam).ToList();
        //    File.WriteAllLines(_caminhoArquivo, todos.Select(FormatarLinha));
        //s}

        private string FormatarLinha(Veiculo v)
        {
            return string.Join(";", new[]
            {
                v.Nome,
                v.Modelo,
                v.Marca,
                v.Renavam,
                v.AnoFabricacao.ToString(),
                v.AnoModelo.ToString(),
                v.Foto ?? ""
            });
        }
        // Salva o arquivo da foto no disco e retorna o nome salvo
        public string SalvarFoto(IFormFile? foto) // b.o salvar dois ou mais carros 
        {
            if (foto == null || foto.Length == 0) return "";
            var nomeArquivo = Guid.NewGuid() + Path.GetExtension(foto.FileName);
            var caminho = Path.Combine(_pastaUploads, nomeArquivo);
            using var stream = new FileStream(caminho, FileMode.Create);
            foto.CopyTo(stream);
            return nomeArquivo;
        }
    }
}