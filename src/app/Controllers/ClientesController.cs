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
    public class ClientesController : Controller
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly ApplicationDbContext _dbContext;
        public ClientesController(ILogger<ClientesController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var clientes = await _dbContext.Clientes.ToListAsync();

            return View(clientes);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddClienteViewModel model)
        {
            var cliente = new Cliente
            {
                Nome = model.Nome,
                CpfCnpj = model.CpfCnpj
            };

            await _dbContext.Clientes.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }


        [HttpGet]
        public async Task<IActionResult> Edit([FromRoute] Guid id)
        {
            var cliente = await _dbContext.Clientes.FindAsync(id);


            return View(new EditClienteViewModel { Id = cliente.Id, Nome = cliente.Nome, CpfCnpj = cliente.CpfCnpj });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditClienteViewModel model)
        {
            var cliente = await _dbContext.Clientes.FindAsync(model.Id);

            cliente.Nome = model.Nome;
            cliente.CpfCnpj = model.CpfCnpj;

            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Details([FromRoute] Guid id)
        {
            var cliente = await _dbContext.Clientes.FindAsync(id);


            return View(cliente);
        }

        [HttpGet]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var cliente = await _dbContext.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var cliente = await _dbContext.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _dbContext.Clientes.Remove(cliente);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }


    }


}