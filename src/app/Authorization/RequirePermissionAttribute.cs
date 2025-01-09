using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using app.Services;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
public class RequirePermissionAttribute : TypeFilterAttribute
{
    public RequirePermissionAttribute(string permissionCode) 
        : base(typeof(RequirePermissionFilter))
    {
        Arguments = new object[] { permissionCode };
    }
}

public class RequirePermissionFilter : IAsyncAuthorizationFilter
{
    private readonly string _permissionCode;
    private readonly IAuthorizationService _authorizationService;

    public RequirePermissionFilter(string permissionCode, IAuthorizationService authorizationService)
    {
        _permissionCode = permissionCode;
        _authorizationService = authorizationService;
    }

    public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
    {
        var user = context.HttpContext.User;
        if (!user.Identity?.IsAuthenticated ?? true)
        {
            context.Result = new UnauthorizedResult();
            return;
        }

        var userId = Guid.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty);
        var clienteId = user.FindFirst("ClienteId")?.Value;
        Guid? clienteIdGuid = clienteId != null ? Guid.Parse(clienteId) : null;

        if (!await _authorizationService.UserHasPermissionAsync(userId, _permissionCode, clienteIdGuid))
        {
            context.Result = new ForbidResult();
        }
    }
}
