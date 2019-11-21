using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tiqpwa.Business.Abstract;
using tiqpwa.DataAccess.Abstract;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Concrete
{
    public class ProjeManager : IProjeService
    {
        private IProjeDataAccessLayer _projeDataAccessLayer;

        public ProjeManager(IProjeDataAccessLayer projeDataAccessLayer)
        {
            _projeDataAccessLayer = projeDataAccessLayer;
        }

        public List<Proje> TumProjeleriGetir(int KullaniciID)
        {
            return _projeDataAccessLayer.GetList(p => p.YetkiliID == KullaniciID);
        }

        public List<Proje> ProjeleriGetir(int KullaniciID, short projeDurumu)
        {
            return _projeDataAccessLayer.GetList(p=> p.YetkiliID == KullaniciID && p.ProjeDurumu == projeDurumu);
        }
        //bu kısımda düzeltilmesi gereken yerler var.
        public Proje ProjeyiGetir(int ProjeID)
        {
            return _projeDataAccessLayer.Get(p => p.ProjeID == ProjeID);
        }

        public List<Proje> ProjeleriTarihIleGetir(DateTime tarih)
        {
            return _projeDataAccessLayer.GetList(p => p.ProjeTarihi == tarih);
        }

        public void ProjeEkle(Proje p)
        {
           _projeDataAccessLayer.Add(p);
        }

        public void ProjeGuncelle(Proje p)
        {
            _projeDataAccessLayer.Update(p);
        }

        public void ProjeSil(Proje p)
        {
            _projeDataAccessLayer.Delete(p);
        }
    }
}
