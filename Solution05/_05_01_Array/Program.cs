// dizi tanimi
// dizi tanimi yaparken öncelikle tipi belirlenir ve bu tipe bagli olarak "[]" ifadesi gelecek daha sonra dizi ismi yazilir ve "=" ifadesi ile diziye deger atamasi yapilir.
// Dizi degerleri ise "{" ve "}" arasina yazilir ve her bir deger arasina "," konulur.

int[] numbers = new int[5];  //

//deger atama
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

Console.WriteLine("Dizi Elemanlari");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{i}. indis degerindeki deger: {numbers[i]}");
    
}

Console.WriteLine("Dizi Elemanlari (Ters Sirada Dolastirma)");


for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"{i}. indis degerindeki deger: {numbers[i]}");

}

Console.ReadKey();