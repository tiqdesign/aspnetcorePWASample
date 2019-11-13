using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanici> TumKullanicilariGetir();
        Kullanici KullaniciGetir(string username, string password);
        void KullaniciEkle(Kullanici k);
        void KullaniciGuncelle(Kullanici k);
        void KullaniciSil(Kullanici k);

    }
}
