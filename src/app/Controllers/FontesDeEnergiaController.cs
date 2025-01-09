using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using app.Database;
using app.Models;
using app.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace app.Controllers
{
    public class FontesDeEnergiaController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<FontesDeEnergiaController> _logger;

        public FontesDeEnergiaController(ILogger<FontesDeEnergiaController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var fontes = await _dbContext.FontesDeEnergia.ToListAsync();

            return View(fontes);    
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddFonteDeEnergiaViewModel viewModel)
        {

            var fonte = new FonteDeEnergia
            {
                Tipo = viewModel.Tipo,
                EficienciaMedia = (decimal?)viewModel.EficienciaMedia
            };

            await _dbContext.FontesDeEnergia.AddAsync(fonte);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var fonte = await _dbContext.FontesDeEnergia.FindAsync(id);
            if (fonte == null)
            {
                return NotFound();
            }

            var viewModel = new EditFonteDeEnergiaViewModel
            {
                Id = fonte.Id,
                Tipo = fonte.Tipo,
                EficienciaMedia = fonte.EficienciaMedia
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditFonteDeEnergiaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var fonte = await _dbContext.FontesDeEnergia.FindAsync(viewModel.Id);
                if (fonte == null)
                {
                    return NotFound();
                }

                fonte.Tipo = viewModel.Tipo;
                fonte.EficienciaMedia = viewModel.EficienciaMedia;

                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var fonte = await _dbContext.FontesDeEnergia.FindAsync(id);
            if (fonte == null)
            {
                return NotFound();
            }

            return View(fonte);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var fonte = await _dbContext.FontesDeEnergia.FindAsync(id);
            if (fonte == null)
            {
                return NotFound();
            }

            return View(fonte);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var fonte = await _dbContext.FontesDeEnergia.FindAsync(id);
            if (fonte != null)
            {
                _dbContext.FontesDeEnergia.Remove(fonte);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
