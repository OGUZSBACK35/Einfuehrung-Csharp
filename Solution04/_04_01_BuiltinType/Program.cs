//Kur Bilgileri ve Tarih
using System.Threading.Tasks.Dataflow;

var dollarRate = 40.70m; //sonuna f gelirsa float, d gelirse double, m gelirse decimal olur. finansal islermlerde decimal kullanmak daha mantıklıdır. float ve double yuvarlama hatası yapabilir.
decimal euroRate = 55.50m;
decimal goldRate = 4400m;
DateTime rateDate = DateTime.Now;

Console.WriteLine("TL Miktarini girin:");
decimal amountInTL = Convert.ToDecimal(Console.ReadLine()); 

//Menü
Console.WriteLine("\n Dönüstürme Secenekleri"); // \n ile alt satira geciyor
Console.WriteLine("1- Dolar"); 
Console.WriteLine("2- Euro");
Console.WriteLine("3- Altın (gram)");

Console.WriteLine("\n Secimizi Yapiniz (1-3):");
int choice = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 ile string ifadeyi int'e ceviriyoruz.

decimal result = 0m;
string currenyName = "";

switch (choice)
{
    case 1: // Dolar
        result = amountInTL / dollarRate;
        currenyName = "USD";
        break;
    case 2: // Euro
        result = amountInTL / euroRate;
        currenyName = "EUR";
        break;
    case 3: //Altın
        result = amountInTL / goldRate;
        currenyName = "Gram Altın";
        break;
    default: // Gecersiz secim
        Console.WriteLine("Gecersiz Giris!");
        return; // Programi sonlandirir. 
}

Console.WriteLine($"\n Tarih: {rateDate}");
Console.WriteLine($"Girilen TL Miktari : {amountInTL} TL");
Console.WriteLine($"Elde Edilen {currenyName} Miktari : {result:F2} {currenyName}");
Console.WriteLine("\n ---Kurlar---");
Console.WriteLine($"Dolar Kuru: {dollarRate} TL");
Console.WriteLine($"Euro Kuru: {euroRate} TL");
Console.WriteLine($"Altın Kuru: {goldRate} TL");

//Console.WriteLine(dollarRate.GetType());
Console.ReadKey();