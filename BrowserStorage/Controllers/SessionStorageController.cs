using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserStorage.Controllers
{
    public class SessionStorageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
