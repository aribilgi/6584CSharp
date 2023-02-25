// See https://aka.ms/new-console-template for more information
Console.WriteLine("Metotlar");
/*
void ToplamaYap() // void metotlar geriye değer döndürmez, sadece görevini yapar.
{
    Console.WriteLine(10 + 8);
}

ToplamaYap();

void ToplamaYapParametreli(int sayi1, int sayi2) // metotlar dışarıdan parametre gönderilerek de kullanılabilir
{
    Console.WriteLine("Toplama Sonucu :");
    Console.WriteLine(sayi1 + sayi2);
}

ToplamaYapParametreli(18, 34);
ToplamaYapParametreli(sayi2: 18, sayi1: 25); // dilersek parametre isimlerini belirterek kullanabiliriz

int ToplamaParametreli(int sayi1, int sayi2) // metot isminin önüne void yerine her hangi bir veri tipi belirterek geriye bu tipte değer döndürecek metot oluşturabiliriz
{
    // eğer bir metot geriye değer döndürüyorsa metot içerisinde return ifadesiyle bir değer döndürmeliyiz.
    return sayi1 + sayi2; // bu metoda gönderilecek değerleri topla ve bu toplama sonucunu metodun kullanılacağı yere gönder
}

Console.WriteLine("Değer döndüren Toplama Sonucu :");
int islemSonucu = ToplamaParametreli(18, 9); // toplama işleminin sonucunu bize getiren metodun getirdiği toplam değeri islemSonucu isimli değişkene aktardık
Console.WriteLine(islemSonucu); // işlem sonucunu ekrana yazdır

bool MailGonder(string email)
{
    // burası örnek mail gönderim
    // kod alanı
    if (email != "") // eğer email değişkeni boş değilse
    {
        // mail gönderim kodlarını çalıştır
        // ve maili gönder
        return true; // geriye de mail gönderildiğini anlayabilmemiz için bize true değeri döndür
    }
    return false; // if bloğu çalışmamışsa metot buraya kadar gelecek ve geriye false değeri döndürecek böylece biz de mail gönderim işleminin başırısız oluduğunu anlayabileceğiz.
}

Console.WriteLine("Mail adresinizi giriniz :");

var mail = Console.ReadLine();

var sonuc = MailGonder(mail); // var ile metottan dönen veri tipini(bool) otomatik belirliyoruz

if (sonuc == true)
    Console.WriteLine("Mailiniz Başarıyla Gönderildi!");
else
    Console.WriteLine("Mail Gönderilemedi!");
*/

// ekrandan kullanıcı adı ve şifre bilgisi girilsin -- k.adı: admin, şifre:123456
// bu verileri bir metot içerisinde kontol edelim
// eğer girilen veriler istediğimiz değerlerse geriye true dönsün ve ekrana hoşgeldin kullanıcı adı yazsın

Console.WriteLine("Kullanıcı adınızı giriniz:");
var kullaniciAdi = Console.ReadLine();
Console.WriteLine("Şifrenizi giriniz:");
var sifre = Console.ReadLine();

bool LoginKontrol(string kullanici, string sifre)
{
    if (kullanici == "admin" && sifre == "123456")
    {
        return true;
    }
    return false;
}

var girisSonuc = LoginKontrol(kullaniciAdi, sifre);

//if (girisSonuc == true) // if kontrolünü bu şekilde açık olarak kullanabiliriz
//if (LoginKontrol(kullaniciAdi, sifre)) // if in içinde direk metodu çağırabiliriz
if (girisSonuc) // girisSonuc değişkeni zaten true veya false olacağı için bu şekilde kontrol edebiliriz
    Console.WriteLine("Hoşgeldin : " + kullaniciAdi);
else Console.WriteLine("Giriş Başarısız!");