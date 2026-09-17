object data = "Merhaba"; //object diyerek string'i object'e atadık. Boxing işlemi gerçekleşti.
int a = 50; // int tipinde bir değişken oluşturduk ve 50 değerini atadık. Bu bir değer tiptir.
data = a; // Boxing işlemi gerçekleşti. -> int -> object 
var b = (int)data; // Unboxing işlemi gerçekleşti. data'nın veri türü object olduğu için int tipine dönüştürülmesi gerekiyor. Bu yüzden (int) ile cast işlemi yapıyoruz.
b++;
Console.WriteLine(b);

if (data is string) // is operatörünü kullanarak data'nın veri türünü kontrol ediyoruz. buna tip kontrolü denir. Eğer data'nın veri türü string ise true döner, değilse false döner.
{
    Console.WriteLine("Veri Türü Stringdir");
}
else if (data is int) // is operatörünü kullanarak data'nın veri türünü kontrol ediyoruz. buna tip kontrolü denir. Eğer data'nın veri türü int ise true döner, değilse false döner.
{
    Console.WriteLine("Veri Türü Intdir");
}
else
{
    Console.WriteLine("Veri Baska Bir Türdedir");
}


