//Deger Tip

int num1 = 10; // numara 1'in degeri tipi int, yani değer tiptir. Değer tipler stack'te tutulur.
int num2 = 20; // numara 2'nin degeri tipi int, yani değer tiptir. Değer tipler stack'te tutulur.

Console.WriteLine($"Metot Cagirisi Öncesi num1 = {num1} ve num2 = {num2}"); //Metot cagrisi öncesi num1 = 10 ve num2 = 20
SwapNumbers(num1, num2); // Metot cagrisi sonrasi num1 = 10 ve num2 = 20
Console.WriteLine($"Metot Cagirisi Sonrasi num1 = {num1} ve num2 = {num2}"); //Metot cagrisi sonrasi num1 = 10 ve num2 = 20

//Referans Tip
int[] numbers = { 10, 20 }; //Referans tipi bir dizi
Console.WriteLine($"Metot Cagirisi Öncesi num1 = {numbers[0]} ve num2 = {numbers[1]}"); //Metot cagrisi öncesi num1 = 10 ve num2 = 20
SwapArray(numbers); // Metot cagrisi sonrasi num1 = 20 ve num2 = 10
Console.WriteLine($"Metot Cagirisi Sonrasi num1 = {numbers[0]} ve num2 = {numbers[1]}"); //Metot cagrisi sonrasi num1 = 20 ve num2 = 10







static void SwapArray(int[] numbers) // Referans tip metot


{
    int temp = numbers[0]; // burda temp = 10 olur
    numbers[0] = numbers[1]; // burda numbers[0] = numbers[1]; // burda numbers[0] = 20 olur
    numbers[1] = temp; // burda numbers[1] = 10 olur
}

static void SwapNumbers(int a, int b) // Değer tip metot
{
    int temp = a; // burda temp = 10 olur
    a = b; // burda a = 20 olur
    b = temp;  // burda b = 10 olur
}

Console.ReadKey();