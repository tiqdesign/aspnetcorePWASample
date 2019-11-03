using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tiqpwa.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DevamEdenListe()
        {
            return View();
        }

        public IActionResult BeklemeListe()
        {
            return View();
        }
        public IActionResult TamamlananListe()
        {
            return View();
        }
        public IActionResult IptalOlanListe()
        {
            return View();
        }

        public IActionResult Takvim()
        {
            return View();
        }
    }
}