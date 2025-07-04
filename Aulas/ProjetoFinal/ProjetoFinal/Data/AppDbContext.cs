using Microsoft.EntityFrameworkCore;
using ProjetoTarefasMVC.Models;

namespace ProjetoTarefasMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
