using FixTechMVC.Data;
using FixTechMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace FixTechMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.TotalServicos = _context.Servicos.Count();
            ViewBag.ValorMedio = _context.Servicos.Any() ? _context.Servicos.Average(s => s.Preco) : 0;
            ViewBag.MaiorPreco = _context.Servicos.Any() ? _context.Servicos.Max(s => s.Preco) : 0;
            ViewBag.MenorPreco = _context.Servicos.Any() ? _context.Servicos.Min(s => s.Preco) : 0;

            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return RedirectToAction("Index", "Servicos");
        }

        public IActionResult Contato()
        {
            return View();
        }

        // LOGIN (GET)
        public IActionResult Login()
        {
            return View();
        }

        // LOGIN (POST)
        [HttpPost]
        public IActionResult Login(string usuario, string senha)
        {
            if (usuario == "admin" && senha == "123")
            {
                TempData["Mensagem"] = "Login realizado com sucesso!";
                return RedirectToAction("Index", "Servicos");
            }

            ViewBag.Erro = "Usuário ou senha inválidos.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}