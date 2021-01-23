using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Proglamlamaya başlangıç için temel kurs", "Java" , "python" , "C#" };


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            // foreach - dizileri tek tek dönmeye yarar54
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
