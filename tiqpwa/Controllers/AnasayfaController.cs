using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using tiqpwa.Business.Abstract;
using tiqpwa.DataAccess.Abstract;
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
        private IIsinCinsiService _isinCinsiService;
        public static Kullanici kullanici;

        public AnasayfaController(IProjeService projeService, IIsinKonusuService isinKonusuService, IIsinCinsiService isinCinsiService)
        {
            _projeService = projeService;
            _isinKonusuService = isinKonusuService;
            _isinCinsiService = isinCinsiService;
        }

        #region Listelerin Metodları
        public IActionResult DevamEdenListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID, 1);
            var konular = _isinKonusuService.KonularıGetir();
            var DevamEdenListe = new List<ProjeListeViewModel>();

            foreach (var proje in projeler)
            {
                var item = new ProjeListeViewModel()
                {
                    Proje = proje,
                    KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                    Konular = konular
                };
                DevamEdenListe.Add(item);
            }
            return View(DevamEdenListe);
        }

        [HttpGet]
        public IActionResult DevamEdenAyrinti(int id)
        {
            var proje = _projeService.ProjeyiGetir(id);
            var konular = _isinKonusuService.KonularıGetir();
            var item = new ProjeListeViewModel()
            {
                Proje = proje,
                KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                Konular = konular
            };
            return View(item);
        }

        [HttpPost]
        public IActionResult DevamEdenAyrinti(ProjeListeViewModel p)
        {
            try
            {
                _projeService.ProjeGuncelle(p.Proje);
                return RedirectToAction("Index", "Anasayfa");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public IActionResult BeklemeListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID, 2);
            var konular = _isinKonusuService.KonularıGetir();
            var BeklemeListe = new List<ProjeListeViewModel>();

            foreach (var proje in projeler)
            {
                var item = new ProjeListeViewModel()
                {
                    Proje = proje,
                    KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                    Konular = konular
                };
                BeklemeListe.Add(item);
            }
            return View(BeklemeListe);
        }

        [HttpGet]
        public IActionResult BeklemeAyrinti(int id)
        {
            var proje = _projeService.ProjeyiGetir(id);
            var konular = _isinKonusuService.KonularıGetir();
            var item = new ProjeListeViewModel()
            {
                Proje = proje,
                KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                Konular = konular
            };
            return View(item);
        }

        [HttpPost]
        public IActionResult BeklemeAyrinti(ProjeListeViewModel p)
        {
            try
            {
                _projeService.ProjeGuncelle(p.Proje);
                return RedirectToAction("Index", "Anasayfa");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public IActionResult TamamlananListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID, 3);
            var konular = _isinKonusuService.KonularıGetir();
            var TamanlananListe = new List<ProjeListeViewModel>();

            foreach (var proje in projeler)
            {
                var item = new ProjeListeViewModel()
                {
                    Proje = proje,
                    KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                    Konular = konular
                };
                TamanlananListe.Add(item);
            }
            return View(TamanlananListe);
        }

        [HttpGet]
        public IActionResult TamamlanmaAyrinti(int id)
        {
            var proje = _projeService.ProjeyiGetir(id);
            var konular = _isinKonusuService.KonularıGetir();
            var item = new ProjeListeViewModel()
            {
                Proje = proje,
                KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                Konular = konular
            };
            return View(item);
        }

        [HttpPost]
        public IActionResult TamamlanmaAyrinti(ProjeListeViewModel p)
        {
            try
            {
                _projeService.ProjeGuncelle(p.Proje);
                return RedirectToAction("Index", "Anasayfa");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public IActionResult IptalOlanListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID, 4);
            var konular = _isinKonusuService.KonularıGetir();
            var İptalListe = new List<ProjeListeViewModel>();

            foreach (var proje in projeler)
            {
                var item = new ProjeListeViewModel()
                {
                    Proje = proje,
                    KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                    Konular = konular
                };
                İptalListe.Add(item);
            }
            return View(İptalListe);
        }

        [HttpGet]
        public IActionResult IptalOlanAyrinti(int id)
        {
            var proje = _projeService.ProjeyiGetir(id);
            var konular = _isinKonusuService.KonularıGetir();
            var item = new ProjeListeViewModel()
            {
                Proje = proje,
                KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                Konular = konular
            };
            return View(item);
        }

        [HttpPost]
        public IActionResult IptalOlanAyrinti(ProjeListeViewModel p)
        {
            try
            {
                _projeService.ProjeGuncelle(p.Proje);
                return RedirectToAction("Index", "Anasayfa");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public IActionResult Rapor(int id)
        {
            var proje = _projeService.ProjeyiGetir(id);
            var konular = _isinKonusuService.KonularıGetir();
            var item = new ProjeListeViewModel()
            {
                Proje = proje,
                KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                Konular = konular,
                IsinCinsiString  = _isinCinsiService.CinsiGetir(proje.IsinCinsi).Aciklama
            };
            return View(item);
        }

        #endregion


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
      
        [HttpGet]
        public IActionResult YeniBakimKaydi()
        {
            return View();
        }

        public IActionResult BakimTakvim()
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

        //burası suan calısmıyor
        //public ProjeListeViewModel KonuyuDegistir(Proje p)
        //{
        //    var plv = new ProjeListeViewModel()
        //    {
        //        ProjeTarihi = p.ProjeTarihi,
        //        ProjeDurumu = p.ProjeDurumu,
        //        ProjeAdi = p.ProjeAdi,
        //        ProjeID = p.ProjeID,
        //        ProjeNot = p.ProjeNot,
        //        IlgiliPersonel = p.IlgiliPersonel,
        //        IsinKonusu = _isinKonusuService.KonuGetir(p.IsinKonusu).Aciklama,
        //        IsinAciklamasi = p.IsinAciklamasi,
        //        TamamlanmaTarihi = p.TamamlanmaTarihi,
        //        YetkiliID = p.YetkiliID,
        //        YetkiliTelefon = p.YetkiliTelefon,
        //        Lokasyon = p.Lokasyon,
        //        IptalTarihi = p.IptalTarihi,
        //        BeklemeAlinmaTarihi = p.BeklemeAlinmaTarihi,
        //        BeklemeSebebi = p.BeklemeSebebi,
        //        IlaveKullanilanUrun = p.IlaveKullanilanUrun,
        //        IptalSebebi = p.IptalSebebi
        //    };
        //    return plv;
        //}

    }
}