// See https://aka.ms/new-console-template for more information
Console.WriteLine("Koşul Yapıları");

int sayi = -10;

Console.WriteLine("Lütfen Bir Sayı Giriniz:");

// sayi = Convert.ToInt32(Console.ReadLine()); // ekrandan veri alabilmek için ReadLine metodu kullanılır. ReadLine metodu ekrandan verileri string olarak alır, sayısal işlem yapacaksak bunu dönüştürmemiz gerekir!

if (sayi > 0) // eğer sayı 0 dan büyükse
{
    Console.WriteLine("Sayı pozitif");
}
else if (sayi < 0)
{
    Console.WriteLine("Sayı negatif");
}
else
{
    Console.WriteLine("Sayı 0");
}

Console.WriteLine();

Console.WriteLine("Kullanıcı Adınızı Giriniz : ");

string kullaniciAdi = Console.ReadLine();

Console.WriteLine("Şifrenizi Giriniz : ");

string sifre = Console.ReadLine();

if (kullaniciAdi == "admin" && sifre == "123")
{
    Console.WriteLine("Giriş Başarılı! \n Hoşgeldin : " + kullaniciAdi);
}
else
{
    Console.WriteLine("Giriş Başarısız!");
}

int saat = DateTime.Now.Hour; // DateTime ile tarih ve saat bilgilerine ulaşırız

if (saat > 19)
    Console.WriteLine("İyi Akşamlar");
else
    Console.WriteLine("Saat : " + saat + " İyi Günler");

Console.WriteLine();

Console.WriteLine("Ternary Operatörü");

Console.WriteLine((saat > 19) ? "Saat : " + saat + " İyi Akşamlar" : "Saat : " + saat + " İyi Günler");

Console.WriteLine();

Console.WriteLine("Switch Case Kullanımı");

int ay = DateTime.Now.Month; // bulunduğumuz ay değerine ulaştık

switch (ay)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Mevsim Kış");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Mevsim İlk Bahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Mevsim Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Mevsim Sonbahar");
        break;

    default:
        Console.WriteLine("Hiç bir şart uymadıysa default çalışır");
        break;
}