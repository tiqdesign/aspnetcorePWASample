using System;
using System.Collections.Generic;
using System.Linq;
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

        public Kullanici KullaniciGetir(string username, string password)
        {
            return _kullaniciDataAccessLayer.Get(k => k.KullaniciGiris == username && k.KullaniciSifre == password);
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
