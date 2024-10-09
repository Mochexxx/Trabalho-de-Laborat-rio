using Microsoft.AspNetCore.Mvc;

namespace Trabalho_de_Laboratório.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly LibraryContext _context;

        public AdministradorController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(Administrador administrador)
        {
            // Lógica de autenticação
            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard() => View();

        public IActionResult GerirUtilizadores() => View();
    }
}
