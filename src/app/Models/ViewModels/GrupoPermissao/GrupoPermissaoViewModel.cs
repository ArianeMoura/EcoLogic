using Microsoft.AspNetCore.Mvc.Rendering;

namespace app.Models.ViewModels
{
    public class GrupoPermissaoViewModel
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }
        public List<string> PermissoesNomes { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public List<int> PermissoesSelecionadas { get; set; }
        public MultiSelectList PermissoesDisponiveis { get; set; }
    }

    public class GrupoPermissaoCreateViewModel
    {
        public required string Nome { get; set; }
        public List<Guid> PermissoesSelecionadas { get; set; } = new();
        public List<SelectListItem> PermissoesDisponiveis { get; set; } = new();
    }

    public class GrupoPermissaoUpdateViewModel
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }
        public List<Guid> PermissoesSelecionadas { get; set; } = new();
        public List<SelectListItem> PermissoesDisponiveis { get; set; } = new();
    }
}
