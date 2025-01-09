using app.Database;
using app.Models;
using app.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace app.Controllers
{
    public class EstadosController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<EstadosController> _logger;

        public EstadosController(ApplicationDbContext dbContext, ILogger<EstadosController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEstadoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            try
            {
                var estado = new Estado
                {
                    Name = viewModel.Name,
                    Sigla = viewModel.Sigla
                };

                await _dbContext.Estados.AddAsync(estado);
                await _dbContext.SaveChangesAsync();

                TempData["SuccessMessage"] = "Estado adicionado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding new Estado");
                ModelState.AddModelError("", "Ocorreu um erro ao adicionar o Estado. Por favor, tente novamente.");
                return View(viewModel);
            }
        }

        // Método para listar estados
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var estados = await _dbContext.Estados.ToListAsync();
                return View(estados);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Estados");
                return View(new List<Estado>());
            }
        }

        // Método para exibir a página de edição
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var estado = await _dbContext.Estados.FindAsync(id);
            if (estado == null)
            {
                return NotFound();
            }

            var viewModel = new EditEstadoViewModel
            {
                Id = estado.Id,
                Name = estado.Name,
                Sigla = estado.Sigla
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditEstadoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            try
            {
                var estado = await _dbContext.Estados.FindAsync(viewModel.Id);
                if (estado == null)
                {
                    return NotFound();
                }

                estado.Name = viewModel.Name;
                estado.Sigla = viewModel.Sigla;

                _dbContext.Estados.Update(estado);
                await _dbContext.SaveChangesAsync();

                TempData["SuccessMessage"] = "Estado atualizado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating Estado");
                ModelState.AddModelError("", "Ocorreu um erro ao atualizar o Estado. Por favor, tente novamente.");
                return View(viewModel);
            }
        }

        // Método para deletar um estado
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var estado = await _dbContext.Estados.FindAsync(id);
            if (estado == null)
            {
                return NotFound();
            }

            return View(estado);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            try
            {
                var estado = await _dbContext.Estados.FindAsync(id);
                if (estado == null)
                {
                    return NotFound();
                }

                _dbContext.Estados.Remove(estado);
                await _dbContext.SaveChangesAsync();

                TempData["SuccessMessage"] = "Estado excluído com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting Estado");
                TempData["ErrorMessage"] = "Ocorreu um erro ao excluir o Estado. Por favor, tente novamente.";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
