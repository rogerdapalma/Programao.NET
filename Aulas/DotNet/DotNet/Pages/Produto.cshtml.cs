using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNet.Pages
{
    public class ProdutoModel : PageModel
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public List<Produto> Produtos { get; set; }
        public void OnGet()
        {   //logica para requisição get
            Produtos = new List<Produto>
            {
                new Produto { Descricao = "coca",Preco = 8.99m },
                new Produto { Descricao = "pepisi",Preco = 8.39m },
                new Produto { Descricao = "arroz",Preco = 10.99m },
                new Produto { Descricao = "coca",Preco = 8.99m },
                new Produto { Descricao = "agua",Preco = 3.00m },
            };

        }
    


    public class Produto
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        }
    }
}

