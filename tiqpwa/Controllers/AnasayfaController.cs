using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
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
        private IKullaniciService _kullaniciService;
        public static Kullanici kullanici;

        public AnasayfaController(IProjeService projeService, IIsinKonusuService isinKonusuService, IIsinCinsiService isinCinsiService,IKullaniciService kullaniciService)
        {
            _projeService = projeService;
            _isinKonusuService = isinKonusuService;
            _isinCinsiService = isinCinsiService;
            _kullaniciService = kullaniciService;
        }

        #region Listelerin Metodları
        public IActionResult DevamEdenListe()
        {
            var projeler = _projeService.ProjeleriGetir(kullanici.KullaniciID, 1);
            var konular = _isinKonusuService.KonularıGetir();
            var DevamEdenListe = new List<ProjeListeViewModel>();
            

            foreach (var proje in projeler)
            {
                var YetkiliStringListe = new List<string>();
                var liste = _projeService.IlgiliProjeleriGetir(proje.ProjeID, kullanici.KullaniciID);
                foreach (var p in liste)
                {
                    var yetkili = _kullaniciService.IdyeGoreKullanici(p.IlgiliPersonel);
                    YetkiliStringListe.Add(yetkili.KullaniciAdi+" "+ yetkili.KullaniciSoyadi);
                }
                var item = new ProjeListeViewModel()
                {
                    Proje = proje,
                    KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                    Konular = konular,
                    Yetkililer= YetkiliStringListe
                };
                DevamEdenListe.Add(item);
            }
            return View(DevamEdenListe);
        }

        [HttpGet]
        public IActionResult DevamEdenAyrinti(Guid id)
        {
            var proje = _projeService.ProjeyiGetir(id,kullanici.KullaniciID);
            var konular = _isinKonusuService.KonularıGetir();
            var item = new ProjeListeViewModel()
            {
                Proje = proje,
                KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                Konular = konular,
                Kullanicilar = _kullaniciService.TumKullanicilariGetir()
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
                var YetkiliStringListe = new List<string>();
                var liste = _projeService.IlgiliProjeleriGetir(proje.ProjeID, kullanici.KullaniciID);
                foreach (var p in liste)
                {
                    var yetkili = _kullaniciService.IdyeGoreKullanici(p.YetkiliID);
                    YetkiliStringListe.Add(yetkili.KullaniciAdi + " " + yetkili.KullaniciSoyadi);
                }
                var item = new ProjeListeViewModel()
                {
                    Proje = proje,
                    KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                    Konular = konular,
                    Yetkililer = YetkiliStringListe
                };
                BeklemeListe.Add(item);
            }
            return View(BeklemeListe);
        }

        [HttpGet]
        public IActionResult BeklemeAyrinti(Guid id)
        {
            var proje = _projeService.ProjeyiGetir(id, kullanici.KullaniciID);
            var konular = _isinKonusuService.KonularıGetir();
            var item = new ProjeListeViewModel()
            {
                Proje = proje,
                KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                Konular = konular,
                Kullanicilar = _kullaniciService.TumKullanicilariGetir()
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
                //Yetkililerin isimleri ve soyisimlerini tutacak liste.
                var YetkiliStringListe = new List<string>();
                //Projeninin yetkili kişisinin id si ile aynı no ya ait projelerin hepsini getirir.
                var liste = _projeService.IlgiliProjeleriGetir(proje.ProjeID, kullanici.KullaniciID);
                foreach (var p in liste)
                {
                    var yetkili = _kullaniciService.IdyeGoreKullanici(p.YetkiliID);
                    YetkiliStringListe.Add(yetkili.KullaniciAdi + " " + yetkili.KullaniciSoyadi);
                }
                var item = new ProjeListeViewModel()
                {
                    Proje = proje,
                    KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                    Konular = konular,
                    Yetkililer = YetkiliStringListe
                };
                TamanlananListe.Add(item);
            }
            return View(TamanlananListe);
        }

        [HttpGet]
        public IActionResult TamamlanmaAyrinti(Guid id)
        {
            var proje = _projeService.ProjeyiGetir(id, kullanici.KullaniciID);
            var konular = _isinKonusuService.KonularıGetir();
            var item = new ProjeListeViewModel()
            {
                Proje = proje,
                KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                Konular = konular,
                Kullanicilar = _kullaniciService.TumKullanicilariGetir()
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
                var YetkiliStringListe = new List<string>();
                var liste = _projeService.IlgiliProjeleriGetir(proje.ProjeID, kullanici.KullaniciID);
                foreach (var p in liste)
                {
                    var yetkili = _kullaniciService.IdyeGoreKullanici(p.YetkiliID);
                    YetkiliStringListe.Add(yetkili.KullaniciAdi + " " + yetkili.KullaniciSoyadi);
                }
                var item = new ProjeListeViewModel()
                {
                    Proje = proje,
                    KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                    Konular = konular,
                    Yetkililer = YetkiliStringListe
                };
                İptalListe.Add(item);
            }
            return View(İptalListe);
        }

        [HttpGet]
        public IActionResult IptalOlanAyrinti(Guid id)
        {
            var proje = _projeService.ProjeyiGetir(id, kullanici.KullaniciID);
            var konular = _isinKonusuService.KonularıGetir();
            var item = new ProjeListeViewModel()
            {
                Proje = proje,
                KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                Konular = konular,
                Kullanicilar = _kullaniciService.TumKullanicilariGetir()
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

        public IActionResult Rapor(Guid id)
        {
            var proje = _projeService.ProjeyiGetir(id, kullanici.KullaniciID);
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

        public IActionResult ProjeyiTamamla(ProjeListeViewModel p)
        {
            try
            {
                var proje = _projeService.ProjeyiGetir(p.Proje.ProjeID, kullanici.KullaniciID);
                proje.TamamlanmaTarihi = DateTime.Now;
                proje.ProjeDurumu = 3;
                _projeService.ProjeGuncelle(proje);
                return RedirectToAction("Index", "Anasayfa");
            }
            catch (Exception e)
            {
                return RedirectToAction();
            }
        }

        public IActionResult ProjeyiBeklemeyeAl(ProjeListeViewModel p)
        {
            try
            {
                var proje = _projeService.ProjeyiGetir(p.Proje.ProjeID, kullanici.KullaniciID); 
                proje.BeklemeAlinmaTarihi = DateTime.Now;
                proje.BeklemeSebebi = p.Proje.BeklemeSebebi;
                proje.ProjeDurumu = 2;
                _projeService.ProjeGuncelle(proje);
                return RedirectToAction("Index", "Anasayfa");
            }
            catch (Exception e)
            {
                return RedirectToAction();
            }
        }

        public IActionResult ProjeyiIptalEt(ProjeListeViewModel p)
        {
            try
            {
                var proje = _projeService.ProjeyiGetir(p.Proje.ProjeID, kullanici.KullaniciID);
                proje.IptalTarihi = DateTime.Now;
                proje.IptalSebebi = p.Proje.IptalSebebi;
                proje.ProjeDurumu = 4;
                _projeService.ProjeGuncelle(proje);
                return RedirectToAction("Index", "Anasayfa");
            }
            catch (Exception e)
            {
                return RedirectToAction();
            }
        }

        public IActionResult ProjeyiSil(ProjeListeViewModel p)
        {
            try
            {
                var proje = _projeService.ProjeyiGetir(p.Proje.ProjeID, kullanici.KullaniciID);
                proje.ProjeDurumu = 5;
                _projeService.ProjeGuncelle(proje);
                return RedirectToAction("Index", "Anasayfa");
            }
            catch (Exception e)
            {
                return RedirectToAction();
            }
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
            ProjeListeViewModel ykayit = new ProjeListeViewModel()
            {
                Konular = _isinKonusuService.KonularıGetir(),
                Cinsler = _isinCinsiService.CinsleriGetir(),
                Kullanicilar = _kullaniciService.TumKullanicilariGetir()
            };
            return View(ykayit);
        }

        [HttpPost]
        public IActionResult YeniIsKaydi(ProjeListeViewModel p){
            Guid ProjeID = Guid.NewGuid();
            Guid Id = Guid.NewGuid();
            try
            {
                p.Proje.ID = Id;
                p.Proje.ProjeDurumu = 1;
                p.Proje.ProjeID = ProjeID;
                p.Proje.IlgiliPersonel = p.Proje.YetkiliID;
                _projeService.ProjeEkle(p.Proje);
               
                if (p.IlgiliKullanicilar.Count>0)
                {
                    foreach (var k in p.IlgiliKullanicilar)
                    {
                        Guid Id2 = Guid.NewGuid();
                        var kullanici = _kullaniciService.IdyeGoreKullanici(k);
                        p.Proje.ID = Id2;
                        p.Proje.IlgiliPersonel = kullanici.KullaniciID;
                        _projeService.ProjeEkle(p.Proje);
                    }
                }
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
                var projeler = _projeService.ProjeleriTarihIleGetir(tarih,kullanici.KullaniciID);
                var konular = _isinKonusuService.KonularıGetir();
                var TariheGöreListe = new List<ProjeListeViewModel>();
                foreach (var proje in projeler)
                {
                    var YetkiliStringListe = new List<string>();
                    var liste = _projeService.IlgiliProjeleriGetir(proje.ProjeID, kullanici.KullaniciID);
                    foreach (var p in liste)
                    {
                        var yetkili = _kullaniciService.IdyeGoreKullanici(p.YetkiliID);
                        YetkiliStringListe.Add(yetkili.KullaniciAdi + " " + yetkili.KullaniciSoyadi);
                    }
                    var item = new ProjeListeViewModel()
                    {
                        Proje = proje,
                        KonuString = _isinKonusuService.KonuGetir(proje.IsinKonusu).Aciklama,
                        Konular = konular,
                        Yetkililer = YetkiliStringListe
                    };
                    TariheGöreListe.Add(item);
                }
                return View(TariheGöreListe);
            }
            catch (Exception e)
            {
                return View();
            }
            
        }

    }
}