// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operatörler!");

Console.WriteLine("1- Aritmetik Operatörler!");

int a = 50;
int b = 30;
int c = 20;

int toplama = a + b;

Console.WriteLine("a + b : " + toplama);

int cikarma = a - b;

Console.WriteLine("a - b : " + cikarma);

int carpma = b * c;

Console.WriteLine("b * c : " + carpma);

int bolme = b / c;

Console.WriteLine("b / c : " + bolme);

int kalan = b % c;

Console.WriteLine("b % c : " + kalan);

b++; // b nin değerini 1 artır

Console.WriteLine("b++ : " + b);

b--; // b nin değerini 1 azalt

Console.WriteLine("b-- : " + b);

Console.WriteLine(); // boş satır ekle

Console.WriteLine("2- Atama Operatörleri!");

Console.WriteLine("a nın değeri : " + a);
Console.WriteLine("b nın değeri : " + b);
Console.WriteLine("c nın değeri : " + c);

Console.WriteLine("a += b : " + (a += b)); // a nın değerini b kadar artır
Console.WriteLine("a = a + b : " + (a = a + b)); // bu işlem ile a += b işlemi aynı işlevi görür

Console.WriteLine("a -= b : " + (a -= b));
Console.WriteLine("a *= b : " + (a *= b));
Console.WriteLine("a /= b : " + (a /= b));

Console.WriteLine("3- İlişkisel Operatörler");

Console.WriteLine($"a({a}) == b({b}) : " + (a == b)); // a b ye eşit mi
Console.WriteLine($"a({a}) != b({b}) : " + (a != b)); // a b ye eşit değil mi
Console.WriteLine($"a({a}) > b({b}) : " + (a > b)); // a b den büyük mü
Console.WriteLine($"a({a}) < b({b}) : " + (a < b)); // a b den küçük mü
Console.WriteLine($"a({a}) <= b({b}) : " + (a <= b)); // a b den küçük mü veya a b ye eşit mi
Console.WriteLine($"a({a}) >= b({b}) : " + (a >= b)); // a b den büyük mü veya a b ye eşit mi
Console.WriteLine("ternary operatörü a == b : " + ((a == b) ? "a b ye eşit" : "a b ye eşit değil")); // 2 olasılıklı durumlarda kullanabileceğimiz ternary operatörü

Console.WriteLine();
Console.WriteLine("4- Mantıksal Operatörler");

Console.WriteLine($"a-{a}, b-{b}, c-{c} ((a > b) && (b > c)) : " + ((a > b) && (b > c))); // && - ve operatörü iki şartın doğruluğunu bekler

Console.WriteLine($"a-{a}, b-{b}, c-{c} ((a > b) || (b < c)) : " + ((a > b) || (b < c))); // || - veya operatörü iki şarttan birinin doğru olmasını bekler

Console.WriteLine();
Console.WriteLine($"a-{a}, b-{b} (a > b) : " + (a > b));
Console.WriteLine($"a-{a}, b-{b} (a > b) : " + !(a > b)); // ! işareti ile bir işlem sonucunun tam tersini elde ederiz