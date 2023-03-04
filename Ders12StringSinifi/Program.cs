// See https://aka.ms/new-console-template for more information

namespace Ders12StringSinifi
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("String Sınıfı");

            string metin = "değişken";

            char karakter = 'K';
            Ornek1();
            StringMetotlari();
        }
        static void Ornek1()
        {
            string birMetin = "Ankara başkenttir";
            String birSayi = "123456789";
            System.String birTarih = "04.03.2023";
            string s = "C# Eğitimi";
            Console.WriteLine("s yi for ile yazdırma");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("s[" + i + "]" + s[i]);
            }
            Console.WriteLine("s yi foreach ile yazdırma");
            foreach (var item in s) // s değişkeni içindeki her bir karakter için dön
            {
                Console.WriteLine(item); // her karakteri bir satıra yazdır
            }
        }
        static void StringMetotlari()
        {
            string metin = "Stringin Birçok Metodu Vardır";

            Console.WriteLine("metin in karakter sayısı(metin.Length) : " + metin.Length);
            var klon = metin.Clone();
            Console.WriteLine("metnin klonu : " + klon);
            metin = "My Name is Ali";
            Console.WriteLine(metin + " metin.EndsWith(\"i\") metin i ile mi bitiyor : " + metin.EndsWith("i"));
            Console.WriteLine(metin + " metin.EndsWith(\"r\") metin r ile mi bitiyor : " + metin.EndsWith("r"));
            Console.WriteLine(metin + " metin.StartsWith(\"r\") metin r ile mi başlıyor : " + metin.StartsWith("r"));
            Console.WriteLine(metin + " metin.StartsWith(\"m\") metin m ile mi başlıyor : " + metin.StartsWith("m"));
            Console.WriteLine(metin + " metin.StartsWith(\"M\") metin M ile mi başlıyor : " + metin.StartsWith("M"));
            Console.WriteLine(metin + " metin.IndexOf(name) metin içindeki name in index değeri : " + metin.IndexOf("name"));
            Console.WriteLine(metin + " metin.IndexOf(Name) metin içindeki Name in index değeri : " + metin.IndexOf("Name"));
            Console.WriteLine(metin + " metin.LastIndexOf(\"i\") metin içindeki i in index değeri : " + metin.LastIndexOf("i"));
            Console.WriteLine(metin + " metin.Insert(0, \"Merhaba : \") metine Merhaba ekleme : " + metin.Insert(0, "Merhaba : ")); // metnin değeri değişmiyor sadece başına merhaba ekleniyor
            Console.WriteLine(metin);
            Console.WriteLine(metin.Substring(2, 5)); // Substring metinden parça alır, kaçıncı karakterden itibaren kaç karakter alacağımızı belirtiyoruz.
            Console.WriteLine(metin.ToLower()); // metini küçük harfe çevirir
            Console.WriteLine(metin.ToUpper()); // metini büyük harfe çevirir
            Console.WriteLine(metin.ToLower().Replace(" ", "-")); // metini küçük harfe çevir ve replace ile içindeki boşlukları - ile değiştir
            Console.WriteLine(metin.Remove(2, 5)); // metinde seçili alanı silmek için
        }
    }
}
