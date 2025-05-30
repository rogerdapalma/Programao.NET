using DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DotNet.Pages.Usuarios
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Usuario Usuario { get; set; }

        public IActionResult OnGet(int id)
        {
            var usuarios = CarregarUsuarios();
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario == null)
                return RedirectToPage("/Usuarios/Index");

            Usuario = usuario;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            var usuarios = CarregarUsuarios();
            var index = usuarios.FindIndex(u => u.Id == Usuario.Id);

            if (usuarios.Any(u => u.Email == Usuario.Email && u.Id != Usuario.Id))
            {
                ModelState.AddModelError("Usuario.Email", "Email já está em uso por outro usuário.");
                return Page();
            }

            if (index != -1)
            {
                usuarios[index] = Usuario;
                SalvarUsuarios(usuarios);
            }

            return RedirectToPage("/Usuarios/Index");
        }

        private List<Usuario> CarregarUsuarios()
        {
            var usuarios = new List<Usuario>();
            if (File.Exists("usuarios.txt"))
            {
                var linhas = File.ReadAllLines("usuarios.txt");
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(';');
                    if (dados.Length >= 4 && int.TryParse(dados[0], out int id))
                    {
                        usuarios.Add(new Usuario
                        {
                            Id = id,
                            Nome = dados[1],
                            Senha = dados[2],
                            Email = dados[3]
                        });
                    }
                }
            }
            return usuarios;
        }

        private void SalvarUsuarios(List<Usuario> usuarios)
        {
            using var writer = new StreamWriter("usuarios.txt", false);
            foreach (var u in usuarios)
            {
                writer.WriteLine($"{u.Id};{u.Nome};{u.Senha};{u.Email}");
            }
        }
    }
}
