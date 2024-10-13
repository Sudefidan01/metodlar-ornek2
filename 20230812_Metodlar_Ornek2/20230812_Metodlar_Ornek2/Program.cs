using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230812_Metodlar_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan kaç adet sayı girmek istediğini talep edelim
            //Talep edilen Sayıların toplamını ve ortalamasını ekrana yazdıralım
            Console.Write("Kaç Adet Sayı Girmek İstersiniz ");
            int adet=int.Parse(Console.ReadLine());

            int[] sayilarDizisi = new int[adet];
            for (int i = 0; i < sayilarDizisi.Length; i++)
            {
                Console.Write((i+1)+".Sayıyı Girin");
                sayilarDizisi[i]=int.Parse(Console.ReadLine());
            }

            Metodlar metodlar=new Metodlar();
            int toplam2 = metodlar.ToplamaYaptir(sayilarDizisi);

            metodlar.ToplamiVeOrtalamayiYazdir(toplam2,sayilarDizisi.Length);

            Console.ReadKey();

        }
    }
}
