using System;

namespace patika.dev_odev_soru_1
{
    class Program
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pozitif bir tam sayı giriniz: ");
                while (true)
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] sayiDizisi = new int[n];
                    if (n <= 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir tam sayı giriniz: ");
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i + 1);
                            sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int sayac = 1;
                        Console.WriteLine("Çift sayılar: ");
                        foreach (int eleman in sayiDizisi)
                        {
                            if (eleman % 2 == 0)
                            {
                                sayac++;
                                Console.Write(eleman + " ");
                            }
                        }
                        break;
                    }
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("HATA! Lütfen pozitif tam sayı giriniz:");
            }
        }
    }
}