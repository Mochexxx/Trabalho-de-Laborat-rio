using Microsoft.AspNetCore.Mvc;
using Trabalho_de_Laboratório.Models;

namespace Trabalho_de_Laboratório.Controllers
{
    public class BibliotecarioController : Controller
    {
        private readonly LibraryContext _context;

        public BibliotecarioController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(Bibliotecario bibliotecario)
        {
            // Lógica de autenticação
            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard() => View();

        public IActionResult AdicionarLivro() => View();

        [HttpPost]
        public IActionResult AdicionarLivro(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }

}
