using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tiqpwa.Entities.Concrete;

namespace tiqpwa.ViewModels
{
    public class ProjeListeViewModel
    {
        public Proje Proje { get; set; }
        public string KonuString { get; set; }
        public List<IsinKonusu> Konular { get; set; }
        public string IsinCinsiString { get; set; }
        public List<IsinCinsi> Cinsler { get; set; }
        public List<Kullanici> Kullanicilar { get; set; }
        public List<int> IlgiliKullanicilar { get; set; }
        public List<string> Yetkililer { get; set; }
    }
}
