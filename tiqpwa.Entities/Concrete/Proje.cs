using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using tiqpwa.Core.Entities;

namespace tiqpwa.Entities.Concrete
{
    public class Proje : IEntity
    {
        [Key]
        public Guid ID { get; set; }
        public Guid ProjeID { get; set; }
        public string ProjeAdi { get; set; }
        public int YetkiliID { get; set; }
        public string YetkiliTelefon { get; set; }
        public string Lokasyon { get; set; }
        public DateTime? ProjeTarihi { get; set; }
        public short? IsinKonusu { get; set; }
        public string IsinAciklamasi { get; set; }
        public short IsinCinsi { get; set; }
        public int IlgiliPersonel { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
        public DateTime? IptalTarihi { get; set; }
        public DateTime? BeklemeAlinmaTarihi { get; set; }
        public string BeklemeSebebi { get; set; }
        public string IptalSebebi { get; set; }
        public string ProjeNot { get; set; }
        public string IlaveKullanilanUrun { get; set; }
        public byte[] Gorsel1 { get; set; }
        public byte[] Gorsel2 { get; set; }
        public short? ProjeDurumu { get; set; }
    }

}
