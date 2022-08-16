using System;

namespace patika.dev_odev_soru_3
{
    class Program
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
        //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pozitif bir tam sayı giriniz: ");
                while (true)
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    string[] sayiDizisi = new string[n];
                    if (n <= 0)
                    {
                        Console.WriteLine("Lütfen pozitif tam sayı giriniz: ");
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Lütfen {0}.kelimeyi giriniz. ", i + 1);
                            sayiDizisi[i] = Convert.ToString(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("Tersine sıralanmış hali");
                    Array.Reverse(sayiDizisi);
                    foreach (var kelime in sayiDizisi)
                        Console.WriteLine(kelime);
                    break;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("HATA! Yanlış veri girişi.");
            }
        }
    }
}