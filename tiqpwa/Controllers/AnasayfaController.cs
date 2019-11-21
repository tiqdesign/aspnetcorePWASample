using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using tiqpwa.Business.Abstract;
using tiqpwa.Entities.Concrete;
using tiqpwa.ExtensionMethods;
using tiqpwa.Models;
using tiqpwa.ViewModels;

namespace tiqpwa.Controllers
{
    public class AnasayfaController : Controller
    {
        private IProjeService _projeService;
        private IIsinKonusuService _isinKonusuService;
        public static Kullanici kullanici;

        public AnasayfaController(IProjeService projeService, IIsinKonusuService isinKonusuService)
        {
            _projeService = projeService;
            _isinKonusuService = isinKonusuService;
        }

        public IActionResult Index()
        {
            kullanici = HttpContext.Session.GetObject<Kullanici>("KullanıcıObjesi");
            var projeler = _projeService.TumProjeleriGetir(kullanici.KullaniciID);
            var projeSayilari = new AnasayfaViewModel()
            {
                BeklemeSayi = projeler.Count(p => p.ProjeDurumu == 2),
                DevamEdenSayi = projeler.Count(p => p.ProjeDurumu == 1),
                IptalOlanSayi = projeler.Count(p => p.ProjeDurumu == 4),
                TamamlananSayi = projeler.Count(p => p.ProjeDurumu == 3),
                Tarih = DateTime.Now.Date
            };
            return View(projeSayilari);
        }

        public IActionResult DevamEdenListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID,1);
            var DevamEdenListe = new List<DevamEdenListeViewModel>();

            foreach (var proje in projeler)
            {
                var item = new DevamEdenListeViewModel()
                {
                    ProjeAdi = proje.ProjeAdi,
                    IlgiliPersonel = proje.IlgiliPersonel,
                    Tarih = proje.ProjeTarihi,
                    Konu = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                    ProjeId = proje.ProjeID
                };
                DevamEdenListe.Add(item);
            }
            return View(DevamEdenListe);
        }

        public IActionResult DevamEdenAyrinti(int id)
        {
            var proje = _projeService.ProjeyiGetir(id);
            return View(proje);
        }

        public IActionResult BeklemeListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID, 2);
            return View(projeler);
        }

        public IActionResult BeklemeAyrinti(int id)
        {
            var proje = _projeService.ProjeyiGetir(id);
            return View(proje);
        }

        public IActionResult TamamlananListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID, 3);
            return View(projeler);
        }

        public IActionResult TamamlanmaAyrinti(int id)
        {
            var proje = _projeService.ProjeyiGetir(id);
            return View(proje);
        }

        public IActionResult IptalOlanListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID, 4);
            return View(projeler);
        }

        public IActionResult IptalOlanAyrinti(int id)
        {
            var proje = _projeService.ProjeyiGetir(id);
            return View(proje);
        }

        [HttpGet]
        public IActionResult YeniIsKaydi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniIsKaydi(Proje p){
            try
            {
                //elle verdik kendi artmalı
                p.ProjeID = 6;
                p.ProjeDurumu = 1;
                _projeService.ProjeEkle(p);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public IActionResult CikisYap()
        {
            HttpContext.Session.Remove("KullanıcıObjesi");
            return RedirectToAction("Index","Giris");
        }

        public IActionResult TariheGoreGetir(DateTime tarih)
        {
            try
            {
                var projeler = _projeService.ProjeleriTarihIleGetir(tarih);
                return View(projeler);
            }
            catch (Exception e)
            {
                return View();
            }
            
        }
    }
}