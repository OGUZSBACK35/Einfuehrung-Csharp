
//Vize
Console.WriteLine("Vize Notunuzu Giriniz:");
double midterm = Convert.ToDouble(Console.ReadLine()); // Convert.ToDouble() metodu, kullanıcıdan alınan string türündeki veriyi double türüne dönüştürür.

//Final
Console.WriteLine("Final Notunuzu Giriniz:");
double finalExam = Convert.ToDouble(Console.ReadLine()); // Convert.ToDouble() metodu, kullanıcıdan alınan string türündeki veriyi double türüne dönüştürür.)

var finalGrade = (midterm * 0.4) + (finalExam * 0.6); // finalGrade değişkeni, vize notunun %40'ı ve final notunun %60'ı alınarak hesaplanır.

Console.WriteLine($"Final Notunuz: {finalGrade}");

//Karar
if (finalGrade >= 50)
    Console.WriteLine("Tebrikler, dersi geçtiniz.");
else
    Console.WriteLine("Maalesef, dersi geçemediniz.");

Console.ReadKey(); //Console.ReadKey() metodu, kullanıcıdan bir tuşa basmasını bekler ve ardından programın sonlanmasını sağlar.