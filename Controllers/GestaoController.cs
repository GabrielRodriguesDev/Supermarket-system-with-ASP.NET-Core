using System;
using Microsoft.AspNetCore.Mvc;


namespace Supermarket_system_with_ASP.NET_Core.Controllers
{
    public class GestaoController: Controller
    {
        public IActionResult Index() {
            return View();
        }
    }
}