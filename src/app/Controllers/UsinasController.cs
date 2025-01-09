using app.Database;
using app.Models;
using app.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers
{
    [Authorize]
    public class UsinasController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        private readonly ILogger<UsinasController> _logger;

        public UsinasController(ILogger<UsinasController> logger, ApplicationDbContext dbContext )
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var cidades = await _dbContext.Cidades.ToListAsync();
            var clientes = await _dbContext.Clientes.ToListAsync();
            var fontesDeEnergia = await _dbContext.FontesDeEnergia.ToListAsync();

            var viewModel = new AddUsinaViewModel
            {
                Cidades = cidades,
                Clientes = clientes,
                FontesDeEnergia = fontesDeEnergia
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddUsinaViewModel viewModel)
        {
            var cidade = await _dbContext.Cidades.FindAsync(viewModel.CidadeId);
            var cliente = await _dbContext.Clientes.FindAsync(viewModel.ClienteId);
            var fonteDeEnergia = await _dbContext.FontesDeEnergia.FindAsync(viewModel.FonteDeEnergiaId);

            if (cidade == null || cliente == null || fonteDeEnergia == null)
            {
                _logger.LogWarning("Cidade, cliente ou fonte de energia não encontrada para o ID: {CidadeId}, {ClienteId}, {FonteDeEnergiaId}", viewModel.CidadeId, viewModel.ClienteId, viewModel.FonteDeEnergiaId);
                ModelState.AddModelError("", "Cidade, cliente ou fonte de energia não encontrada");
                return View(viewModel);
            }
          

            var usina = new Usina
            {
                Nome = viewModel.Nome,
                Cidade = cidade,
                Cliente = cliente,
                FonteDeEnergia = fonteDeEnergia,
                StatusOperacional = viewModel.StatusOperacional,
                Endereco = viewModel.Endereco,
                DataInicio = viewModel.DataInicio,
                CapacidadeKW = viewModel.CapacidadeKW
            };

            await _dbContext.Usinas.AddAsync(usina);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        
        public async Task<IActionResult> Index()
        {
            var usinas = await _dbContext.Usinas
                .Include(u => u.FonteDeEnergia)
                .Include(u => u.Cliente)
                .ToListAsync();

            return View(usinas);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var cidades = await _dbContext.Cidades.ToListAsync();
            var clientes = await _dbContext.Clientes.ToListAsync();
            var fontesDeEnergia = await _dbContext.FontesDeEnergia.ToListAsync();

            var viewModel = new AddUsinaViewModel
            {
                Cidades = cidades,
                Clientes = clientes,
                FontesDeEnergia = fontesDeEnergia
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var usina = await _dbContext.Usinas
                .Include(u => u.Cidade)
                .Include(u => u.Cliente)
                .Include(u => u.FonteDeEnergia)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (usina == null)
            {
                return NotFound();
            }

            var viewModel = new EditUsinaViewModel
            {
                Id = usina.Id,
                Nome = usina.Nome,
                CapacidadeKW = usina.CapacidadeKW,
                DataInicio = usina.DataInicio,
                StatusOperacional = usina.StatusOperacional,
                Endereco = usina.Endereco,
                CidadeId = usina.Cidade.Id,
                ClienteId = usina.Cliente.Id,
                FonteDeEnergiaId = usina.FonteDeEnergia.Id,
                Cidades = await _dbContext.Cidades.ToListAsync(),
                Clientes = await _dbContext.Clientes.ToListAsync(),
                FontesDeEnergia = await _dbContext.FontesDeEnergia.ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, EditUsinaViewModel viewModel)
        {
            if (viewModel.Id != id)
            {
                return NotFound();
            }

            _logger.LogInformation("Editando usina: {Nome}", viewModel.Id);
            _logger.LogInformation("Cidade ID: {CidadeId}", viewModel.CidadeId);
            _logger.LogInformation("Cliente ID: {ClienteId}", viewModel.ClienteId);
            _logger.LogInformation("Fonte de Energia ID: {FonteDeEnergiaId}", viewModel.FonteDeEnergiaId);

            // Remove these fields from ModelState as they are not part of the form submission
            ModelState.Remove("Cidades");
            ModelState.Remove("Clientes");
            ModelState.Remove("FontesDeEnergia");

            if (ModelState.IsValid)
            {
                try
                {
                    var usina = await _dbContext.Usinas.FindAsync(id);

                    if (usina == null)
                    {
                        return NotFound();
                    }

                    usina.Nome = viewModel.Nome;
                    usina.CapacidadeKW = viewModel.CapacidadeKW;
                    usina.DataInicio = viewModel.DataInicio;
                    usina.StatusOperacional = viewModel.StatusOperacional;
                    usina.Endereco = viewModel.Endereco;
                    usina.Cidade = await _dbContext.Cidades.FindAsync(viewModel.CidadeId);
                    usina.Cliente = await _dbContext.Clientes.FindAsync(viewModel.ClienteId);
                    usina.FonteDeEnergia = await _dbContext.FontesDeEnergia.FindAsync(viewModel.FonteDeEnergiaId);

                    _dbContext.Update(usina);
                    await _dbContext.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await UsinaExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            else
            {
                _logger.LogWarning("ModelState is invalid. Errors: {Errors}", 
                    string.Join("; ", ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)));
            }

            // Populate the dropdown lists regardless of ModelState validity
            viewModel.Cidades = await _dbContext.Cidades.ToListAsync();
            viewModel.Clientes = await _dbContext.Clientes.ToListAsync();
            viewModel.FontesDeEnergia = await _dbContext.FontesDeEnergia.ToListAsync();

            // Return the view with the updated viewModel
            return View(viewModel);
        }

        private async Task<bool> UsinaExists(Guid id)
        {
            return await _dbContext.Usinas.AnyAsync(e => e.Id == id);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var usina = await _dbContext.Usinas
                .Include(u => u.Cidade)
                .Include(u => u.Cliente)
                .Include(u => u.FonteDeEnergia)
                .FirstOrDefaultAsync(u => u.Id == id);

            if (usina == null)
            {
                return NotFound();
            }

            var viewModel = new DeleteUsinaViewModel
            {
                Id = usina.Id,
                Nome = usina.Nome,
                CapacidadeKW = usina.CapacidadeKW,
                DataInicio = usina.DataInicio,
                StatusOperacional = true,
                Endereco = usina.Endereco,
                CidadeNome = usina.Cidade.Name,
                ClienteNome = usina.Cliente.Nome,
                FonteDeEnergiaNome = usina.FonteDeEnergia.Tipo
            };

            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var usina = await _dbContext.Usinas.FindAsync(id);
            if (usina == null)
            {
                return NotFound();
            }

            _dbContext.Usinas.Remove(usina);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
