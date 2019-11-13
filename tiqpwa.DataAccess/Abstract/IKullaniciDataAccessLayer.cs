using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Core.DataAccess;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.DataAccess.Abstract
{
    public interface IKullaniciDataAccessLayer : IEntityRepository<Kullanici>
    {
        //User a ait ekleme silme getirme güncelleme dışında bir fonksiyon yazılacak ise burada yer alacak.
    }
}
