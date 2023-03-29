using Microsoft.AspNetCore.Mvc;

namespace WebApp_manha.Controllers
{
    public class Clientes : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
