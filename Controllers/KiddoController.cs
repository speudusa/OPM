using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OPM.Controllers
{
    public class KiddoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
