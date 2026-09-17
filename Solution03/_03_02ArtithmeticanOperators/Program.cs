namespace _03_02ArtithmeticanOperators //paket bilgisi 
{
    public class Program 
    {
        static void Main(string[] args) // main metodu (giris noktasi), programın başlangıç noktasıdır. Program çalıştırıldığında ilk olarak bu metod çağrılır. 
        {
            //Toplama

            //Fark
            int a = 5;
            int b = 3;

            //Toplama
            int sum = 5 + 3;
            Console.WriteLine($"toplam : {sum}"); // $ isareti ile string interpolation kullanıldı ve sum değişkeni ekrana yazdırıldı

            //Çıkarma
            Console.WriteLine($"{a} - {b} = {a - b}");

            //Çarpma
            int c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");

            //Bölme
            int d = a / b;
            var e = (double) a / b; // her iki tarafinda ayni olmasi gerek. Ayni olmazsa beklenen sonuc cikmaz. double türünde bir değişken tanımlandı ve ekrana yazdırıldı
            Console.WriteLine($"d degiskeni tipi: {d.GetType()}");
            Console.WriteLine($" e degiskeni tipi : {e.GetType()}");
            Console.WriteLine($"{a} / {b} = {d}");
            Console.WriteLine($"{a} / {b} = {e}");

            int increase = 5; //increase demek arttırmak demektir. int türünde bir değişken tanımlandı ve ekrana yazdırıldı
            increase ++ ; //increase değişkeninin değeri 1 arttırıldı ve ekrana yazdırıldı

            int decrease = 5; //decrease demek azaltmak demektir. int türünde bir değişken tanımlandı ve ekrana yazdırıldı
            decrease -- ; //decrease değişkeninin değeri 1 azaltıldı ve ekrana yazdırıldı

            Console.WriteLine($"Arttırma : {increase}");
            Console.WriteLine($"Azaltma : {decrease}");

            //Mod Alma
            int f = a % b;  //mod alma işlemi
            Console.WriteLine($" {a} % {b} = {f}"); //mod alma işlemi ekrana yazdırıldı

            Console.ReadKey(); //Console.ReadKey() metodu, kullanıcıdan bir tuşa basmasını bekler ve ardından programın sonlanmasını sağlar.

        }
    }
}
