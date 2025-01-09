namespace app.Services
{
    public interface IAuthorizationService
    {
        Task<bool> UserHasPermissionAsync(Guid userId, string permissionCode, Guid? clienteId = null);
    }
}
