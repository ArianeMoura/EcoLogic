using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using app.Models.ViewModels;
using app.Models.Entities;
using app.Database;

namespace app.Controllers
{
    public class PermissoesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public PermissoesController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            var permissoes = await _dbContext.Permissoes
                .Select(p => new PermissaoViewModel
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    CreatedAt = p.CreatedAt,
                    UpdatedAt = p.UpdatedAt
                })
                .ToListAsync();

            return View(permissoes);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PermissaoCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var permissao = new Permissao
                {
                    Nome = viewModel.Nome
                };

                _dbContext.Add(permissao);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var permissao = await _dbContext.Permissoes.FindAsync(id);
            if (permissao == null)
            {
                return NotFound();
            }

            var viewModel = new PermissaoUpdateViewModel
            {
                Id = permissao.Id,
                Nome = permissao.Nome
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, PermissaoUpdateViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var permissao = await _dbContext.Permissoes.FindAsync(id);
                if (permissao == null)
                {
                    return NotFound();
                }

                permissao.Nome = viewModel.Nome;
                permissao.UpdatedAt = DateTime.Now;

                _dbContext.Update(permissao);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            var permissao = await _dbContext.Permissoes.FindAsync(id);
            if (permissao == null)
            {
                return NotFound();
            }

            return View(permissao);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var permissao = await _dbContext.Permissoes.FindAsync(id);
            if (permissao != null)
            {
                _dbContext.Permissoes.Remove(permissao);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
