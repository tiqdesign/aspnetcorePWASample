using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using tiqpwa.Business.Abstract;
using tiqpwa.DataAccess.Abstract;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private IKullaniciDataAccessLayer _kullaniciDataAccessLayer;

        public KullaniciManager(IKullaniciDataAccessLayer kullaniciDataAccessLayer)
        {
            _kullaniciDataAccessLayer = kullaniciDataAccessLayer;
        }
        
        public List<Kullanici> TumKullanicilariGetir()
        {
            return _kullaniciDataAccessLayer.GetList();
        }

        public Kullanici IdyeGoreKullanici(int ID)
        {
            return _kullaniciDataAccessLayer.Get(k=> k.KullaniciID == ID);
        }

        public Kullanici KullaniciGetir(string username, string password)
        {
            return _kullaniciDataAccessLayer.Get(k => k.KullaniciGiris == username && k.KullaniciSifre == password);
        }

        public Kullanici KullaniciSifreGetir(string email, string phone)
        {
            return _kullaniciDataAccessLayer.Get(k => k.KullaniciTelefon == phone && k.KullaniciMail == email);
        }

        public void KullaniciEkle(Kullanici k)
        {
            _kullaniciDataAccessLayer.Add(k);
        }

        public void KullaniciGuncelle(Kullanici k)
        {
            _kullaniciDataAccessLayer.Update(k);
        }

        public void KullaniciSil(Kullanici k)
        {
           _kullaniciDataAccessLayer.Delete(k);
        }
    }
}
