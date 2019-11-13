using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Core.Entities;

namespace tiqpwa.Entities.Concrete
{
    public class IsinKonusu:IEntity
    {
        public short KonuID { get; set; }
        public string Aciklama { get; set; }
    }

}
