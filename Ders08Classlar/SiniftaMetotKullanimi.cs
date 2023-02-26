namespace Ders08Classlar
{
    public class SiniftaMetotKullanimi // internal = erişim belirteci
    {
        string kurucuMetot; // başında erişim belirteci yazmazsak sadece bulunduğu süslü parantez içinden erişebiliriz.
        public SiniftaMetotKullanimi() // ctor yazıp klavyeden 2 kez tab a basarak oluşabilir
        {
            kurucuMetot = "sınıflarda kurucu metot(constructor) sistemi vardır ve sınıftan new ile bir nesne oluşturduğumuzda ilk önce bu metot çalışır!";
            Console.WriteLine(kurucuMetot);
        }
        public bool LoginKontrol(string kullanici, string sifre)
        {
            if (kullanici == "admin" && sifre == "123456")
            {
                return true;
            }
            return false;
        }
        internal bool MailGonder(string email)
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
    }
}
