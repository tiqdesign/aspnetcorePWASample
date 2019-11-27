using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Business.Abstract;
using tiqpwa.DataAccess.Abstract;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Concrete
{
    public class IsinKonusuManager : IIsinKonusuService
    {
        private IIsinKonusuDataAccessLayer _isinKonusuDataAccessLayer;
        public IsinKonusuManager(IIsinKonusuDataAccessLayer isinKonusuDataAccessLayer)
        {
            _isinKonusuDataAccessLayer = isinKonusuDataAccessLayer;
        }
        public IsinKonusu KonuGetir(short? konuId)
        {
            return _isinKonusuDataAccessLayer.Get(k => k.KonuID == konuId);
        }

        public List<IsinKonusu> KonularıGetir()
        {
            return _isinKonusuDataAccessLayer.GetList();
        }
    }
}
