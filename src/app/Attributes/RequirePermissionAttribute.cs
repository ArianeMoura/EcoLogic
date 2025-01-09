using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace app.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RequirePermissionAttribute : Attribute, IAuthorizationFilter
    {
        private readonly string _permissao;

        public RequirePermissionAttribute(string permissao)
        {
            _permissao = permissao;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var temPermissao = context.HttpContext.User.HasClaim("Permissoes", _permissao);
            
            if (!temPermissao)
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
