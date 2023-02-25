using Ajax.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ajax.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ulkeler = Ulke.Listele();
            return View();
        }

        public IActionResult SehirGetir(int id)
        {
            return Json(Sehir.Listele(id));
        }
    }
}