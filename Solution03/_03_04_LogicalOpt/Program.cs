Console.WriteLine("Yasinizi Giriniz:");
int age = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32() metodu, kullanıcıdan alınan string türündeki veriyi int türüne dönüştürür.

Console.WriteLine("Saglik Raporunuz Var Mi? (Evet/Hayir)");
string reportInput = Console.ReadLine().ToLower(); // ToLower() metodu, kullanıcıdan alınan string türündeki veriyi küçük harfe dönüştürür.
bool hasHealthReport = reportInput == "evet"; // hasHealthReport değişkeni, kullanıcıdan alınan string türündeki veriyi boolean türüne dönüştürür.

if (age >= 18 &&hasHealthReport) // && operatörü, iki koşulun da doğru olması durumunda true döner. Koşullardan herhangi biri yanlışsa false döner.
{
    Console.WriteLine("Ehliyet Alabilirsiniz."); 
}
else // else bloğu, if bloğunun koşulu sağlanmadığında çalışır.
{
    Console.WriteLine("Ehliyet Alamazsiniz."); 
}
if (age >= 18 || hasHealthReport) // || operatörü, iki koşuldan herhangi birinin doğru olması durumunda true döner. Koşullardan her ikisi de yanlışsa false döner.
{
    Console.WriteLine("Kosullardan Herhangi Birisi Saglanmistir."); // if bloğunun koşulu sağlanmadığında çalışır.
}
else // else bloğu, if bloğunun koşulu sağlanmadığında çalışır.
{
    Console.WriteLine("Kosullardan Hiçbiri Saglanmamistir.");
}