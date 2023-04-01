// See https://aka.ms/new-console-template for more information
using Ders10OzgenlerProperties;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Özgenler - Properties!");
        Skorlar skorlar = new Skorlar();
        skorlar.Skor = 5;
        Console.WriteLine("Skor değeri : " + skorlar.Skor);
        Kisi kisi = new Kisi();
        kisi.Adi = "Memati";
        kisi.Soyadi = "Baş";
        kisi.Maas = 8000; // burada Maas property sine veri gönderdiğimizde set bloğu çalışır
        kisi.Yas = 17;

        Console.WriteLine();
        Console.WriteLine("Personel Bilgileri:");
        Console.WriteLine($"Adı : {kisi.Adi} Soyadı : {kisi.Soyadi}");
        Console.WriteLine($"Maaş : {kisi.Maas} Yaş : {kisi.Yas}"); // burada Maas ve Kisi propertylerini çağırdığımızda, property deki get bloğu çalışır!

        kisi.Maas = 18000; // burada Maas property sine veri gönderdiğimizde set bloğu çalışır
        kisi.Yas = 39;
        Console.WriteLine();
        Console.WriteLine($"Maaş : {kisi.Maas} Yaş : {kisi.Yas}");

        User kullanici = new()
        {
            Name = "Alp",
            Email = "alp@arslan.net",
            Password = "2023"
        };
        kullanici.KayitTarihi = DateTime.Now;

        Console.WriteLine();
        Console.WriteLine("Kullanıcı Bilgileri:");
        Console.WriteLine($"Adı : {kullanici.Name} Email : {kullanici.Email}");

        User user = new(); // bu user ın Email ve Password bilgilerini ekrandan girdir. user içerisindeki metodu kullanarak ekrana giriş başarılı veya başarısız mesajı verdir.
        Console.WriteLine("Email adresinizi giriniz:");
        var email = Console.ReadLine(); // ekrandan girilen değeri email e aktar
        Console.WriteLine("Şifrenizi giriniz:");
        var sifre = Console.ReadLine();
        var sonuc = user.KullaniciGiris(email, sifre); // ekrandan aldığımız değerleri KullaniciGiris metoduna gönderiyoruz ve o metottan dönen true veya false değerini sonuc değişkenine aktarıyoruz
        if (sonuc == true)
        {
            Console.WriteLine("giriş başarılı");
        }
        else Console.WriteLine("giriş başarısız!");
    }
}
class Skorlar
{
    private int skor;
    public int Skor
    {
        get { return skor; }
        set { skor = value; }
    }
}