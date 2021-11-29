using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Wedding2.Controllers
{
    public class TravelController : Controller
    {
        // 
        // GET: /Travel/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /Travel/Welcome/ 

        public IActionResult Recommendations()
        {
            return View();
        }
    }
}