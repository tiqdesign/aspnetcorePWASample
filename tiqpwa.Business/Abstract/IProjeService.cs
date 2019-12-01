using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Abstract
{
    public interface IProjeService
    {
        List<Proje> TumProjeleriGetir(int KullaniciID);
        List<Proje> ProjeIDyeGoreGetir(Guid ProjeID);
        List<Proje> ProjeleriGetir(int KullaniciID, short projeDurumu);
        Proje ProjeyiGetir(Guid ID, int KullaniciID);
        List<Proje> IlgiliProjeleriGetir(Guid ProjeID , int KullaniciID);
        List<Proje> ProjeleriTarihIleGetir(DateTime tarih, int KullaniciID);
        void ProjeEkle(Proje p);
        void ProjeGuncelle(Proje p);
        void ProjeSil(Proje p);
    }
}
