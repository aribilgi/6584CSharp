using System.ComponentModel.DataAnnotations;

namespace MVCEgitim.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required, StringLength(10)]
        public string Ad { get; set; }
        [Required, StringLength(10)]
        public string Soyad { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Display(Name = "TC Kimlik Numarası")]
        [MinLength(11, ErrorMessage = "TC No 11 Karakter Olmalıdır!")]
        [MaxLength(11, ErrorMessage = "TC No 11 Karakter Olmalıdır!")]
        public string TCKimlikNo { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre"), DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "{0} {2} Karakterden Az Olamaz!", MinimumLength = 3)]
        public string Sifre { get; set; }
    }
}