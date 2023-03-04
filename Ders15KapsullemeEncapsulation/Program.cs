namespace Ders15KapsullemeEncapsulation
{
    internal class Program
    {
        // Metot Kullanarak Kapsülleme
        public class Bolum
        {
            private string BolumAdi;
            public string GetBolumAdi() // Accessor - Getter
            {
                return BolumAdi;
            }
            public void SetBolumAdi(string a)
            {
                if (a == "Yazılım Mühendisliği") // eğer metoda gönderilen değer geçersizse
                {
                    Console.WriteLine("Okulumuzda Bu bölüm bulunmamaktadır");
                }
                else BolumAdi = a; // geçerliyse private değişkene değeri ata
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kapsulleme - Encapsulation!");
            //Console.WriteLine("C# ta özegen yapısı kullanılarak verileri kapsülleyebilir, istemediğimiz veriye engel olabiliriz.");
            Bolum bolum = new();
            Console.WriteLine("Tercih Ettiğiniz Bölümü Giriniz!");
            var secilenbolum = Console.ReadLine();
            bolum.SetBolumAdi(secilenbolum);
            Console.WriteLine("Seçtiğiniz Bölüm : " + bolum.GetBolumAdi());
        }
        // Özgen-Property Kullanarak Kapsülleme
        class Fakulte
        {
            private string bolum;
            public string Bolum
            {
                get { return bolum; }
                set
                {
                    if (value == "Yazılım Mühendisliği")
                    {
                        Console.WriteLine("Okulumuzda Bu bölüm bulunmamaktadır");
                    }
                    else bolum = value;
                }
            }
        }
    }
}