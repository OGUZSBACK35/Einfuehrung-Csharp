namespace _03_03_CompsarsionOpt
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Birinci Tam Sayiyi Giriniz:");
            int? a = int.Parse(Console.ReadLine()); // int.Parse() metodu, kullanıcıdan alınan string türündeki veriyi int türüne dönüştürür.

            Console.WriteLine($"Ikinci Tam Sayiyi Giriniz:");
            int b = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32() metodu, kullanıcıdan alınan string türündeki veriyi int türüne dönüştürür.

            Console.WriteLine($" {a} != {b} = {a != b}"); // != operatörü, iki değerin eşit olup olmadığını kontrol eder. Eşit değilse true, eşitse false döner.
            Console.WriteLine($" {a} > {b} = {a > b}"); // > operatörü, bir değerin diğerinden büyük olup olmadığını kontrol eder. Büyükse true, küçükse false döner.
            Console.WriteLine($" {a} < {b} = {a < b}"); // < operatörü, bir değerin diğerinden küçük olup olmadığını kontrol eder. Küçükse true, büyükse false döner.
            Console.WriteLine($" {a} = {b} = {a == b}"); // == operatörü, iki değerin eşit olup olmadığını kontrol eder. Eşitse true, eşit değilse false döner.

            Console.ReadKey(); //Console.ReadKey() metodu, kullanıcıdan bir tuşa basmasını bekler ve ardından programın sonlanmasını sağlar.



        }
    }
}
