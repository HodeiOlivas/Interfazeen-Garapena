using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace WebApplication1.Controllers
{
    public class KaixoMunduaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult OngiEtorri(string izena = "Hodei", int zenbat = 1) {

            ViewBag.Mezua = "Hello " + izena;
            ViewBag.Zenbat = zenbat;
            return View();

         //   return HttpUtility.HtmlEncode("Kaixo " + izena + ", zenbat da: " + zenbat);
        
        
        }
    }
}
