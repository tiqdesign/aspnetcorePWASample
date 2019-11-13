using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using tiqpwa.Core.Entities;

namespace tiqpwa.Entities.Concrete
{
    public class Kullanici : IEntity
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Giriniz!")]
        public string KullaniciGiris { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Boş Bırakılamaz!")]
        public string KullaniciSifre { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciTelefon { get; set; }
        public string KullaniciDepartman { get; set; }

    }
}
