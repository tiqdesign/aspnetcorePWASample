using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Abstract
{
    public interface IProjeService
    {
        List<Proje> TumProjeleriGetir(int KullaniciID);
        List<Proje> ProjeleriGetir(int KullaniciID, short projeDurumu);
        Proje ProjeyiGetir(int ProjeID);
        List<Proje> ProjeleriTarihIleGetir(DateTime tarih);
        void ProjeEkle(Proje p);
        void ProjeGuncelle(Proje p);
        void ProjeSil(Proje p);
    }
}
