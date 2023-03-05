namespace Ders17AbstractSiniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Sınıflar!");
            //Database database = new Database(); // abstract class larda bu şekilde nesne oluşturulamaz!
            Database sqlServer = new SqlServer(); // abstract class tan nesne oluşturmak için miras alan sınıftan örnek oluşturulur.
            sqlServer.Add();
            sqlServer.Update();
            Database mySql = new MySql(); // miras alan her sınıf bu şekilde örneklenebilir.
            mySql.Delete();
            mySql.Update();

        }
    }
    abstract class Database
    {
        public void Add() // ortak ekleme metodu
        {
            Console.WriteLine("Ekleme metodu çalıştı!");
        }
        public abstract void Delete();
        public abstract void Update();
        public abstract void Get();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("SqlServer Delete metodu çalıştı!");
        }

        public override void Get()
        {
            Console.WriteLine("SqlServer Get metodu çalıştı!");
        }

        public override void Update()
        {
            Console.WriteLine("SqlServer Update metodu çalıştı!");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Oracle Delete metodu çalıştı!");
        }

        public override void Get()
        {
            Console.WriteLine("Oracle Get metodu çalıştı!");
        }

        public override void Update()
        {
            Console.WriteLine("Oracle Update metodu çalıştı!");
        }
    }
    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("MySql Delete metodu çalıştı!");
        }

        public override void Get()
        {
            Console.WriteLine("MySql Get metodu çalıştı!");
        }

        public override void Update()
        {
            Console.WriteLine("MySql Update metodu çalıştı!");
        }
    }
}