//String Tanimlama
string message = "Hello World!"; // burda string tipinde bir değişken tanımlıyoruz ve değer atıyoruz
Console.WriteLine("First Message: " + message); // burda + işareti ile string birleştirme işlemi yapıyoruz


// immutable  burda mesaj ifadesini degistiremiyoruz cunku string immutable bir tiptir. yani degistirilemez.
string newMessage = message + " How are you?"; // burda + işareti ile string birleştirme işlemi yapıyoruz
Console.WriteLine("New Message: " + newMessage);
Console.WriteLine("Old Message: " + message);


//Diziye benzer islemler
Console.WriteLine("First Character: " + message[0]);
Console.WriteLine("First Character: " + message[message.Length - 1]); // burda Length metodu ile string ifadenin karakter sayısını buluyoruz ve -1 ile son karakteri buluyoruz

//Döngüler
Console.WriteLine("\nAll Characters:"); // burda \n ile alt satıra geçiyoruz
foreach (char c in newMessage) // burda foreach döngüsü ile string ifadenin tüm karakterlerini tek tek yazdırıyoruz
{
    Console.WriteLine(c);
}

//String Metotları
Console.WriteLine("Karakter Sayisi :" +message.Length); // burda Length metodu ile string ifadenin karakter sayısını buluyoruz.
Console.WriteLine("Büyük Harf: " + message.ToUpper()); // burda ToUpper metodu ile string ifadenin tüm karakterlerini büyük harfe çeviriyoruz.
Console.WriteLine("Dünya Iceriyor mu?" + message.Contains("Dünya")); //burda Contains metodu ile string ifadenin içinde "Dünya" kelimesi var mı yok mu kontrol ediyoruz.
