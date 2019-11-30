using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using tiqpwa.Core.DataAccess;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.DataAccess.Abstract
{
    public interface IProjeDataAccessLayer : IEntityRepository<Proje>
    {
    }
}
