using Forms_mz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forms_mz.Controllers
{
    public class DaneController : Controller
    {

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View("Wynik", dane);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Wynik(Dane dane)
        {
            return View(dane);
        }
    }
}
