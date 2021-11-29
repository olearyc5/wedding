using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding2.Controllers
{
    public class StoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WeddingParty()
        {
            return View();
        }
    }
}
