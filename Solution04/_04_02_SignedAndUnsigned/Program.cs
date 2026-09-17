//Isaretsiz Byte
Console.WriteLine("Isaretsiz Byte 0-255");
Console.WriteLine($"Min Deger: {byte.MinValue}, Max Deger: {byte.MaxValue}");

Console.WriteLine("byte -128 - 127");
Console.WriteLine($"Min Deger: {sbyte.MinValue}, Max Deger: {sbyte.MaxValue}");

// Isaretsiz Degerlerde wrap´-aruond
Console.WriteLine("");
byte unsignedValue  = 255;
Console.WriteLine($"Baslangic Degeri: {unsignedValue}");
unsignedValue++; // 255 + 1 = 0 
Console.WriteLine($"Tasma Sonrasi Deger: {unsignedValue}");

//Ikili Gösterim (binary)
Console.WriteLine("Binary Karsiliklar");
Console.WriteLine($"Byte : {Convert.ToString (255,2)}");
Console.WriteLine($"Byte : {Convert.ToString(128, 2)}");
Console.WriteLine($"Byte : {Convert.ToString(64, 2)}");
Console.WriteLine($"Byte : {Convert.ToString(32, 2)}");
Console.WriteLine($"Byte : {Convert.ToString(16, 2)}");
Console.WriteLine($"Byte : {Convert.ToString(8, 2)}");
Console.WriteLine($"Byte : {Convert.ToString(4, 2)}");
Console.WriteLine($"Byte : {Convert.ToString(2, 2)}");
Console.WriteLine($"Byte : {Convert.ToString(1, 2)}");

Console.ReadKey();