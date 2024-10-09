using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Trabalho_de_Laboratório.Models;

using Microsoft.AspNetCore.Mvc;

namespace BertrandLivreiros.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}


