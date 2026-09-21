using System.Security.Cryptography.X509Certificates;

namespace _05_05StudentApp;

class Program
{
    static void Main(string[] args)
    {
        // dizi tanimi
        int[] grades = {70, 85, 90, 60, 100, 75, 83, 92, 55, 78};
        // ortalama hesaplama
        double average = CalculateAverage(grades);

        (int minGrade, int maxGrade) = FindMinMax(grades);
    }

    private static (int minGrade, int maxGrade) FindMinMax(int[] grades)
    {
       int min = grades[0];
       int max = grades[0];

        foreach (var g in grades)
        {
            if (g < min) min = g;
            if (g > max) max = g;
        }
        return (min, max);
    }


    private static double CalculateAverage(int[] grades)
    {
       // kontrol
       if (grades== null || grades.Length == 0)
        {
            return 0; //veya uygun bir hata değeri döndürebilirsiniz
        }

        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return (double)sum / grades.Length;
    }
}
