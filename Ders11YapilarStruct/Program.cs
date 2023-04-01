namespace Ders11YapilarStruct
{
    /*
     * C# ta değişkenler değer(value) ve referans tipler olmak üzere 2 ye ayrılır.
     * Değişkenler ana bellek içerisinde stack ve heap denilen bölgelerde tutulur
     * string dışındaki tüm veri tipleri değer tiplidir ve stack alanında tutulur
     * string ve class gibi yapılarise bellekte heap alanında tutulur
     * stack te tutulan veriler işleri bittiğinde otomatik olarak bellekten atılır
     * referans tipliler ise garbage collector(çöp toplayıcı) tarafından belirli aralıklarla temizlenir ve açılan alan belleğe katılır.
     */
    public struct Yapi
    {
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("Yapı içindeki metot çalıştı");
        }
    }
    internal class Program
    {
        struct Kimlik
        {
            public string Ad;
            public string Soyad;
            public int Yas;
            public string DogumYeri;
            public struct Adres
            {
                public int Id { get; set; }
                public int KapiNo { get; set; }
                public string Sehir { get; set; }
                public string Ilce { get; set; }
                public string AcikAdres { get; set; }
            }
            internal string Birlestir(string ad, string soyad)
            {
                return ad + " " + soyad.ToUpper();
            }
            public void ToplamiYaz(int sayi1, int sayi2)
            {
                Console.WriteLine("Sayı 1 + Sayı 2:");
                Console.WriteLine(sayi1 + sayi2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Yapılar - Struct!");
            Kimlik kimlik = new Kimlik();
            kimlik.Ad = "Alp";
            kimlik.Soyad = "Arslan";
            kimlik.DogumYeri = "İstanbul";
            kimlik.Yas = 18;

            // Bilgileri ekrana yazdırma
            Console.WriteLine("Kimlik Bilgileri:");
            Console.WriteLine("Ad : {0} Soyad : {1}", kimlik.Ad, kimlik.Soyad);
            Console.WriteLine("Doğum Yeri : " + kimlik.DogumYeri);
            Console.WriteLine("Yaşı : " + kimlik.Yas);

            Console.WriteLine(kimlik.Birlestir("Ali", "Kamil")); // kimlik içindeki metodu çalıştırma
            kimlik.ToplamiYaz(10, 8);

            Kimlik.Adres adres = new() // Kimlik içerisindeki Adres yapısına ulaşma
            {
                Ilce = "Pendik",
                Sehir = "İstanbul",
                KapiNo = 18,
                AcikAdres = "Batı mah."
            };

            Console.WriteLine();
            Console.WriteLine("Kişi Adres:");
            Console.WriteLine("İlçe : " + adres.Ilce);
            Console.WriteLine("Şehir : " + adres.Sehir);
            Console.WriteLine("Kapı No : " + adres.KapiNo);
            Console.WriteLine("Açık Adres : " + adres.AcikAdres);

            Console.WriteLine("Statik Degisken Kullanimi");
            Console.WriteLine("Static İsim : " + StatikDegiskenKullanimi.isim);
            Console.WriteLine("Static Soyisim : " + StatikDegiskenKullanimi.soyisim);
            Console.WriteLine("Static Yaş : " + StatikDegiskenKullanimi.yas);
            StatikDegiskenKullanimi.yas = 55;
            Console.WriteLine("Static Yaş : " + StatikDegiskenKullanimi.yas);
        }
        public struct StatikDegiskenKullanimi
        {
            public static string isim = "Murat";
            public static string soyisim = "Yılmaz";
            public static int yas = 39;
            //public string meslek = "Noter"; eğer bir değişken static işaretlenmezse başlangıç değeri atayamayız struct da
        }
    }
}