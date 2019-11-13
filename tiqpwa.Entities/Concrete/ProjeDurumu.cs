using System;
using System.Collections.Generic;
using System.Text;
using tiqpwa.Core.Entities;

namespace tiqpwa.Entities.Concrete
{
    public class ProjeDurumu: IEntity
    {
        public short DurumID { get; set; }
        public string Aciklama { get; set; }
    }

}
