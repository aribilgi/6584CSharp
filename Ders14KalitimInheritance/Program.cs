namespace Ders14KalitimInheritance
{
    class Arac
    {
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Biip");
        }
    }
    class Test
    {
        public int Id { get; set; }
    }
    class Otombil : Arac //  : Arac ile arac sınıfından içindekileri miras alırız
    { // artık otomobil sınıfında arac sınıfındaki içeriklere sahibiz
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalıtım-Miras Alma - Inheritance!");
            Arac arac = new();
            arac.AracTuru = "Otomobil";
            Console.WriteLine("arac.AracTuru : " + arac.AracTuru);
            Otombil otombil = new();
            otombil.AracTuru = "Otomobil"; // Normalde Otomobil classında AracTuru yok
            Console.WriteLine("otombil.AracTuru : " + otombil.AracTuru);
            otombil.KornaCal(); // KornaCal metodu bir üst sınıf olan Arac sınıfından geliyor

            Kategori kategori = new()
            {
                Name = "Elektronik",
                UstMenudeGoster = true,
                EklenmeTarihi = DateTime.Now
            };
            Console.WriteLine($"kategori bilgileri :\n Adı : {kategori.Name} - Eklenme Tarihi : {kategori.EklenmeTarihi}");
            Urun urun = new()
            {
                Name = "Klavye",
                Fiyat = 299,
                Kdv = 18,
                EklenmeTarihi = DateTime.Now
            };
            Console.WriteLine($"ürün bilgileri :\n Adı : {urun.Name} - Fiyatı : {urun.Fiyat} - Kdv : {urun.Kdv} - Eklenme Tarihi : {urun.EklenmeTarihi}");

            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici)
            {
                item.Ciz();
            }

        }
        // Polimorfizm - Çokbiçimlilik
        public class Cizici
        {
            public virtual void Ciz() // virtual keywordü ile bu metodu override-ezilebilir hale getiriyoruz
            {
                Console.WriteLine("Cizici");
            }
        }
        public class DogruCiz : Cizici
        {
            public override void Ciz() // Cizici sınıfındaki Ciz metodunu override keywordünü kullanarak eziyoruz ve ekrana yeni çıktı yazdırmasını sağlıyoruz
            {
                Console.WriteLine("Düz Çizgi");
            }
        }
        public class DaireCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("DaireCiz");
            }
        }
        public class KareCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("KareCiz");
            }
        }
    }
}
