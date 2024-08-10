using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserStorage.Controllers
{
    public class CookiesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var key = "PhoneNumber";
            ViewBag.PhoneNumber = Request.Cookies[key];
            return View();
        }

        [HttpPost]
        public IActionResult Index(string values)
        {
            var data = JsonConvert.DeserializeObject<IDictionary>(values);
            string key = Convert.ToString(data["Key"]);
            string value = Convert.ToString(data["Value"]);
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(2)
            };
            Response.Cookies.Append(key, value, options);
            return View();
        }
    }
}
