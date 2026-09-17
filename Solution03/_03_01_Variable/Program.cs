int age = 27;
Console.WriteLine($"Yas: {age}"); //tam sayi türünde bir değişken tanımlandı ve ekrana yazdırıldı // $ isareti ile string interpolation kullanıldı ve age değişkeni ekrana yazdırıldı
                                  // {} sembollerinin içine değişken adı yazılarak değişkenin değeri ekrana yazdırıldı

const double piValue = 3.35; //value demek değişkenin değeri demektir. double türünde bir değişken tanımlandı ve ekrana yazdırıldı
Console.WriteLine($"Pi değeri: {piValue}"); // $ isareti ile string interpolation kullanıldı ve piValue değişkeni ekrana yazdırıldı
//const türünde bir değişken tanımlandı ve ekrana yazdırıldı. const türü, değişkenin değerinin sabit olduğunu belirtir ve değiştirilemez.


var city = "Izmir"; //var türünde bir değişken tanımlandı ve ekrana yazdırıldı. var türü, değişkenin türünü otomatik olarak belirler.
Console.WriteLine($"Sehir: {city}"); // $ isareti ile string interpolation kullanıldı ve city değişkeni ekrana yazdırıldı

age -= 3; //age değişkeninin değeri 3 azaltıldı ve ekrana yazdırıldı
Console.WriteLine($"Yeni Yas: {age}");

var today = DateTime.Now; //DateTime türünde bir değişken tanımlandı ve ekrana yazdırıldı. DateTime türü, tarih ve saat bilgilerini tutar.
Console.WriteLine($"Bugunun Tarihi : {today}"); // $ isareti ile string interpolation kullanıldı ve today değişkeni ekrana yazdırıldı

Console.ReadKey(); //Console.ReadKey() metodu, kullanıcıdan bir tuşa basmasını bekler ve ardından programın sonlanmasını sağlar.
