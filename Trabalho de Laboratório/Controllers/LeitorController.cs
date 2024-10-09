using Microsoft.AspNetCore.Mvc;
using Trabalho_de_Laboratório.Models;

namespace Trabalho_de_Laboratório.Controllers
{
    private readonly LibraryContext _context;

    public LeitorController(LibraryContext context)
    {
        _context = context;
    }

    public IActionResult Login() => View();

    [HttpPost]
    public IActionResult Login(Leitor leitor)
    {
        // Lógica de autenticação
        return RedirectToAction("Dashboard");
    }

    public IActionResult Dashboard() => View();

    public IActionResult RequisitarLivro() => View();

    [HttpPost]
    public IActionResult RequisitarLivro(Emprestimo emprestimo)
    {
        // Lógica para requisição de livro
        _context.Emprestimos.Add(emprestimo);
        _context.SaveChanges();
        return RedirectToAction("Dashboard");
    }
}
