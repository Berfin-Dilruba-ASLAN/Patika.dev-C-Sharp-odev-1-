using System;

namespace patika.dev_odev_soru_2
{
    class Program
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
        //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("2 adet pozitif tam sayı giriniz: ");
                while (true)
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    int m = Convert.ToInt32(Console.ReadLine());
                    int[] sayiDizisi = new int[n];
                    if (n <= 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir tam sayı giriniz: ");
                        if (m <= 0)
                        {
                            Console.WriteLine("Lütfen pozitif bir tam sayı giriniz:");
                            continue;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Lütfen {0}.sayıyı giriniz: ", i + 1);
                            sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int sayac = 1;
                        Console.WriteLine("Eşit veya tam bölünenler: ");
                        foreach (int eleman in sayiDizisi)
                        {
                            if (n % eleman == 0)
                            {
                                sayac++;
                                Console.WriteLine(eleman);
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
