using app.Database;
using Microsoft.EntityFrameworkCore;

namespace app.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthorizationService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> UserHasPermissionAsync(Guid userId, string permissionCode, Guid? clienteId = null)
        {
            var usuario = await _dbContext.Usuarios
                .Include(u => u.GruposPermissoes)
                    .ThenInclude(gp => gp.Permissoes)
                .FirstOrDefaultAsync(u => u.Id == userId);

            if (usuario == null)
                return false;

            return usuario.GruposPermissoes
                .SelectMany(gp => gp.Permissoes)
                .Any(p => p.Nome == permissionCode);
        }
    }
}
