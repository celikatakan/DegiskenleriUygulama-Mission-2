using System.Threading.Channels;

// Metinsel ifade olduğu için string değişkeni kullandım.

string Messeage = "Lütfen aşşağıdaki bilgileri giriniz:";

Console.WriteLine(Messeage);

Console.Write("T.C. Kimlik Numarınızı Giriniz:");

string TcNum = Console.ReadLine();

Console.Write("Adınız:");

string Name = Console.ReadLine();

Console.Write("Soyadınız:");

string Surname = Console.ReadLine();

// Numara sayı olarak yazıldığı için int ifadesi kullanılması lazım fakat burada metin şeklinde sorulduğu için string kullanmayı tercih ettim.

Console.Write("Telefon Numarınız:");

string PhoneNum = Console.ReadLine();

// Yaş rakam veya sayı ile yazıldığı için int ifadesi kullanılması lazım fakat burada metin şeklinde sorulduğu için string kullanmayı tercih ettim.

Console.Write("Yaşınız:");

string Age = Console.ReadLine();

Console.Write("İlk Aldığı Ürün Fiyatı:");

// Konsoldan gelen veri string olduğu için kodu integer convertleyip değişken attım.

int FirstPrice = Convert.ToInt32 (Console.ReadLine());

Console.Write("İkinci Aldığı Ürün Fiyatı:");

int SecondPrice = Convert.ToInt32 (Console.ReadLine());

int LastPrice = (FirstPrice) + (SecondPrice);

// 0.1 Ondalık sayı olduğu için integer değişkenini double çevirdim. 

double SalePrice = Convert.ToDouble ((LastPrice) * (0.1));



Console.WriteLine("-------------------------------------------");

Console.WriteLine($"{TcNum} Tc numaralı {Name} {Surname} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{PhoneNum} telefon numarasına bildirim mesajı gönderilmiştir.");
Console.WriteLine($"{LastPrice} toplam harcama karşılığı kazanılan %10 patika puan miktarı -> {SalePrice} TL'dir.");







