using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Core.DataAccess;
using tiqpwa.Core.DataAccess.EntityFramework;
using tiqpwa.DataAccess.Abstract;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.DataAccess.Concrete.EntityFramework
{
    public class EfProjeDataAccessLayer :EfEntityRepositoryBase<Proje,tiqdbContext>,IProjeDataAccessLayer
    {
    }
}
