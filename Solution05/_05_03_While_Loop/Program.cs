//tanimlama
int[] numbers = { 5, 10, 15, -3, 20, 25 };

//baslangic
int i = 0;

while (i < numbers.Length && numbers[i] >=0)
{


   // if (numbers[i] < 0) // sayaci arttir
    //{
      //  i++;
        //continue;
    //}
    Console.WriteLine($"Pozitif Sayi: {numbers[i]}");

    i++;

}

Console.ReadKey();