using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Abstract
{
    public interface IIsinCinsiService
    {
        IsinCinsi CinsiGetir(short? cinsId);
        List<IsinCinsi> CinsleriGetir();
    }
}
