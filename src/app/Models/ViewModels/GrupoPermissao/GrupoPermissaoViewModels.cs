using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace app.Models.ViewModels.GrupoPermissao
{
    public class GrupoPermissaoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<string> PermissoesNomes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class GrupoPermissaoCreateViewModel
    {
        [Required]
        public string Nome { get; set; }
        public List<Guid> PermissoesSelecionadas { get; set; } = new();
        public IEnumerable<SelectListItem> PermissoesDisponiveis { get; set; }
    }

    public class GrupoPermissaoUpdateViewModel : GrupoPermissaoCreateViewModel
    {
        public Guid Id { get; set; }
    }
} 