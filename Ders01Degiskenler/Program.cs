// See https://aka.ms/new-console-template for more information
// c# ta yorum satırı
Console.WriteLine("Değişkenler!"); // kod açıklaması
// C# ta Değişken tanımlama

// Tam Sayı Veri Tipleri

byte plaka_kodu; // değişken tanımlama: değişkenin tipi - değişkenin adı
plaka_kodu = 34; // değişkene veri atama

sbyte sbyteTuru = 127; // değişkeni oluşturduğumuz anda veri atayabiliriz

short kisaTamSayi = 1234;

ushort ortaTamSayi = 12345;

int tamSayi = 123456;

uint uzunint = 123456789;

long uzunTamSayi = 1234567899;

ulong enuzunTamsayi = 98745632123;

// Kesirli Veri Tipleri

float kesirliSayi = 4.5f;
double kesirliSayi2 = 4.5;

// Decimal Veri Tipi

decimal urunFiyati = 5500;

// Char veri tipi
char karakter = 'a'; // char tek karakter taşıyabilir ve tek tırnakla yazılır

// String veri tipi
string metin = "string veri tipi yan yana yazılmış char lardan oluşur";

// Boolean veri tipi

bool aktif = false; // true veya false 2 değerden birini alabilir

byte? kilo = null; // ? işareti bu tipi boş bırakılabilir(nullable) hale getirir
kilo = 69;

decimal asgariUcret = 8506.80m;

var degisken = 18; // var anahtar kelimesi ile değişken tanımlarsak atanan değere göre veri tipi otomatik belirlenir.
degisken = 8;

// C# ta Sabitler

const int kdvMiktari = 18;

// kdvMiktari = 8;

Console.Write("String deki metin : ");
Console.Write(metin);
Console.Write("Kdv Miktarı : ");
Console.Write(kdvMiktari);
Console.WriteLine(); // ekrana Console.WriteLine yazdırmanın kısayolu cw yazıp taba basmak
Console.WriteLine("Kdv \n \t Miktarı : "); // \n yazının alt satırdan devam etmesini sağlar, \t klavyeden tab a basıp yazıyı içeri alma görevi görür
Console.WriteLine(kdvMiktari);