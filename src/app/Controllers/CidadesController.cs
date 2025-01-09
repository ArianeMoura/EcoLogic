using app.Database;
using app.Models;
using app.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app.Controllers
{
    public class CidadesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<CidadesController> _logger;

        public CidadesController(ILogger<CidadesController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var cidades = await _dbContext.Cidades.Include(c => c.Estado).ToListAsync();

            return View(cidades);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var estados = await _dbContext.Estados.ToListAsync();
            var viewModel = new AddCidadeViewModel
            {
                Estados = estados
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddCidadeViewModel viewModel)
        {
            _logger.LogInformation("Adicionando cidade: {Name}", viewModel.Name);
            _logger.LogInformation("Estado ID: {EstadoId}", viewModel.EstadoId);

            viewModel.Estados = await _dbContext.Estados.ToListAsync();

            if (!Guid.TryParse(viewModel.EstadoId.ToString(), out Guid estadoGuid))
            {
                _logger.LogWarning("ID do Estado inválido: {EstadoId}", viewModel.EstadoId);
                ModelState.AddModelError("EstadoId", "ID do Estado inválido");
                
                return View(viewModel);
            }

            var estado = await _dbContext.Estados.FindAsync(estadoGuid);

            if (estado != null)
            {
                _logger.LogInformation("Estado encontrado - ID: {Id}, Nome: {Nome}", estado.Id, estado.Name);
            }
            else
            {
                _logger.LogWarning("Estado não encontrado para o ID: {EstadoId}", estadoGuid);
                ModelState.AddModelError("EstadoId", "Estado não encontrado");
                return View(viewModel);
            }

            // if (!ModelState.IsValid)
            // {
            //     _logger.LogWarning("ModelState is invalid. Errors: {Errors}", 
            //         string.Join("; ", ModelState.Values
            //             .SelectMany(v => v.Errors)
            //             .Select(e => e.ErrorMessage)));
                
            //     // Reload the list of estados for the view
                
            //     return View(viewModel);
            // }

            var cidade = new Cidade
            {
                Name = viewModel.Name,
                Estado = estado
            };

            await _dbContext.Cidades.AddAsync(cidade);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
