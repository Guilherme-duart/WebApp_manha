using Microsoft.AspNetCore.Mvc;

namespace WebApp_manha.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult SalvarDados()
        {
            return View();
        }
    }
}
