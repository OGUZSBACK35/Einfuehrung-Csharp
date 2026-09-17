int? age = 22; // int tipi
var name = "Oguzhan"; // string tipi

Console.WriteLine("Age Degisken Tipi:" + age?.GetType()); // int tipinde olduğu için System.Int32 tipini döndürür.
Console.WriteLine("Name Degiskenin Tipi:" + name.GetType()); // string tipinde olduğu için System.String tipini döndürür.

string? nullable = name;
Console.WriteLine("Büyük Harf :" + nullable.ToUpper()); // büyük harf yapar.
Console.WriteLine("Kullanici Adi : " + nullable); // null değer ataması yapıldığı için hata verir.
Console.WriteLine("Yas : " + (age ?? -1));

Console.ReadKey(); // Programın sonlanmasını engellemek için eklenmiştir.
                   // null bir deger varsa onu okumasi icin ? kullanilir. null degilse degerini alir. null ise null degerini alir.      