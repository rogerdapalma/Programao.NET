using DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNet.Pages.Usuarios
{
    public class CriarModel : PageModel
    {
        [BindProperty]

        public Usuario Usuario { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                using (var writer = new StreamWriter("usuarios.txt", true))
                {
                    writer.WriteLine(Usuario.Id + Usuario.Nome + ";" + Usuario.Senha + ";" + Usuario.Email);
                    return RedirectToPage("/Usuarios/Index");
                }
            }
        }
    }
}
