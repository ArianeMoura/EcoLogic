using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

public class GrupoPermissaoViewModel
{
    public Guid Id { get; set; }
    public string Nome { get; set; }

    public List<int> PermissoesSelecionadas { get; set; }
    public MultiSelectList PermissoesDisponiveis { get; set; }
    public List<string> PermissoesNomes { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}