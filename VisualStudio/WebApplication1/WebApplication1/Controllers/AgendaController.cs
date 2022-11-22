using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AgendaController : Controller
    {
       // public IActionResult Index()
      //  {
        //    return View();
    //   }
        public ActionResult Details()
        {
            Kontaktua kontaktua = new Kontaktua("1234567", "Hodei", "Olivas");
            kontaktua.Emaila = "olivas.hodei@Uni.eus";
            return View(kontaktua);
            


        }
        public ActionResult Index()
        {
            List<Kontaktua> lstKontaktuak = new List<Kontaktua>();
            Kontaktua kontaktua1 = new Kontaktua("13456765", "izaskun", "Kortabitarte");
            kontaktua1.Emaila = "ikortabitarte@uni.eus";
            lstKontaktuak.Add(kontaktua1);
            Kontaktua kontaktua2 = new Kontaktua("13452345", "pepe", "Fernandez");
            kontaktua2.Emaila = "pfernandez@uni.eus";
            lstKontaktuak.Add(kontaktua2);
            Kontaktua kontaktua3 = new Kontaktua("14567874", "jon", "Perez");
            kontaktua3.Emaila = "jperez@uni.eus";
            lstKontaktuak.Add(kontaktua3);
            return View(lstKontaktuak);
        }

    }
}
