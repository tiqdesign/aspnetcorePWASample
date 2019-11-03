using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tiqpwa.Models;

namespace tiqpwa.Controllers
{
    public class GirisController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Kullanici k) {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Kullanıcı_Adı",k.KullaniciAdi.ToUpper());
                return RedirectToAction("Index", "Anasayfa");
            }
            else
                return View();
        }
    }
}