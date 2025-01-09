using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using app.Database;
using app.Models.Entities;
using app.Models;

namespace app.Controllers
{
    public class ProducaoDeEnergiaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProducaoDeEnergiaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var producoes = await _context.ProducoesDeEnergia
                .Include(p => p.Usina)
                .ToListAsync();

            return View(producoes);
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producaoDeEnergia = await _context.ProducoesDeEnergia
                .Include(p => p.Usina)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producaoDeEnergia == null)
            {
                return NotFound();
            }

            return View(producaoDeEnergia);
        }

        public IActionResult Add()
        {
            ViewData["Usinas"] = _context.Usinas.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProducaoDeEnergiaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var producaoDeEnergia = new ProducaoDeEnergia
                {
                    Id = Guid.NewGuid(),
                    Usina = await _context.Usinas.FindAsync(viewModel.UsinaId),
                    DataProducao = viewModel.DataProducao,
                    EnergiaGeradaKW = viewModel.EnergiaGeradaKW,
                    EficienciaOperacional = viewModel.EficienciaOperacional,
                    CreatedAt = DateTime.Now
                };

                _context.Add(producaoDeEnergia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Usinas"] = _context.Usinas.ToList();
            return View(viewModel);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producaoDeEnergia = await _context.ProducoesDeEnergia
                .Include(p => p.Usina)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (producaoDeEnergia == null)
            {
                return NotFound();
            }

            var viewModel = new ProducaoDeEnergiaViewModel
            {
                Id = producaoDeEnergia.Id,
                UsinaId = producaoDeEnergia.Usina.Id,
                DataProducao = producaoDeEnergia.DataProducao,
                EnergiaGeradaKW = producaoDeEnergia.EnergiaGeradaKW,
                EficienciaOperacional = producaoDeEnergia.EficienciaOperacional
            };

            ViewData["Usinas"] = _context.Usinas.ToList();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProducaoDeEnergiaViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var producaoDeEnergia = await _context.ProducoesDeEnergia.FindAsync(id);
                    producaoDeEnergia.Usina = await _context.Usinas.FindAsync(viewModel.UsinaId);
                    producaoDeEnergia.DataProducao = viewModel.DataProducao;
                    producaoDeEnergia.EnergiaGeradaKW = viewModel.EnergiaGeradaKW;
                    producaoDeEnergia.EficienciaOperacional = viewModel.EficienciaOperacional;
                    producaoDeEnergia.UpdatedAt = DateTime.Now;

                    _context.Update(producaoDeEnergia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProducaoDeEnergiaExists(viewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Usinas"] = _context.Usinas.ToList();
            return View(viewModel);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producaoDeEnergia = await _context.ProducoesDeEnergia
                .Include(p => p.Usina)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producaoDeEnergia == null)
            {
                return NotFound();
            }

            return View(producaoDeEnergia);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var producaoDeEnergia = await _context.ProducoesDeEnergia.FindAsync(id);
            _context.ProducoesDeEnergia.Remove(producaoDeEnergia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProducaoDeEnergiaExists(Guid id)
        {
            return _context.ProducoesDeEnergia.Any(e => e.Id == id);
        }
    }
}
