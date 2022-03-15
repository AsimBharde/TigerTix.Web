using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TigerTix.Web.ViewModels;

namespace TigerTix.Web.Controllers
{
    public class AppController : Controller
    {
        [HttpPost("/")]
        public IActionResult Index(IndexViewModel model)
        {
            return View();
        }
    }
}