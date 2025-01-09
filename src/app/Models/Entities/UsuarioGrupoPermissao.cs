using app.Models.Entities;

public class UsuarioGrupoPermissao
{
    public Guid UsuarioId { get; set; }
    public Guid GrupoPermissaoId { get; set; }
    public Usuario Usuario { get; set; }
    public GrupoPermissao GrupoPermissao { get; set; }
}

public class GrupoPermissaoPermissao
{
    public Guid GrupoPermissaoId { get; set; }
    public Guid PermissaoId { get; set; }
    public GrupoPermissao GrupoPermissao { get; set; }
    public Permissao Permissao { get; set; }
}