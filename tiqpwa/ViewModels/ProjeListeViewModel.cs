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
    }
}
