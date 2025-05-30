using DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DotNet.Pages.Usuarios
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Usuario Usuario { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var usuarios = CarregarUsuarios();
            if (usuarios.Any(u => u.Id == Usuario.Id))
            {
                ModelState.AddModelError("Usuario.Id", "ID já existe. Escolha outro.");
                return Page();
            }

            if (usuarios.Any(u => u.Email == Usuario.Email))
            {
                ModelState.AddModelError("Usuario.Email", "Email já está em uso.");
                return Page();
            }

            using (var writer = new StreamWriter("usuarios.txt", true))
            {
                writer.WriteLine(Usuario.Id + ";" + Usuario.Nome + ";" + Usuario.Senha + ";" + Usuario.Email);
            }

            return RedirectToPage("/Usuarios/Index");
        }

        private List<Usuario> CarregarUsuarios()
        {
            var usuarios = new List<Usuario>();
            if (System.IO.File.Exists("usuarios.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("usuarios.txt");
                foreach (var line in linhas)
                {
                    var dados = line.Split(';');
                    if (dados.Length >= 4)
                    {
                        usuarios.Add(new Usuario
                        {
                            Id = int.Parse(dados[0]),
                            Nome = dados[1],
                            Senha = dados[2],
                            Email = dados[3]
                        });
                    }
                }
            }
            return usuarios;
        }
    }
}
