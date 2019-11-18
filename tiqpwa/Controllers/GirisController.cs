using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tiqpwa.Business.Abstract;
using tiqpwa.Entities.Concrete;
using tiqpwa.ExtensionMethods;
using tiqpwa.Models;

namespace tiqpwa.Controllers
{
    public class GirisController : Controller
    {
        private IKullaniciService _kullaniciService;

        public GirisController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Kullanici k)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var kullanici = _kullaniciService.KullaniciGetir(k.KullaniciGiris.ToLower(), k.KullaniciSifre);
                    if (kullanici != null)
                    {
                        HttpContext.Session.SetObject("KullanıcıObjesi", kullanici);
                        return RedirectToAction("Index", "Anasayfa");
                    }
                    return View();
                }
                else
                    return View();
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}