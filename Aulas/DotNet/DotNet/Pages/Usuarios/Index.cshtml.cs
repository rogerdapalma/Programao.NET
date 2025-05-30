using DotNet.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DotNet.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        public List<Usuario> Usuarios { get; set; } = new();
        public List<string> Avisos { get; set; } = new();

        public void OnGet()
        {
            var ids = new HashSet<int>();
            var emails = new HashSet<string>();

            if (System.IO.File.Exists("usuarios.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("usuarios.txt");
                foreach (var line in linhas)
                {
                    var dados = line.Split(';');
                    if (dados.Length >= 4)
                    {
                        var usuario = new Usuario
                        {
                            Id = int.Parse(dados[0]),
                            Nome = dados[1],
                            Senha = dados[2],
                            Email = dados[3]
                        };

                        Usuarios.Add(usuario);

                        if (!ids.Add(usuario.Id))
                            Avisos.Add($"ID duplicado detectado: {usuario.Id}");

                        if (!emails.Add(usuario.Email))
                            Avisos.Add($"Email duplicado detectado: {usuario.Email}");
                    }
                }
            }
        }
    }
}
