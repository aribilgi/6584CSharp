// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tip Dönüşümleri!");

Console.WriteLine("Implicit Casting - Otomatik Dönüşüm");

// byte > int > long > float

int sayi = 9;
double kesirliSayi = sayi;
Console.WriteLine("Sayı : " + sayi);
Console.WriteLine("Kesirli Sayi : " + kesirliSayi);

Console.WriteLine("Explicit Casting");

double kesirliSayi2 = 258;

int tamSayi = (int)kesirliSayi2; // kesirliSayi2 yi int e cast etme - dönüştürme

byte plaka = (byte)kesirliSayi2;

Console.WriteLine("tamSayi : " + plaka);

int tamSayi2 = 18;
double kesirliSayi3 = 5.25;
decimal urunFiyati = 9999;

Console.WriteLine("Diğer Tür Dönüştürme Metotları");

Console.WriteLine(Convert.ToByte(tamSayi2));
Console.WriteLine(Convert.ToInt32(kesirliSayi3));