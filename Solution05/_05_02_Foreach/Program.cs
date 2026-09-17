
//tanim - baslangic
int[] numbers = new int[] {10, 20, 30,40, 50};

//toplam
int sum = 0; 

//foreach
//foreach (var number in numbers) // 
  foreach (int number in numbers) // 
{
    sum += number; // 
    
}

// ortalama hesabi
double avarage = (double)sum / numbers.Length;

//Sonucu Yazdir
Console.WriteLine($"Ortalama; {avarage:F2}");
Console.ReadKey();

