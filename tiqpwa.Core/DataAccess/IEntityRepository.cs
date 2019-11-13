using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using tiqpwa.Core.Entities;

namespace tiqpwa.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Bu kısmı core un altına koyma nedenimiz burada veritabanına baglı olarak değişmiceği için genel yapı olarak yazdık.

        //burada get işlemi yaparken kullanıcı bir filtreleme yapmak isteyebilir yada istemezse de boş parametre ile gecebilir bu yüzden null a eşitledik.
        T Get(Expression<Func<T,bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
