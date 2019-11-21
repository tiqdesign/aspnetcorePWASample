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
            KullaniciGetir();
            return View();
        }

        public IActionResult DevamEdenListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID);
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
            var projeler = _projeService.ProjeleriTarihIleGetir(tarih);
            return View(projeler);
        }
        void KullaniciGetir()
        {
            kullanici = HttpContext.Session.GetObject<Kullanici>("KullanıcıObjesi");
        }
    }
}