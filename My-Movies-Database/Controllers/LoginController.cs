using Microsoft.AspNetCore.Mvc;
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;*/

namespace My_Movies_Database.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(string username, string password)
        {
            return Json(new { });
        }
    }
}
