﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp_manha.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
