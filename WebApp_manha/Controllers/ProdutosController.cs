using Microsoft.AspNetCore.Mvc;

namespace WebApp_manha.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
