using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tiqpwa.Models;

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

        public IActionResult DevamEdenAyrinti(int id)
        {
            //bu id ye göre içeriği getir.
            DevamEden de = new DevamEden();
            de.ID = 2;
            de.Ilgili_Personel = "asdads";
            de.Konu = "asdas";
            de.Proje_Adi = "asdasd";
            de.Tarih = "asdasd";
            
            return View(de);
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
        
        public IActionResult YeniIsKaydi()
        {
            return View();
        }
    }
}