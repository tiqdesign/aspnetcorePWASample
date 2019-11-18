using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using tiqpwa.Core.Entities;

namespace tiqpwa.Entities.Concrete
{
    public class IsinKonusu:IEntity
    {
        [Key]
        public short KonuID { get; set; }
        public string Aciklama { get; set; }
    }

}
