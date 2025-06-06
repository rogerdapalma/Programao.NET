using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SiteCarros.Models;
using SiteCarros.Services;

namespace SiteCarros.Pages.Veiculos
{
    public class EditModel : PageModel
    {
        private readonly VeiculoService _service;

        public EditModel(VeiculoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Veiculo Veiculo { get; set; } = new();

        [BindProperty]
        public IFormFile? NovaFoto { get; set; }

        public IActionResult OnGet(string renavam)
        {
            var v = _service.ObterPorRenavam(renavam);
            if (v == null) return NotFound();
            Veiculo = v;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            if (NovaFoto != null)
                Veiculo.Foto = _service.SalvarFoto(NovaFoto);

            _service.Editar(Veiculo);
            return RedirectToPage("Index");
        }
    }
}
