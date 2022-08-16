using System;

namespace patika.dev_odev_soru_4
{
    class Program
    {
        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
        //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string[] kelime = cumle.Split(' ');
            int kelimeSayisi = cumle.Trim().Split(' ').Length;
            Console.WriteLine("Kelime sayısı: " + kelimeSayisi.ToString());
            string liste = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ" +
                "abcçdefgğhıijklmnoöprsştuüvyz";
            int sayac = 0;
            for(int i = 0; i < cumle.Length; i++)
            {
                if(liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Harf sayısı: {0}", sayac);
        }
    }
}