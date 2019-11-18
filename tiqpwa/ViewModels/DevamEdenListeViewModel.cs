using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tiqpwa.ViewModels
{
    public class DevamEdenListeViewModel
    {
        public string ProjeAdi { get; set; }
        public int ProjeId { get; set; }
        public DateTime? Tarih { get; set; }
        public string Konu { get; set; }
        public string IlgiliPersonel { get; set; }
    }
}
