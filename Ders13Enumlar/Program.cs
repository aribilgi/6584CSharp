namespace Ders13Enumlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumlar!");
            Console.WriteLine("Enumaratorler nesneleri numaralandırmak için kullanılır");
            Console.WriteLine("İçerisinde metot tanımlanamaz!");
            Console.WriteLine("Arayüz(interface) kullanamazlar!");
            Console.WriteLine("Enum içerisinde property kullanılmaz");
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine($"Meyveler : Armut={a}, Elma ={b}, Çilek={c}");
            Console.WriteLine($"Meyveler : Armut={Meyveler.Armut}, Elma ={Meyveler.Elma}, Çilek={Meyveler.Çilek}");

            int SiparisDurum = 1;
            if (SiparisDurum == 0)
            {
                Console.WriteLine("Sipariş Durumu : " + SiparisDurumu.OnayBekliyor);
            }
            if (SiparisDurum == 1)
            {
                Console.WriteLine("Sipariş Durumu : " + SiparisDurumu.Onaylandı);
            }
            if (SiparisDurum == 2)
            {
                Console.WriteLine("Sipariş Durumu : " + SiparisDurumu.Hazırlanıyor);
            }
            if (SiparisDurum == 3)
            {
                Console.WriteLine("Sipariş Durumu : " + SiparisDurumu.KargoyaVerildi);
            }
        }
        enum Aylar : byte
        {
            Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos
        }
        enum CalisilanGunler
        {
            Pazartesi, Salı, Çarşamba, Perşembe, Cuma
        }
        enum SiparisDurumu
        {
            OnayBekliyor, Onaylandı, Hazırlanıyor, KargoyaVerildi
        }
        enum Meyveler : int
        {
            Elma = 3, Armut = 7, Çilek = 1 // sıra numarası verebiliriz
        }
    }
}