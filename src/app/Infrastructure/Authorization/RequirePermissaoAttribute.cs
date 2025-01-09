using Microsoft.AspNetCore.Authorization;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
public class RequirePermissaoAttribute : AuthorizeAttribute
{
    public RequirePermissaoAttribute(string permissao)
    {
        Policy = permissao;
    }
}
