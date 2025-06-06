using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SiteCarros.Models;
using SiteCarros.Services;

namespace SiteCarros.Pages.Veiculos
{
    public class DetailsModel : PageModel
    {
        private readonly VeiculoService _service;

        public DetailsModel(VeiculoService service)
        {
            _service = service;
        }

        public Veiculo? Veiculo { get; set; }

        public IActionResult OnGet(string renavam)
        {
            Veiculo = _service.ObterPorRenavam(renavam);
            if (Veiculo == null) return NotFound();
            return Page();
        }
    }
}