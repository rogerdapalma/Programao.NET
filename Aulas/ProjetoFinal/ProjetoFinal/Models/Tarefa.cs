using ProjetoTarefasMVC.Models;

namespace ProjetoFinal.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }

        public int ProjetoId { get; set; } // fk
        public Projeto? Projeto { get; set; } //
        
    }
}