using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using tiqpwa.Core.Entities;

namespace tiqpwa.Entities.Concrete
{
    public class IsinCinsi:IEntity
    {
        [Key]
        public short CinsID { get; set; }
        public string Aciklama { get; set; }
    }

}
