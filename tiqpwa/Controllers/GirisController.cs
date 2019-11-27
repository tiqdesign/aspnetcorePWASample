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
using tiqpwa.ViewModels;

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
            if (HttpContext.Session.GetObject<Kullanici>("KullanıcıObjesi")!= null)
            {
                return RedirectToAction("Index", "Anasayfa");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Index(GirisViewModel k)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var kullanici = _kullaniciService.KullaniciGetir(k.kullanici.KullaniciGiris.ToLower().Trim(), k.kullanici.KullaniciSifre);
                    if (kullanici != null)
                    {
                        HttpContext.Session.SetObject("KullanıcıObjesi", kullanici);
                        return RedirectToAction("Index", "Anasayfa");
                    }
                    else
                    {
                        var hataliGiris = new GirisViewModel()
                        {
                            kullanici = null,
                            hatali = true
                        };
                        return View(hataliGiris);
                    }
                }
                else
                {
                    var hataliGiris = new GirisViewModel()
                    {
                        kullanici = null,
                        hatali = true
                    };
                    return View(hataliGiris);
                }
            }
            catch (Exception)
            {
                var hataliGiris = new GirisViewModel()
                {
                    kullanici = null,
                    hatali = true
                };
                return View(hataliGiris);
            }
        }

        [HttpGet]
        public IActionResult SifreYenileme()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SifreYenileme(SifreYenilemeViewModel k)
        {
            try
            { 
                var kullanici = _kullaniciService.KullaniciSifreGetir(k.Email.Trim().ToLower(), k.Telefon.Trim());
                var kullaniciModel = new SifreYenilemeViewModel()
                {
                    Telefon = kullanici.KullaniciMail,
                    Email = kullanici.KullaniciMail,
                    Sifre = kullanici.KullaniciSifre,
                    KullaniciAdi = kullanici.KullaniciGiris
                };
                return View(kullaniciModel);
            }
            catch (Exception e)
            {
                var kullaniciModel = new SifreYenilemeViewModel()
                {
                    Telefon = null,
                    Email = null,
                    Sifre = "Belirtilen mail ve telefon bilgilerine göre bir hesap bulunamadı!",
                    KullaniciAdi = ""
                };
                return View(kullaniciModel);
            }
          
        }

        [HttpGet]
        public IActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult KayitOl(Kullanici k)
        {
            try
            {
                _kullaniciService.KullaniciEkle(k);
                return RedirectToAction("Index","Giris");
            }
            catch (Exception e)
            {
                return View();
            }
           
        }
    }
}