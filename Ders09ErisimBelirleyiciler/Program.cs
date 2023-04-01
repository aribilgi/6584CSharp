// See https://aka.ms/new-console-template for more information
/*
 * public : yazdığımız kod bloğuna projenin her yerinden erişebilmemizi sağlar
 * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
 * internal : Etkin projeye ait sınıflardan erişilebilir
 * private : Yalnızca bulunduğu sınıftan erişilebilir
 * 1 öğe sadece 1 tane erişim belirteci alabilir.
 */
// Bir projeden (örneğin Ders09ErisimBelirleyiciler) solution içerisndeki başka bir projeye (örneğin Ders08Classlar) erişmek için 2 proje arasında bağlantı kurmalıyız.
// Bu bağlantıyı projemizdeki dependencies e sağ tıklayıp add project reference a tıklayıp açılan pencereden bağlanmak istediğimiz projeye tik atık tamam diyerek pencereyi kapatıp bağlantı kurabiliriz.

using Ders08Classlar;
using Ders09ErisimBelirleyiciler; // bu satır Kullanici class ını bu sayfada kullanabilmemiz için

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Erişim Belirleyiciler!");
        Kategori kategori = new Kategori();
        // kategori. Kategori class ı içerisindeki değişkene erişim belirteci verilmediği için burada erişemiyoruz
        kategori.Adi = "Bilgisayar";

        Urun urun = new Urun();
        urun.Adi = "Monitör";
        urun.Fiyati = 9999;
        // urun. diğerlerine burada erişemiyoruz
        Console.WriteLine($"Ürün Bilgileri :  \n Ürün Kategorisi : {kategori.Adi} \n Ürün Adı : {urun.Adi} \n Ürün Fiyatı : {urun.Fiyati} TL");

        Console.WriteLine();

        Kullanici kullanici = new()
        {
            Adi = "Ali",
            Soyadi = "Can"
        };
        SiniftaMetotKullanimi siniftaMetot = new(); // bu class Ders08Classlar projesinden geldi
        var sonuc = siniftaMetot.LoginKontrol(kullanici.Adi, kullanici.Soyadi);
        Console.WriteLine("Login Sonucu : " + sonuc);
    }
}
class Kategori
{
    public string Adi; // her yerden erişilebilir
    string Aciklamasi; // sadece bu class içerisinde erişilebilir
}
class Urun
{
    private int Id; // gizli, sadece bu class ta erişilebilir
    internal string Adi; // bu projede erişilebilir
    protected string Aciklamasi; // bu sınıf ve miras alındığı yerde
    public decimal Fiyati; // her yerden erişilebilir
}