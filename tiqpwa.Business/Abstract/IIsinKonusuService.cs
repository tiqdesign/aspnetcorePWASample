using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.Business.Abstract
{
    public interface IIsinKonusuService
    {
        IsinKonusu KonuGetir(short? konuId);
        List<IsinKonusu> KonularıGetir();
    }
}
