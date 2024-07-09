using Microsoft.AspNetCore.Mvc;

namespace App.Modulos.Produtos.Controllers
{
    [Area("Produtos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhes(int id)
        {
            return View("Index");
        }
    }
}
