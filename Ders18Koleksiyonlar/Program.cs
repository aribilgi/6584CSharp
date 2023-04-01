using System.Collections;
using System.Collections.Specialized;

namespace Ders18Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koleksiyonlar!");
            //Ornek1();
            Console.WriteLine();
            //Ornek2();
            //Ornek3();
            //Ornek4();
            //Ornek5();
            //Ornek6();
            //Ornek7();
            //Ornek8();
            ListKullanimi();
        }
        static void Ornek1()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1); // arrayList e Add metoduyla veri eklenir
            arrayList.Add(2);
            arrayList.Add(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item); // listedeki elemanları ekrana yazdır
            }
            Console.WriteLine("ArrayList ilk eleman : " + arrayList[0]); // listede index ini verdiğimiz elemana ulaşma
        }
        static void Ornek2()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("İstanbul"); // arrayList e Add metoduyla veri eklenir
            arrayList.Add("Ankara"); // arrayList string veri de alabilir
            arrayList.Add("İzmir");
            arrayList.Add("Zonguldak");
            arrayList.Add("Çankırı");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item); // listedeki elemanları ekrana yazdır
            }
            Console.WriteLine("ArrayList ilk eleman : " + arrayList[0]); // listede index ini verdiğimiz elemana ulaşma
            Console.WriteLine();
            Console.WriteLine("ArrayList de sıralama yapabiliriz");
            arrayList.Sort(); // listeyi sıralama
            foreach (var item in arrayList)
            {
                Console.WriteLine(item); // listedeki elemanları ekrana yazdır
            }
            Console.WriteLine();
            arrayList.Reverse(); // tersten sıralama
            foreach (var item in arrayList)
            {
                Console.WriteLine(item); // listedeki elemanları ekrana yazdır
            }
        }
        static void Ornek3()
        {
            int tamSayi = 18;
            double kesirli = 18.8;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ankara");
            arrayList.Add(tamSayi);
            arrayList.Add(kesirli);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]); // arrayList in i. satırındaki eleman
            }
        }
        static void Ornek4()
        {
            StringCollection strings = new StringCollection();
            // strings.Add(5); StringCollection a sadece string değer eklenebilir
            strings.Add("İstanbul");
            strings.Add("Ankara");
            strings.Add("Bursa");
            Console.WriteLine("String Collection");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek5()
        {
            StringDictionary dictionary = new StringDictionary(); // key value şeklinde veri saklayabilir
            dictionary.Add("18", "Çankırı");
            dictionary.Add("06", "Angara");
            dictionary.Add("34", "İstanbul");
            dictionary.Add("01", "Adana");
            dictionary.Add("42", "Konya");
            Console.WriteLine("String Dictionary");
            Console.WriteLine(dictionary["42"]);
            Console.WriteLine("String Dictionary Values");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("String Dictionary Keys");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("String Dictionary Keys-Values");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek6()
        {
            Stack stack = new Stack(); // Stack sınıfı programlamada LIFO - son giren ilk çıkar kuralıyla çalışır.
            // stack.add(); stack de listeye add metoduyla ekleme yapılmaz
            stack.Push("Çankırı");
            stack.Push("Ankara");
            stack.Push("İstanbul");
            stack.Push("Karabük");
            stack.Push(34);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop()); // stack de nesneler üst üste koyulmuş gibidir verilere de üstten çekerek ulaşılır
            }
        }
        static void Ornek7()
        {
            Queue queue = new Queue(); // Queue sınıfı programlamada FIFO - ilk giren ilk çıkar mantığıyla çalışır
            queue.Enqueue("Lale");
            queue.Enqueue("Gül");
            queue.Enqueue("Zambak");
            queue.Enqueue(18); // obje aldığı için her türlü veri kabul eder
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        static void Ornek8()
        {
            Dictionary<string, string> dictionary = new(); // hangi veri tipinden oluşacağını bizim belirleyebildiğimiz liste sistemi
            dictionary.Add("book", "kitap");
            dictionary.Add("18", "Çankırı");
            dictionary.Add("34", "İstanbul");
            Console.WriteLine(dictionary["book"]);
            Dictionary<int, string> dictionary2 = new();
            dictionary2.Add(1, "kitap");
            dictionary2.Add(18, "Çankırı");
            dictionary2.Add(34, "İstanbul");
            Console.WriteLine("dictionary2 Values");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("dictionary2 Keys");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("dictionary2 Key-Values");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        static void ListKullanimi()
        {
            List<string> sehirler = new(); // string veri tipi alabilen bir liste
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Kocaeli");
            Console.WriteLine("Şehirler : ");
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            List<User> users = new();
            users.Add(new User
            {
                Id = 1,
                Name = "Gül",
                Password = "123"
            });
            users.Add(new User
            {
                Id = 2,
                Name = "Deniz",
                Password = "456"
            });
            Console.WriteLine("Kullanıcılar(users) : ");
            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }
            List<User> kullanicilar = new()
            {
                new User
                {
                    Id = 3,
                    Name = "İrem",
                    Password = "123"
                },
                new User
                {
                    Id = 4,
                    Name = "Safa",
                    Password = "456"
                }
            };
            Console.WriteLine();
            Console.WriteLine("Kullanıcılar(kullanicilar) : ");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
            kullanicilar.AddRange(users); // kullanicilar listesine çoklu ekleme için AddRange metodu kullanılır.
            Console.WriteLine("Kullanıcılar(kullanicilar) : ");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name);
            }
            var yeniKullanici = new User()
            {
                Name = "Alp",
                Password = "789"
            };
            Console.WriteLine("kullanicilar listesinde yeniKullanici var mı? " + kullanicilar.Contains(yeniKullanici));
            kullanicilar.Add(yeniKullanici); // kullanicilar a yeniKullanici yı ekle
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("kullanicilar listesinde yeniKullanici var mı? " + kullanicilar.Contains(yeniKullanici));
            Console.WriteLine("Listedeki kayıt sayısı : " + kullanicilar.Count);
            kullanicilar.Insert(1, yeniKullanici);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name);
            }
        }
        class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
        }

    }
}