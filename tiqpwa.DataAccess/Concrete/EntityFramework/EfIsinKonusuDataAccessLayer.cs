using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Core.DataAccess.EntityFramework;
using tiqpwa.DataAccess.Abstract;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.DataAccess.Concrete.EntityFramework
{
    public class EfIsinKonusuDataAccessLayer : EfEntityRepositoryBase<IsinKonusu, tiqdbContext>, IIsinKonusuDataAccessLayer
    {
    }
}
