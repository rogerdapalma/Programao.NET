using System.ComponentModel.DataAnnotations;

namespace SiteCarros.Models
{
    public class Veiculo
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O modelo é obrigatório.")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória.")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O Renavam é obrigatório.")]
        public string Renavam { get; set; }

        [Required(ErrorMessage = "Ano de fabricação é obrigatório.")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Ano do modelo é obrigatório.")]
        public int AnoModelo { get; set; }

        public string? Foto { get; set; }
    }
}