// dizi tanimlama
int[] grades = new int[3];

//sayac
int i = 0;

//do - while
do
{
    System.Console.WriteLine("Not Giriniz:");
    grades[i] = Convert.ToInt32(System.Console.ReadLine());
    i++;
}
while (i < grades.Length);

System.Console.WriteLine("Girilen Notlar:"); // 

foreach (int grade in grades)
{
    Console.WriteLine(grade);
}

Console.ReadKey();
