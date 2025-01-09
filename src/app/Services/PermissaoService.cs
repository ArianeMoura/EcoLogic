using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

public class PermissaoService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public PermissaoService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public bool TemPermissao(string permissao)
    {
        var user = _httpContextAccessor.HttpContext?.User;
        if (user == null) return false;
        
        return user.HasClaim("Permissoes", permissao);
    }

    public IEnumerable<string> ObterPermissoes()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        if (user == null) return Enumerable.Empty<string>();

        return user.Claims
            .Where(c => c.Type == "Permissoes")
            .Select(c => c.Value);
    }
}
