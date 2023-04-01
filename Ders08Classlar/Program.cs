// See https://aka.ms/new-console-template for more information

using Ders08Classlar;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar - Class");
            Ev ilkEv = new Ev(); // soyut bir yapı olan ev sınıfından, somut bir nesne olan ilkev i oluşturduk
            ilkEv.sokakAdi = "Okul sk";
            ilkEv.kapiNo = 10;
            Console.WriteLine("İlk ev sokak adı : " + ilkEv.sokakAdi);
            Console.WriteLine("İlk ev kapı numarası : " + ilkEv.kapiNo);

            Ev yazlikEv = new();
            yazlikEv.sokakAdi = "Deniz Sk.";
            yazlikEv.kapiNo = 18;
            Console.WriteLine("yazlikEv sokak adı : " + yazlikEv.sokakAdi);
            Console.WriteLine("yazlikEv kapı numarası : " + yazlikEv.kapiNo);

            Ev koyEvi = new()
            {
                sokakAdi = "Kavak sk", // bu kullanımda ; yerine öğeler arasına , koymamız gerekli
                kapiNo = 34
            };
            Console.WriteLine("koyEvi sokak adı : " + koyEvi.sokakAdi);
            Console.WriteLine("koyEvi kapı numarası : " + koyEvi.kapiNo);

            Console.WriteLine();

            Kullanici kullanici = new()
            {
                Adi = "Deniz",
                Soyadi = "Çoban",
                Email = "deniz@coban.com",
                Id = 1,
                KullaniciAdi = "deniz",
                Sifre = "1234"
            };

            Kullanici mesut = new()
            {
                Id = 18,
                Adi = "Mesut",
                Soyadi = "Ilıca",
                Email = "mesutilica@gmail.com",
                KullaniciAdi = "mesut",
                Sifre = "123"
            };

            Console.WriteLine("Kendi Kullanıcımız :\n Adı : {0} Soyadı : {1}", mesut.Adi, mesut.Soyadi);

            Araba araba = new()
            {
                Id = 1,
                Marka = "Dacia",
                Model = "Logan",
                KasaTipi = "Sedan",
                VitesTipi = "Manuel",
                YakitTipi = "Dizel",
                Renk = "Bordo"
            };
            Console.WriteLine("Araç Bilgisi:");
            Console.WriteLine($"Marka : {araba.Marka} \n Model : {araba.Model} \n Renk : {araba.Renk}");

            Console.WriteLine();

            Araba araba2 = new()
            {
                Id = 2,
                Marka = "Audi",
                Model = "A8 Long",
                Renk = "Siyah"
            };
            Console.WriteLine("2. Araç Bilgisi:");
            Console.WriteLine($"Marka : {araba2.Marka} \n Model : {araba2.Model} \n Renk : {araba2.Renk}");

            /*
            Console.WriteLine("Kullanıcı Adınız :");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz :");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                Console.WriteLine("Hoşgeldin : " + kullanici.Adi + " " + kullanici.Soyadi);
            }
            else Console.WriteLine("Giriş Başarısız!");
            */
            Kategori kategori = new()
            {
                Id = 1,
                KatgoriAdi = "Elektronik"
            };
            Kategori kategori2 = new()
            {
                Id = 2,
                KatgoriAdi = "Bilgisayar"
            };
            Kategori kategori3 = new()
            {
                Id = 3,
                KatgoriAdi = "Telefon"
            };

            Console.WriteLine("Kategori : " + kategori.KatgoriAdi);
            Console.WriteLine("Kategori 2 : " + kategori2.KatgoriAdi);
            Console.WriteLine("Kategori 3 : " + kategori3.KatgoriAdi);

            SiniftaMetotKullanimi metotKullanimi = new();
            var sonuc = metotKullanimi.LoginKontrol("admin", "1234");
            if (sonuc == true)
            {
                Console.WriteLine("Giriş Başarılı!");
            }
            else Console.WriteLine("Giriş Başarısız!");

            Urun urun = new()
            {
                Adi = "Klavye",
                Fiyati = 249,
                UrunAciklamasi = "RGB Işıklı",
                Id = 1,
                Markasi = "Logitech"
            };
            Urun mouse = new()
            {
                Adi = "Mouse",
                Fiyati = 199,
                UrunAciklamasi = "Kablolu",
                Markasi = "A4 Tech"
            };
            Console.WriteLine("Ürün Bilgileri:");
            Console.WriteLine($"Ürün Adı : {urun.Adi}");
            Console.WriteLine($"Ürün Fiyatı : {urun.Fiyati}");
            Console.WriteLine($"Ürün Ürün Açıklaması : {urun.UrunAciklamasi}");
            Console.WriteLine();
            Console.WriteLine("Ürün Bilgileri:");
            Console.WriteLine($"Ürün Adı : {mouse.Adi}");
            Console.WriteLine($"Ürün Fiyatı : {mouse.Fiyati}");
            Console.WriteLine($"Ürün Ürün Açıklaması : {mouse.UrunAciklamasi}");

        } // Main metot bitişi
        class Ev // sınıf tanımlama
        {
            internal string sokakAdi;
            internal int kapiNo;
        }
    }
    class Kullanici
    {
        internal int Id;
        internal string KullaniciAdi;
        internal string Sifre;
        internal string Email;
        internal string Adi;
        internal string Soyadi;
    }
    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
    }
}
