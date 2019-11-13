using System;
using System.Collections.Generic;
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
        public List<Proje> ProjeleriGetir()
        {
            return _projeDataAccessLayer.GetList();
        }
        //bu kısımda düzeltilmesi gereken yerler var.
        public Proje ProjeyiGetir(int KullaniciID, int ProjeID)
        {
            return _projeDataAccessLayer.Get(p => p.ProjeID == ProjeID);
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
