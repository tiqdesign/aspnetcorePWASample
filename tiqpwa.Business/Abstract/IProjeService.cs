using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Abstract
{
    public interface IProjeService
    {
        List<Proje> ProjeleriGetir();
        Proje ProjeyiGetir(int KullaniciID, int ProjeID);
        void ProjeEkle(Proje p);
        void ProjeGuncelle(Proje p);
        void ProjeSil(Proje p);
    }
}
