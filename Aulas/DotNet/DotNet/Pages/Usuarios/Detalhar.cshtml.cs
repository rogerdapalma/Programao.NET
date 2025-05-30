using DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DotNet.Pages.Usuarios
{
    public class DetalharModel : PageModel
    {
        public Usuario Usuario { get; set; }

        public IActionResult OnGet(int id)
        {
            var usuario = CarregarUsuarios().FirstOrDefault(u => u.Id == id);
            if (usuario == null)
                return RedirectToPage("/Usuarios/Index");

            Usuario = usuario;
            return Page();
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