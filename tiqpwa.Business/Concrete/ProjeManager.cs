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
            return _projeDataAccessLayer.GetList(p => p.IlgiliPersonel == KullaniciID);
        }

        public List<Proje> ProjeIDyeGoreGetir(Guid ProjeID)
        {
            return _projeDataAccessLayer.GetList(p => p.ProjeID == ProjeID);
        }

        public List<Proje> ProjeleriGetir(int KullaniciID, short projeDurumu)
        {
            return _projeDataAccessLayer.GetList(p=> p.IlgiliPersonel == KullaniciID && p.ProjeDurumu == projeDurumu);
        }
        //bu kısımda düzeltilmesi gereken yerler var.
        public Proje ProjeyiGetir(Guid ID, int KullaniciID)
        {
            return _projeDataAccessLayer.Get(p => p.ID == ID && p.IlgiliPersonel == KullaniciID);
        }

        public List<Proje> IlgiliProjeleriGetir(Guid ProjeID, int KullaniciID)
        {
            return _projeDataAccessLayer.GetList(p => p.ProjeID == ProjeID && p.IlgiliPersonel != KullaniciID);
        }

        public List<Proje> ProjeleriTarihIleGetir(DateTime tarih,int KullaniciID)
        {
            return _projeDataAccessLayer.GetList(p => p.ProjeTarihi == tarih && p.IlgiliPersonel == KullaniciID);
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
