using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Business.Abstract;
using tiqpwa.DataAccess.Abstract;
using tiqpwa.DataAccess.Concrete.EntityFramework;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Concrete
{
    public class IsinCinsiManager:IIsinCinsiService
    {
        private IIsinCinsiDataAccessLayer _isinCinsiDataAccessLayer;

        public IsinCinsiManager(IIsinCinsiDataAccessLayer isinCinsiDataAccessLayer)
        {
            _isinCinsiDataAccessLayer = isinCinsiDataAccessLayer;
        }
        public IsinCinsi CinsiGetir(short? cinsId)
        {
            return _isinCinsiDataAccessLayer.Get(c=> c.CinsID == cinsId);
        }

        public List<IsinCinsi> CinsleriGetir()
        {
            return _isinCinsiDataAccessLayer.GetList();
        }
    }
}
