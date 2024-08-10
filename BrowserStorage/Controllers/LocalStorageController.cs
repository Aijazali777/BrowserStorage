using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserStorage.Controllers
{
    public class LocalStorageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
