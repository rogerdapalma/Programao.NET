﻿

namespace ProjetoTarefasMVC.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }

  

        // Relacionamento
        public List<Tarefa> Tarefas { get; set; } = new();
    }
}
