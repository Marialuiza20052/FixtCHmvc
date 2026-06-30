using Microsoft.AspNetCore.Mvc;
using FixTechMVC.Data;
using FixTechMVC.Models;
using System.Linq;

namespace FixTechMVC.Controllers
{
    public class ServicosController : Controller
    {
        private readonly AppDbContext _context;

        public ServicosController(AppDbContext context)
        {
            _context = context;
        }

        // LISTAR
        public IActionResult Index()
        {
            var servicos = _context.Servicos.ToList();
            return View(servicos);
        }

        // CADASTRAR (GET)
        public IActionResult Create()
        {
            return View();
        }

        // CADASTRAR (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Servico servico)
        {
            if (ModelState.IsValid)
            {
                _context.Servicos.Add(servico);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(servico);
        }

        // DETALHES
        public IActionResult Details(int id)
        {
            var servico = _context.Servicos.Find(id);

            if (servico == null)
            {
                return NotFound();
            }

            return View(servico);
        }

        // EDITAR (GET)
        public IActionResult Edit(int id)
        {
            var servico = _context.Servicos.Find(id);

            if (servico == null)
            {
                return NotFound();
            }

            return View(servico);
        }

        // EDITAR (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Servico servico)
        {
            if (ModelState.IsValid)
            {
                _context.Servicos.Update(servico);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(servico);
        }

        // EXCLUIR (GET)
        public IActionResult Delete(int id)
        {
            var servico = _context.Servicos.Find(id);

            if (servico == null)
            {
                return NotFound();
            }

            return View(servico);
        }

        // EXCLUIR (POST)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var servico = _context.Servicos.Find(id);

            if (servico != null)
            {
                _context.Servicos.Remove(servico);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}