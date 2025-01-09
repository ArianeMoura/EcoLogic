using System.ComponentModel.DataAnnotations;

namespace app.Models
{
    public class AddFonteDeEnergiaViewModel
    {
        [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
        public string Tipo { get; set; }

        [Display(Name = "Eficiência Média")]
        [Range(0, 100, ErrorMessage = "A eficiência média deve estar entre 0 e 100.")]
        public decimal? EficienciaMedia { get; set; }
    }

    public class EditFonteDeEnergiaViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
        public string Tipo { get; set; }

        [Display(Name = "Eficiência Média")]
        [Range(0, 100, ErrorMessage = "A eficiência média deve estar entre 0 e 100.")]
        public decimal? EficienciaMedia { get; set; }
    }
}
