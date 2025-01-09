using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using app.Models.Entities;
using app.Database;
using app.Models.ViewModels;

namespace app.Controllers
{
    public class GruposPermissoesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public GruposPermissoesController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            var grupos = await _dbContext.GruposPermissoes
                .Include(g => g.Permissoes)
                .Select(g => new app.Models.ViewModels.GrupoPermissaoViewModel
                {
                    Id = g.Id,
                    Nome = g.Nome,
                    PermissoesNomes = g.Permissoes.Select(p => p.Nome).ToList(),
                    CreatedAt = g.CreatedAt,
                    UpdatedAt = g.UpdatedAt
                })
                .ToListAsync();

            return View(grupos);
        }

        public async Task<IActionResult> Add()
        {
            var viewModel = new GrupoPermissaoCreateViewModel
            {
                Nome = "", // Add this line
                PermissoesDisponiveis = await _dbContext.Permissoes
                    .Select(p => new SelectListItem
                    {
                        Value = p.Id.ToString(),
                        Text = p.Nome
                    })
                    .ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GrupoPermissaoCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var permissoes = await _dbContext.Permissoes
                    .Where(p => viewModel.PermissoesSelecionadas.Contains(p.Id))
                    .ToListAsync();

                var grupo = new GrupoPermissao
                {
                    Nome = viewModel.Nome,
                    Permissoes = permissoes
                };

                _dbContext.Add(grupo);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            viewModel.PermissoesDisponiveis = await _dbContext.Permissoes
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Nome
                })
                .ToListAsync();

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var grupo = await _dbContext.GruposPermissoes
                .Include(g => g.Permissoes)
                .FirstOrDefaultAsync(g => g.Id == id);

            if (grupo == null)
            {
                return NotFound();
            }

            var viewModel = new GrupoPermissaoUpdateViewModel
            {
                Id = grupo.Id,
                Nome = grupo.Nome,
                PermissoesSelecionadas = grupo.Permissoes.Select(p => p.Id).ToList(),
                PermissoesDisponiveis = await _dbContext.Permissoes
                    .Select(p => new SelectListItem
                    {
                        Value = p.Id.ToString(),
                        Text = p.Nome
                    })
                    .ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, GrupoPermissaoUpdateViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var grupo = await _dbContext.GruposPermissoes
                    .Include(g => g.Permissoes)
                    .FirstOrDefaultAsync(g => g.Id == id);

                if (grupo == null)
                {
                    return NotFound();
                }

                grupo.Nome = viewModel.Nome;
                grupo.UpdatedAt = DateTime.Now;

                // Atualiza as permissões
                var permissoes = await _dbContext.Permissoes
                    .Where(p => viewModel.PermissoesSelecionadas.Contains(p.Id))
                    .ToListAsync();

                grupo.Permissoes.Clear();
                foreach (var permissao in permissoes)
                {
                    grupo.Permissoes.Add(permissao);
                }

                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            viewModel.PermissoesDisponiveis = await _dbContext.Permissoes
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Nome
                })
                .ToListAsync();

            return View(viewModel);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var grupo = await _dbContext.GruposPermissoes
                .Include(g => g.Permissoes)
                .FirstOrDefaultAsync(g => g.Id == id);

            if (grupo == null)
            {
                return NotFound();
            }

            return View(grupo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var grupo = await _dbContext.GruposPermissoes.FindAsync(id);
            if (grupo != null)
            {
                _dbContext.GruposPermissoes.Remove(grupo);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
