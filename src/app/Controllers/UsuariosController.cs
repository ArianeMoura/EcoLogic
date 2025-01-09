using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using app.Models.ViewModels;
using app.Models.Entities;
using app.Database;

namespace Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public UsuariosController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            var usuarios = await _dbContext.Usuarios
                .Include(u => u.Cliente)
                .Select(u => new UsuarioListViewModel
                {
                    Id = u.Id,
                    Nome = u.Nome,
                    Email = u.Email,
                    ClienteNome = u.Cliente.Nome,
                    CreatedAt = u.CreatedAt
                })
                .ToListAsync();

            return View(usuarios);
        }

        public async Task<IActionResult> Add()
        {
            var viewModel = new UsuarioCreateViewModel
            {
                Clientes = await _dbContext.Clientes
                    .Select(c => new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Nome
                    })
                    .ToListAsync(),
                GruposPermissoes = await _dbContext.GruposPermissoes
                    .Select(g => new SelectListItem
                    {
                        Value = g.Id.ToString(),
                        Text = g.Nome
                    })
                    .ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsuarioCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuario
                {
                    Nome = viewModel.Nome,
                    Email = viewModel.Email,
                    Password = viewModel.Password, // Em produção, deve-se usar hash
                    Cliente = await _dbContext.Clientes.FindAsync(viewModel.ClienteId),
                    GruposPermissoes = await _dbContext.GruposPermissoes
                        .Where(g => viewModel.GrupoPermissaoIds.Contains(g.Id))
                        .ToListAsync()
                };

                _dbContext.Add(usuario);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            viewModel.Clientes = await _dbContext.Clientes
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Nome
                })
                .ToListAsync();

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var usuario = await _dbContext.Usuarios
                .Include(u => u.Cliente)
                .Include(u => u.GruposPermissoes)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (usuario == null)
            {
                return NotFound();
            }

            var viewModel = new UsuarioUpdateViewModel
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                ClienteId = usuario.Cliente.Id,
                GrupoPermissaoIds = usuario.GruposPermissoes.Select(g => g.Id).ToList(),
                GruposPermissoes = await _dbContext.GruposPermissoes
                    .Select(g => new SelectListItem
                    {
                        Value = g.Id.ToString(),
                        Text = g.Nome
                    })
                    .ToListAsync()
            };

            viewModel.Clientes = await _dbContext.Clientes
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Nome
                })
                .ToListAsync();

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, UsuarioUpdateViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var usuario = await _dbContext.Usuarios
                    .Include(u => u.GruposPermissoes)
                    .FirstOrDefaultAsync(u => u.Id == id);

                if (usuario == null)
                {
                    return NotFound();
                }

                usuario.Nome = viewModel.Nome;
                usuario.Email = viewModel.Email;
                usuario.Cliente = await _dbContext.Clientes.FindAsync(viewModel.ClienteId);
                usuario.UpdatedAt = DateTime.Now;
                usuario.GruposPermissoes = await _dbContext.GruposPermissoes
                    .Where(g => viewModel.GrupoPermissaoIds.Contains(g.Id))
                    .ToListAsync();

                try
                {
                    _dbContext.Update(usuario);
                    await _dbContext.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(id))
                    {
                        return NotFound();
                    }
                    throw;
                }
            }

            viewModel.Clientes = await _dbContext.Clientes
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Nome
                })
                .ToListAsync();

            return View(viewModel);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var usuario = await _dbContext.Usuarios
                .Include(u => u.Cliente)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var usuario = await _dbContext.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _dbContext.Usuarios.Remove(usuario);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(Guid id)
        {
            return _dbContext.Usuarios.Any(e => e.Id == id);
        }
    }
}
