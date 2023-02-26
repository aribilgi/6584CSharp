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
        static void Main(string[] args)
        {
            Console.WriteLine("Yapılar - Struct!");
        }
    }
}