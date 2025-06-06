using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SiteCarros.Models;
using SiteCarros.Services;

namespace SiteCarros.Pages.Veiculos
{
    public class CreateModel : PageModel
    {
        private readonly VeiculoService _service;

        public CreateModel(VeiculoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Veiculo Veiculo { get; set; } = new();

        [BindProperty]
        public IFormFile? Foto { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            Veiculo.Foto = _service.SalvarFoto(Foto);
            _service.Salvar(Veiculo);
            return RedirectToPage("Index");
        }
    }
}