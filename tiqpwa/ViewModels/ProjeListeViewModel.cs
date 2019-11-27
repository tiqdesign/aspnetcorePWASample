using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.ViewModels
{
    public class ProjeListeViewModel
    {
        //public int ProjeID { get; set; }
        //public string? ProjeAdi { get; set; }
        //public int? YetkiliID { get; set; }
        //public string? YetkiliTelefon { get; set; }
        //public string? Lokasyon { get; set; }
        //public DateTime? ProjeTarihi { get; set; }
        //public string? IsinKonusu { get; set; }
        //public string? IsinAciklamasi { get; set; }
        //public string? IsinCinsi { get; set; }
        //public string? IlgiliPersonel { get; set; }
        //public DateTime? TamamlanmaTarihi { get; set; }
        //public DateTime? IptalTarihi { get; set; }
        //public DateTime? BeklemeAlinmaTarihi { get; set; }
        //public string? BeklemeSebebi { get; set; }
        //public string? IptalSebebi { get; set; }
        //public string? ProjeNot { get; set; }
        //public string? IlaveKullanilanUrun { get; set; }
        //public byte[]? Gorsel1 { get; set; }
        //public byte[]? Gorsel2 { get; set; }
        //public short? ProjeDurumu { get; set; }

        public Proje Proje { get; set; }
        public string KonuString { get; set; }
        public List<IsinKonusu> Konular { get; set; }
    }
}
