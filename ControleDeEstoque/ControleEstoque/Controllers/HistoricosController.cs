using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControleEstoque.Models.Contexto;
using ControleEstoque.Models.Entidades;

namespace ControleEstoque.Controllers
{
    public class HistoricosController : Controller
    {
        private readonly Contexto _context;

        public HistoricosController(Contexto context)
        {
            _context = context;
        }

        // GET: Historicos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Historico.Include(h => h.Produto).Include(h => h.Setor);
            return View(await contexto.ToListAsync());
        }

        // GET: Historicos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historico = await _context.Historico
                .Include(h => h.Produto)
                .Include(h => h.Setor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historico == null)
            {
                return NotFound();
            }

            return View(historico);
        }

        // GET: Historicos/Create
        public IActionResult Create()
        {
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "NomeProduto");
            ViewData["SetorId"] = new SelectList(_context.Setor, "Id", "NomeSetor");
            return View();
        }

        // POST: Historicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SetorId,ProdutoId,Qtd")] Historico historico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(historico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "NomeProduto", historico.ProdutoId);
            ViewData["SetorId"] = new SelectList(_context.Setor, "Id", "NomeSetor", historico.SetorId);
            return View(historico);
        }

        // GET: Historicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historico = await _context.Historico.FindAsync(id);
            if (historico == null)
            {
                return NotFound();
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "NomeProduto", historico.ProdutoId);
            ViewData["SetorId"] = new SelectList(_context.Setor, "Id", "NomeSetor", historico.SetorId);
            return View(historico);
        }

        // POST: Historicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SetorId,ProdutoId,Qtd")] Historico historico)
        {
            if (id != historico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricoExists(historico.Id))
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
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "NomeProduto", historico.ProdutoId);
            ViewData["SetorId"] = new SelectList(_context.Setor, "Id", "NomeSetor", historico.SetorId);
            return View(historico);
        }

        // GET: Historicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historico = await _context.Historico
                .Include(h => h.Produto)
                .Include(h => h.Setor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historico == null)
            {
                return NotFound();
            }

            return View(historico);
        }

        // POST: Historicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historico = await _context.Historico.FindAsync(id);
            _context.Historico.Remove(historico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricoExists(int id)
        {
            return _context.Historico.Any(e => e.Id == id);
        }
    }
}
