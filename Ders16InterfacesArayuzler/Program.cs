namespace Ders16InterfacesArayuzler
{
    interface OrnekArayuz // class yerine interface yazıyoruz
    {
        public int Id { get; set; }
    }
    interface IDemo
    {
        void Goster(); // interface de metot imzası tanımlama
    }
    interface icerebilecekleri : IDemo
    {
        public int sayi1 { get; set; }
        int sayi { get; set; }
        static int sayi2 { get; set; }
        void Topla();
        int ToplamaYap();
    }
    class ArayuzKullanimi : icerebilecekleri // bir interface den class a kalıtım yaparsak interface deki her şey class ta kullanılmak zorunda olur. interface in üzerine gelip implement interface demeliyiz
    {
        public int sayi1 { get; set; }
        int icerebilecekleri.sayi { get; set; }

        public void Goster()
        {
            Console.WriteLine(sayi1);
        }

        public void Topla()
        {
            throw new NotImplementedException();
        }

        public int ToplamaYap()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces - Arayuzler!");
            ArayuzKullanimi arayuzKullanimi = new();
            arayuzKullanimi.sayi1 = 18;
            arayuzKullanimi.Goster();
        }
    }
    interface ISinifGereksinimleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
    }
    interface IVeritabaniIslemleri
    {
        void Add();
        void Update();
        void Delete();
        void Get();
        void GetAll();
    }
    class Urun : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public string Resim { get; set; }

        public void Add()
        {
            Console.WriteLine(Name + " Eklendi!");
        }

        public void Delete()
        {
            Console.WriteLine(Name + " Silindi!");
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Kategori : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Yazdir()
        {
            throw new NotImplementedException();
        }

    }
}