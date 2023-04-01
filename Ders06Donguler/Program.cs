// See https://aka.ms/new-console-template for more information
Console.WriteLine("Döngüler!");

Console.WriteLine("For Döngüsü");

int veritabanindangelenurunsayisi = 5;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("i nin değeri : " + i);
}

Console.WriteLine("While Döngüsü");

int j = 0; // değişkeni dışarıda tanımladık
while (j < 5) // şartımızı koştuk
{
    Console.WriteLine("j nin değeri : " + j);
    j++; // değişkenin değerini 1 artırıyoruz ki sonsuz göngüye girmesin
}

Console.WriteLine("Do While Döngüsü");

int toplam = 10;
do
{
    Console.WriteLine("toplamın değeri : " + toplam);
    toplam++;
} while (toplam < 10);

Console.WriteLine("Foreach Döngüsü");

string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon" };

foreach (var kategori in kategoriler) // diziler için en kullanışlı döngü
{
    Console.WriteLine("Kategori Adı : " + kategori);
}

string[] urunler = { "Ürün 1", "Ürün 2", "Ürün3" };

foreach (var kategori in kategoriler) // diziler için en kullanışlı döngü
{
    Console.WriteLine("Kategori Adı : " + kategori);
    foreach (var urun in urunler)
    {
        Console.WriteLine("\tÜrün Adı : " + urun);
    }
}