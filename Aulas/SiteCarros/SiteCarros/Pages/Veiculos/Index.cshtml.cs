using Microsoft.AspNetCore.Mvc.RazorPages;
using SiteCarros.Models;
using SiteCarros.Services;

namespace SiteCarros.Pages.Veiculos
{
    public class IndexModel : PageModel
    {
        private readonly VeiculoService _service;

        public IndexModel(VeiculoService service)
        {
            _service = service;
        }

        public List<Veiculo> Veiculos { get; set; } = new();

        public void OnGet()
        {
            Veiculos = _service.ListarTodos();
        }
    }
}
